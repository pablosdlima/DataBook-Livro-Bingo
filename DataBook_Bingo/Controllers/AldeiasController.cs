using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataBook_Bingo.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.WebEncoders.Testing;
using SQLitePCL;
using DataBook_Bingo.ViewModel;

namespace DataBook_Bingo.Controllers
{
    public class AldeiasController : Controller
    {
        private readonly DataBook_BingoContext _context;

        public AldeiasController(DataBook_BingoContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string buscaAldeia = null)
        {
            var totalAlerta2 = _context.Aldeia.Count();
            ViewBag.TotalAldeiaAlerta = totalAlerta2;

            ViewBag.TotalAldeia = totalAlerta2;

            if ((buscaAldeia != null))
            {
                var totalAlerta = _context.Aldeia.Count();
                ViewBag.TotalAldeiaAlerta = totalAlerta;

                var total = _context.Aldeia.Where(a => a.NomeAldeia.Contains(buscaAldeia)).Count();
                ViewBag.TotalAldeia = total;

                var retorno = _context.Aldeia.Where(a => a.NomeAldeia.Contains(buscaAldeia));
                return View(await retorno.ToListAsync());
            }

            var Aldeia = _context.Aldeia.OrderByDescending(a => a.IdAldeia);
            return View(await Aldeia.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AldeiaViewModel model, IList<IFormFile> file)
        {
            IFormFile img = file.FirstOrDefault();
            if (img != null || img.ContentType.ToLower().StartsWith("image/"))
            {
                MemoryStream ms = new MemoryStream();
                img.OpenReadStream().CopyTo(ms);
                model.ImgAldeia = ms.ToArray(); 
            }

            Aldeia aldeia = new Aldeia
            {
                NomeAldeia = model.NomeAldeia,
                ImgAldeia = model.ImgAldeia,
                PaisAldeia = model.PaisAldeia
            };
            if (aldeia != null)
            {
                 _context.Add(aldeia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }             
            return View(model);
        }
        private bool AldeiaExists(int id)
        {
            return _context.Aldeia.Any(e => e.IdAldeia == id);
        }
    }
}
