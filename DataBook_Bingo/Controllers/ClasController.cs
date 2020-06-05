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

namespace DataBook_Bingo.Controllers
{
    public class ClasController : Controller
    {
        private readonly DataBook_BingoContext _context;

        public ClasController(DataBook_BingoContext context)
        {
            _context = context;
        }

        // GET: Clas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clas.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdClas,NomeClas")] Clas clas, IList<IFormFile> file)
        {
                IFormFile imgCla = file.FirstOrDefault();
                if (imgCla != null || imgCla.ContentType.ToLower().StartsWith("image/"))
                {
                    MemoryStream ms = new MemoryStream();
                    imgCla.OpenReadStream().CopyTo(ms);
                    clas.ImageClas = ms.ToArray();

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
