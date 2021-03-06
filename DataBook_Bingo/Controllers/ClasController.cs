﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataBook_Bingo.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using DataBook_Bingo.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace DataBook_Bingo.Controllers
{
    public class ClasController : Controller
    {
        private readonly DataBook_BingoContext _context;

        public ClasController(DataBook_BingoContext context)
        {
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index(string buscaAldeia = null)
        {
            var totalAlerta2 = _context.Clas.Count();
            ViewBag.TotalAldeiaAlerta = totalAlerta2;

            ViewBag.TotalAldeia = totalAlerta2;

            if ((buscaAldeia != null))
            {
                var totalAlerta = _context.Aldeia.Count();
                ViewBag.TotalAldeiaAlerta = totalAlerta;

                var total = _context.Clas.Where(a => a.NomeClas.Contains(buscaAldeia)).Count();
                ViewBag.TotalAldeia = total;

                var retorno = _context.Clas.Where(a => a.NomeClas.Contains(buscaAldeia));
                return View(await retorno.ToListAsync());
            }
            var Clas = _context.Clas.OrderByDescending(a => a.IdClas);
            return View(await Clas.ToListAsync());
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClasViewModel model, IList<IFormFile> file)
        {
            if(file.Count > 0)
            {
                IFormFile imgCla = file.FirstOrDefault();

                if (imgCla != null || imgCla.ContentType.ToLower().StartsWith("image/"))
                {
                    MemoryStream ms = new MemoryStream();
                    imgCla.OpenReadStream().CopyTo(ms);
                    model.ImageClas = ms.ToArray();
                }
            }         

            Clas clas = new Clas
            {
                NomeClas = model.NomeClas,
                ImageClas = model.ImageClas
            };

            if (clas != null)
            {
                _context.Add(clas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(clas);
        }
 
        private bool ClasExists(int id)
        {
            return _context.Clas.Any(e => e.IdClas == id);
        }
    }
}
