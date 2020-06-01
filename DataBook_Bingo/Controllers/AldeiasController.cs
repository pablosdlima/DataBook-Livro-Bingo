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

namespace DataBook_Bingo.Controllers
{
    public class AldeiasController : Controller
    {
        private readonly DataBook_BingoContext _context;

        public AldeiasController(DataBook_BingoContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            return View(await _context.Aldeia.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aldeia = await _context.Aldeia
                .FirstOrDefaultAsync(m => m.IdAldeia == id);
            if (aldeia == null)
            {
                return NotFound();
            }

            return View(aldeia);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAldeia,NomeAldeia,PaisAldeia")] Aldeia aldeia, IList<IFormFile> file)
        {
            IFormFile img = file.FirstOrDefault();
            if (img != null || img.ContentType.ToLower().StartsWith("image/"))
            {
                MemoryStream ms = new MemoryStream();
                img.OpenReadStream().CopyTo(ms);
                aldeia.ImgAldeia = ms.ToArray();
                if (aldeia.ImgAldeia != null)
                {
                     _context.Add(aldeia);
                     await _context.SaveChangesAsync();
                     return RedirectToAction(nameof(Index));
                }      
            }         
            return View(aldeia);
        }
        private bool AldeiaExists(int id)
        {
            return _context.Aldeia.Any(e => e.IdAldeia == id);
        }
    }
}
