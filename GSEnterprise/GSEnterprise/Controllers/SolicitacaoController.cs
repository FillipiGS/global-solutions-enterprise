using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GSEnterprise.Models.Contexto;
using GSEnterprise.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GSEnterprise.Controllers
{
    public class SolicitacaoController : Controller
    {
        private readonly Contexto _contexto;
        public SolicitacaoController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var lista = _contexto.Solicitacao.ToList();
            CarregaTipoAlimento();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var solicitacao = new Solicitacao();
            CarregaTipoAlimento();
            return View(solicitacao);
        }

        [HttpPost]
        public IActionResult Create(Solicitacao solicitacao)
        {
            if (ModelState.IsValid)
            {
                _contexto.Solicitacao.Add(solicitacao);
                _contexto.SaveChanges();

                return RedirectToAction("index");
            }

            CarregaTipoAlimento();
            return View(solicitacao);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var solicitacao = _contexto.Solicitacao.Find(Id);

            CarregaTipoAlimento();
            return View(solicitacao);
        }

        [HttpPost]
        public IActionResult Edit(Solicitacao solicitacao)
        {
            if (ModelState.IsValid)
            {
                _contexto.Solicitacao.Update(solicitacao);
                _contexto.SaveChanges();
                return RedirectToAction("index");
            } else
            {
                CarregaTipoAlimento();
                return View(solicitacao);
            }

            
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var solicitacao = _contexto.Solicitacao.Find(Id);
            CarregaTipoAlimento();
            return View(solicitacao);
        }

        [HttpPost]
        public IActionResult Delete(Solicitacao _solicitacao)
        {
            var solicitacao = _contexto.Solicitacao.Find(_solicitacao.Id);

            if (solicitacao != null)
            {
                _contexto.Solicitacao.Remove(solicitacao);
                _contexto.SaveChanges();
                return RedirectToAction("index");
            }

            return View(solicitacao);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var solicitacao = _contexto.Solicitacao.Find(Id);
            CarregaTipoAlimento();
            return View(solicitacao);
        }

        public void CarregaTipoAlimento()
        {
            var ItensTipoAlimento = new List<SelectListItem>
            {
                new SelectListItem{Value = "1", Text = "Perecíveis" },
                new SelectListItem { Value = "2", Text = "Não Perecíveis" }
            };

            ViewBag.TiposAlimento = ItensTipoAlimento;
        }

    }
}