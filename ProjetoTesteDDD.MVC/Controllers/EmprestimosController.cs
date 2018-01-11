using AutoMapper;
using ProjetoTesteDDD.MVC.ViewModels;
using ProjetoTesteDDD.MVC.WCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease.Css.Extensions;

namespace ProjetoTesteDDD.MVC.Controllers
{
    public class EmprestimosController : Controller
    {
        private readonly WCFService.ServiceClient _wcfServiceClient = new ServiceClient();

        // GET: Emprestimos
        public ActionResult Index()
        {
            var emprestimos = Mapper.Map<IEnumerable<Emprestimo>, IEnumerable<EmprestimoViewModel>>(_wcfServiceClient.GetEmprestimolAll());

            IEnumerable<EmprestimoViewModel> emprestimoViewModels;

            emprestimoViewModels = emprestimos.Select(m => new EmprestimoViewModel
            {
                EmprestimoId = m.EmprestimoId,
                ClienteNome =_wcfServiceClient.GetClienteById(m.ClienteId).Nome,
                DataDevolucaoDescricao = m.DataDevolucao != DateTime.MinValue ? m.DataDevolucao.ToString("dd/MM/yyyy") : "-",
                DataDevolverDescricao = m.DataDevolver.ToString("dd/MM/yyyy"),
                MaterialDescricao = _wcfServiceClient.GetMaterialById(m.MaterialId).Descricao,
                DevolvidoDescricao = m.Devolvido ? "Sim" : "Não"
            });

            return View(emprestimoViewModels);
        }

        // GET: Emprestimos/Details/5
        public ActionResult Details(int id)
        {
            EmprestimoViewModel emprestimoViewModel = Mapper.Map<Emprestimo, EmprestimoViewModel>(_wcfServiceClient.GetEmprestimoById(id));

            emprestimoViewModel.ClienteNome = _wcfServiceClient.GetClienteById(emprestimoViewModel.ClienteId).Nome;
            emprestimoViewModel.MaterialDescricao = _wcfServiceClient.GetMaterialById(emprestimoViewModel.MaterialId).Descricao;
            emprestimoViewModel.DataDevolucaoDescricao = emprestimoViewModel.DataDevolucao != DateTime.MinValue ? emprestimoViewModel.DataDevolucao.ToString("dd/MM/yyyy") : "-";
            emprestimoViewModel.DataDevolverDescricao = emprestimoViewModel.DataDevolver.ToString("dd/MM/yyyy");
            emprestimoViewModel.DevolvidoDescricao = emprestimoViewModel.Devolvido ? "Sim" : "Não";

            return View(emprestimoViewModel);
        }

        // GET: Emprestimos/Create
        public ActionResult Create()
        {
            EmprestimoViewModel emprestimoViewModel = new EmprestimoViewModel
            {
                Clientes = GetClientesDropDownList(),
                Materiais = GetMateraisDropDownList()
            };

            return View(emprestimoViewModel);
        }

        // POST: Emprestimos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmprestimoViewModel emprestimoViewModel)
        {
            if(ModelState.IsValid)
            {
                var emprestimoEntity = Mapper.Map<EmprestimoViewModel, Emprestimo>(emprestimoViewModel);
                emprestimoEntity.Devolvido = false;
                emprestimoEntity.DataDevolver = CalculaDataDevolucao(emprestimoEntity);
                _wcfServiceClient.AddEmprestimo(emprestimoEntity);

                return RedirectToAction("Index");
            }

            emprestimoViewModel.Clientes = GetClientesDropDownList();
            emprestimoViewModel.Materiais = GetMateraisDropDownList();
            return View(emprestimoViewModel);
        }

        private DateTime CalculaDataDevolucao(Emprestimo emprestimoEntity)
        {
            var materialEntity = _wcfServiceClient.GetMaterialById(emprestimoEntity.MaterialId);
            var tipoMaterialEntity = _wcfServiceClient.GetTipoMaterialById(materialEntity.TipoMaterialId);

            return DateTime.Now.AddDays(tipoMaterialEntity.DevolucaoEmDias);
        }

