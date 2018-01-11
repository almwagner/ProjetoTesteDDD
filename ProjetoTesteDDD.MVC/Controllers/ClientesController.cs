using AutoMapper;
using ProjetoTesteDDD.MVC.ViewModels;
using ProjetoTesteDDD.MVC.WCFService;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoTesteDDD.MVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ServiceClient _wcfServiceClient = new ServiceClient();

        // GET: Clientes
        public ActionResult Index(string id, string nome)
        {
            var clientes = _wcfServiceClient.GetClienteAllWithFilters(id, nome);
            IEnumerable<ClienteViewModel> clienteViewModels = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(clientes);

            return View(clienteViewModels);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(_wcfServiceClient.GetClienteById(id));
            return View(clienteViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel clienteViewModel)
        {
            if(ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
                _wcfServiceClient.AddCliente(clienteDomain);

                return RedirectToAction("Index");
            }

            return View(clienteViewModel);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(_wcfServiceClient.GetClienteById(id));
            return View(clienteViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel clienteViewModel)
        {
            if(ModelState.IsValid)
            {
                var clienteEntity = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
                _wcfServiceClient.UpdateCliente(clienteEntity);

                return RedirectToAction("Index");
            }

            return View(clienteViewModel);
        }
    }
}
