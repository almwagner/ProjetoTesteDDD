using AutoMapper;
using ProjetoTesteDDD.MVC.ViewModels;
using ProjetoTesteDDD.MVC.WCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTesteDDD.MVC.Controllers
{
    public class TipoMateriaisController : Controller
    {
        private readonly ServiceClient _wcfServiceClient = new ServiceClient();

        // GET: TipoMateriais
        public ActionResult Index(string id, string descricao)
        {
            var tipoMateriais = _wcfServiceClient.GetTipoMaterialAllWithFilters(id, descricao);
            IEnumerable<TipoMaterialViewModel> tipoMaterialViewModel = Mapper.Map<IEnumerable<TipoMaterial>, IEnumerable<TipoMaterialViewModel>>(tipoMateriais);

            return View(tipoMaterialViewModel);
        }

        // GET: TipoMateriais/Details/5
        public ActionResult Details(int id)
        {
            var tipoMaterialEntity = _wcfServiceClient.GetTipoMaterialById(id);
            TipoMaterialViewModel tipoMaterialViewModel = Mapper.Map<TipoMaterial, TipoMaterialViewModel>(tipoMaterialEntity);
            return View(tipoMaterialViewModel);
        }

        // GET: TipoMateriais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoMateriais/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoMaterialViewModel tipoMaterialViewModel)
        {
            if(ModelState.IsValid)
            {
                var tipoMaterialEntity = Mapper.Map<TipoMaterialViewModel, TipoMaterial>(tipoMaterialViewModel);
                _wcfServiceClient.AddTipoMaterial(tipoMaterialEntity);

                return RedirectToAction("Index");
            }

            return View(tipoMaterialViewModel);
        }

        // GET: TipoMateriais/Edit/5
        public ActionResult Edit(int id)
        {
            var tipoMaterialEntity = _wcfServiceClient.GetTipoMaterialById(id);
            TipoMaterialViewModel tipoMaterialViewModel = Mapper.Map<TipoMaterial, TipoMaterialViewModel>(tipoMaterialEntity);
            return View(tipoMaterialViewModel);
        }

        // POST: TipoMateriais/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TipoMaterialViewModel tipoMaterialViewModel)
        {
            if(ModelState.IsValid)
            {
                var tipoMaterialEntity = Mapper.Map<TipoMaterialViewModel, TipoMaterial>(tipoMaterialViewModel);
                _wcfServiceClient.UpdateTipoMaterial(tipoMaterialEntity);

                return RedirectToAction("Index");
            }

            return View(tipoMaterialViewModel);
        }
    }
}
