using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agencia_Datos_Entidades;
using Agencia_Dominio;

namespace Agencia.Controllers
{
    public class UbigeoController : Controller
    {
        private readonly D_Ubigeo ubigeo;
        public UbigeoController(D_Ubigeo ubigeo)
        {
            this.ubigeo = ubigeo;
        }
        //
        // GET: /Ubigeo/
        public ActionResult Index()
        {
            var items = ubigeo.TraerTodo();
            return View(items);
        }

        //
        // GET: /Ubigeo/Details/5
        public ActionResult Details(string id)
        {
            var item = ubigeo.TraerUno(id);
            return View(item);
        }

        //
        // GET: /Ubigeo/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Ubigeo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Ubigeo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Ubigeo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Ubigeo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Ubigeo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
