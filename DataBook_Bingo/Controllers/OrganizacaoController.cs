using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataBook_Bingo.Models;
using DataBook_Bingo.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataBook_Bingo.Controllers
{
    public class OrganizacaoController : Controller
    {
        private readonly DataBook_BingoContext _context;

        public OrganizacaoController(DataBook_BingoContext context)
        {
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index(string buscaAldeia = null)
        {
            var totalAlerta2 = _context.Organizacao.Count();
            ViewBag.TotalAldeiaAlerta = totalAlerta2;

            ViewBag.TotalAldeia = totalAlerta2;

            if ((buscaAldeia != null))
            {
                var totalAlerta = _context.Organizacao.Count();
                ViewBag.TotalAldeiaAlerta = totalAlerta;

                var total = _context.Organizacao.Where(a => a.NomeOrganizacao.Contains(buscaAldeia)).Count();
                ViewBag.TotalAldeia = total;

                var retorno = _context.Organizacao.Where(a => a.NomeOrganizacao.Contains(buscaAldeia));
                return View(await retorno.ToListAsync());
            }
            var Organizacao = _context.Organizacao.OrderByDescending(a => a.IdOrganizacao);

            return View(await Organizacao.ToListAsync());
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(OrganizacaoViewModel model, IList<IFormFile> file)
        {
            if (file.Count > 0)
            {
                IFormFile imgOrganizacao = file.FirstOrDefault();

                if (imgOrganizacao != null || imgOrganizacao.ContentType.ToLower().StartsWith("image/"))
                {
                    MemoryStream ms = new MemoryStream();
                    imgOrganizacao.OpenReadStream().CopyTo(ms);
                    model.ImgOrganizacao = ms.ToArray();
                }
            }

            Organizacao organizacao = new Organizacao
            {
                NomeOrganizacao = model.NomeOrganizacao,
                ImgOrganizacao = model.ImgOrganizacao,
                Limite = model.Limite
            };

            if (organizacao != null)
            {
                _context.Add(organizacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(organizacao.ImgOrganizacao);
        }
        private bool OrganizacaoExists(int id)
        {
            return _context.Organizacao.Any(e => e.IdOrganizacao == id);
        }
    }
}
