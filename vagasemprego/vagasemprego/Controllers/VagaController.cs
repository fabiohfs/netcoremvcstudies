using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vagasemprego.Context;
using vagasemprego.Models;

namespace vagasemprego.Controllers
{
    public class VagaController : Controller
    {
        private VagaDbContext _context = null;

        public VagaController(VagaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<VagaModel> vagas = _context.Vagas.ToList();
            return View(vagas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind(include: "Titulo, Requisitos, Local, Salario")] VagaModel vagaModel)
        {
            if (ModelState.IsValid)
            {
                _context.Vagas.Add(vagaModel);
                _context.SaveChanges();

                TempData["VagaCreate"] = "Vaga Cadastrada com sucesso!";
            }

            return RedirectToAction("Index");
        }
    }
}
