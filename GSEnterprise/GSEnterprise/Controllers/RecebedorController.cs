using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSEnterprise.Models.Contexto;
using GSEnterprise.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace GSEnterprise.Controllers
{
    public class RecebedorController : Controller
    {
        private readonly Contexto _contexto;
        public RecebedorController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var lista = _contexto.Recebedor.ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var recebedor = new Recebedor();
            return View(recebedor);
        }

        [HttpPost]
        public IActionResult Create(Recebedor recebedor)
        {
            if (ModelState.IsValid)
            {
                _contexto.Recebedor.Add(recebedor);
                _contexto.SaveChanges();

                return RedirectToAction("index");
            }

            return View(recebedor);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var recebedor = _contexto.Recebedor.Find(Id);

            if(recebedor != null)
            {

            }
            return View(recebedor);
        }

        [HttpPost]
        public IActionResult Edit(Recebedor recebedor)
        {
            if (ModelState.IsValid)
            {
                _contexto.Recebedor.Update(recebedor);
                _contexto.SaveChanges();

                return RedirectToAction("index");
            }

            return View(recebedor);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var recebedor = _contexto.Recebedor.Find(Id);
            return View(recebedor);
        }

        public IActionResult Delete(Recebedor _recebedor)
        {
            var recebedor = _contexto.Recebedor.Find(_recebedor.Id);

            if(recebedor != null)
            {
                _contexto.Recebedor.Remove(recebedor);
                _contexto.SaveChanges();

                return RedirectToAction("index");
            }

            return View(recebedor);
        }

        public IActionResult Details(int Id)
        {
            var recebedor = _contexto.Recebedor.Find(Id);
            return View(recebedor);
        }


    }
}