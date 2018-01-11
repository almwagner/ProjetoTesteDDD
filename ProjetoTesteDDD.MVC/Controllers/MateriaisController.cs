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
    public class MateriaisController : Controller
    {
        private readonly ServiceClient _wcfServiceClient = new ServiceClient();

        // GET: Materiais
        public ActionResult Index(string id, string descricao)
        {
            var materiaisEntities = _wcfServiceClient.GetMaterialAllWithFilters(id, descricao);

            IEnumerable<MaterialViewModel> materialViewModels = Mapper.Map<IEnumerable<Material>, IEnumerable<MaterialViewModel>>(materiaisEntities);

            materialViewModels.ForEach(m => m.TipoMaterialDescricao = _wcfServiceClient.GetTipoMaterialById(m.TipoMaterialId).Descricao);

            return View(materialViewModels);
        }

        // GET: Materiais/Details/5
        public ActionResult Details(int id)
        {
            MaterialViewModel materialViewModel = Mapper.Map<Material, MaterialViewModel>(_wcfServiceClient.GetMaterialById(id));
            materialViewModel.TipoMaterialDescricao = _wcfServiceClient.GetTipoMaterialById(materialViewModel.TipoMaterialId).Descricao;
            return View(materialViewModel);
        }

        // GET: Materiais/Create
        public ActionResult Create()
        {
            MaterialViewModel materialViewModel = new MaterialViewModel { TipoMateriais = GetTipoMateriaisDropDownList() };
            return View(materialViewModel);
        }

        // POST: Materiais/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MaterialViewModel materialViewModel)
        {
            if(ModelState.IsValid)
            {
                var materialEntity = Mapper.Map<MaterialViewModel, Material>(materialViewModel);
                _wcfServiceClient.AddMaterial(materialEntity);

                return RedirectToAction("Index");
            }

            materialViewModel.TipoMateriais = GetTipoMateriaisDropDownList();
            return View(materialViewModel);
        }

        // GET: Materiais/Edit/5
        public ActionResult Edit(int id)
        {
            var materialEntity = _wcfServiceClient.GetMaterialById(id);
            MaterialViewModel materialViewModel = Mapper.Map<Material, MaterialViewModel>(materialEntity);

            materialViewModel.TipoMateriais = GetTipoMateriaisDropDownList();
            return View(materialViewModel);
        }

        // POST: Materiais/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MaterialViewModel materialViewModel)
        {
            if(ModelState.IsValid)
            {
                var materialEntity = Mapper.Map<MaterialViewModel, Material>(materialViewModel);
                _wcfServiceClient.UpdateMaterial(materialEntity);

                return RedirectToAction("Index");
            }

            materialViewModel.TipoMateriais = GetTipoMateriaisDropDownList();
            return View(materialViewModel);
        }

        private IList<SelectListItem> GetTipoMateriaisDropDownList()
        {
            IList<SelectListItem> listaTiposMateriais = new List<SelectListItem>();

            var tipoMateriais = _wcfServiceClient.GetTipoMaterialAll();

            listaTiposMateriais = tipoMateriais.Select(t => new SelectListItem
            {
                Text = t.Descricao,
                Value = t.TipoMaterialId.ToString()
            }).ToList();

            listaTiposMateriais.Insert(0, new SelectListItem { Text = "Selecione um tipo de material", Value = "" });

            return listaTiposMateriais;
        }
    }
}