        // GET: Emprestimos/Edit/5
        public ActionResult Edit(int id)
        {
            EmprestimoViewModel emprestimoViewModel = Mapper.Map<Emprestimo, EmprestimoViewModel>(_wcfServiceClient.GetEmprestimoById(id));

            emprestimoViewModel.Clientes = GetClientesDropDownList();
            emprestimoViewModel.Materiais = GetMateraisDropDownList();

            return View(emprestimoViewModel);
        }

        // POST: Emprestimos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmprestimoViewModel emprestimoViewModel)
        {
            if (ModelState.IsValid)
            { 
                var emprestimOriginal = _wcfServiceClient.GetEmprestimoById(emprestimoViewModel.EmprestimoId);
                var emprestimoEntity = Mapper.Map<EmprestimoViewModel, Emprestimo>(emprestimoViewModel);

                if (emprestimOriginal.MaterialId != emprestimoEntity.MaterialId)
                    emprestimoEntity.DataDevolver = CalculaDataDevolucao(emprestimoEntity);

                _wcfServiceClient.UpdateEmprestimo(emprestimoEntity);

                return RedirectToAction("Index");
            }

            emprestimoViewModel.Clientes = GetClientesDropDownList();
            emprestimoViewModel.Materiais = GetMateraisDropDownList();
            return View(emprestimoViewModel);
        }

        // GET: Emprestimos/Devolver/5
        public ActionResult Devolver(int id)
        {
            EmprestimoViewModel emprestimoViewModel = Mapper.Map<Emprestimo, EmprestimoViewModel>(_wcfServiceClient.GetEmprestimoById(id));

            emprestimoViewModel.ClienteNome = _wcfServiceClient.GetClienteById(emprestimoViewModel.ClienteId).Nome;
            emprestimoViewModel.MaterialDescricao = _wcfServiceClient.GetMaterialById(emprestimoViewModel.MaterialId).Descricao;
            emprestimoViewModel.DataDevolucaoDescricao = emprestimoViewModel.DataDevolucao != DateTime.MinValue ? emprestimoViewModel.DataDevolucao.ToString("dd/MM/yyyy") : "-";
            emprestimoViewModel.DataDevolverDescricao = emprestimoViewModel.DataDevolver.ToString("dd/MM/yyyy");
            emprestimoViewModel.DevolvidoDescricao = emprestimoViewModel.Devolvido ? "Sim" : "Não";

            return View(emprestimoViewModel);
        }

        // POST: Emprestimos/DevolverConfirmed/5
        [HttpPost, ActionName("Devolver")]
        [ValidateAntiForgeryToken]
        public ActionResult DevolverConfirmed(int id)
        {
            var emprestimoEntity = _wcfServiceClient.GetEmprestimoById(id);
            _wcfServiceClient.DevolverEmprestimo(emprestimoEntity);

            return RedirectToAction("Index");
        }

        private IList<SelectListItem> GetClientesDropDownList()
        {
            IList<SelectListItem> listaClientes = new List<SelectListItem>();

            var clientes = _wcfServiceClient.GetClienteAll();

            listaClientes = clientes.Select(c => new SelectListItem
            {
                Text = c.Nome,
                Value = c.ClienteId.ToString()
            }).ToList();

            listaClientes.Insert(0, new SelectListItem { Text = "Selecione um cliente", Value = "" });

            return listaClientes;
        }

        private IList<SelectListItem> GetMateraisDropDownList()
        {
            IList<SelectListItem> listaMateriais = new List<SelectListItem>();

            var materiais = _wcfServiceClient.GetMaterialAll();

            listaMateriais = materiais.Select(m => new SelectListItem
            {
                Text = m.Descricao,
                Value = m.MaterialId.ToString()
            }).ToList();

            listaMateriais.Insert(0, new SelectListItem { Text = "Selecione um material", Value = "" });

            return listaMateriais;
        }
    }
}
