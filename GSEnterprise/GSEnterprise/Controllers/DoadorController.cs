using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSEnterprise.Models.Contexto;
using GSEnterprise.Models.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace GSEnterprise.Controllers
{
    public class DoadorController : Controller
    {

        private readonly Contexto _contexto;
        public DoadorController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var lista = _contexto.Doador.ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var doador = new Doador();

            return View(doador);
        }

        [HttpPost]
        public IActionResult Create(Doador doador)
        {
            if (ModelState.IsValid)
            {
                _contexto.Doador.Add(doador);
                _contexto.SaveChanges();

                return RedirectToAction("index");
            }

            return View(doador);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var doador = _contexto.Doador.Find(Id);

            if(doador != null)
            {
                
            }

            return View(doador);
        }

        [HttpPost]
        public IActionResult Edit(Doador doador)
        {
            if (ModelState.IsValid)
            {
                _contexto.Doador.Update(doador);
                _contexto.SaveChanges();
                return RedirectToAction("index");
            }

            return View(doador);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var doador = _contexto.Doador.Find(Id);
            return View(doador);
        }

        [HttpPost]
        public IActionResult Delete(Doador _doador)
        {
            var doador = _contexto.Doador.Find(_doador.Id);

            if (doador != null)
            {
                _contexto.Doador.Remove(doador);
                _contexto.SaveChanges();
                return RedirectToAction("index");
            }

            return View(doador);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var doador = _contexto.Doador.Find(Id);
            return View(doador);
        }


    }
}