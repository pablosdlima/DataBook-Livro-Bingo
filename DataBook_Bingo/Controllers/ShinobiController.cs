using System;
using System.Collections.Generic;
using System.IO;
using X.PagedList;
using System.Linq;
using System.Threading.Tasks;
using DataBook_Bingo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataBook_Bingo.ViewModel;
using Microsoft.AspNetCore.Authorization;

namespace DataBook_Bingo.Controllers
{
    public class ShinobiController : Controller
    {
        private readonly DataBook_BingoContext _Context; //Art Context

        public ShinobiController(DataBook_BingoContext _context)
        {
            _Context = _context;
        }//construtor

        [Authorize]
        public async Task<IActionResult> Index(string buscaAldeia = null)
        {
            var _contextShinobi = _Context.Shinobi.Include(s => s.Aldeia).Include(q => q.Clas).Include(p => p.Organizacao); //variavel contem caracteristicas da tabela Shinobi com relação(Include) a Aldeia
            var totalAlerta2 = _contextShinobi.Count();
            ViewBag.TotalAldeiaAlerta = totalAlerta2;
            ViewBag.TotalAldeia = totalAlerta2;

            if ((buscaAldeia != null))
            {
                var totalAlerta = _contextShinobi.Count();
                ViewBag.TotalAldeiaAlerta = totalAlerta;

                var total = _contextShinobi.Where(a => a.NomeShinobi.Contains(buscaAldeia)).Count();
                ViewBag.TotalAldeia = total;

                var retorno = _contextShinobi.Where(a => a.NomeShinobi.Contains(buscaAldeia));
                return View(await retorno.ToListAsync());
            }

            var Shinobi = _Context.Shinobi.OrderByDescending(a => a.IdShinobi);
            return View(await Shinobi.ToListAsync()); //retornar...
        }

        public async Task<IActionResult> DataBook(int? pagina)
        {
            int itemPagina = 2;
            int numeroPagina = (pagina ?? 1);

            var _contextShinobi = _Context.Shinobi.OrderBy(i => i.NomeShinobi).Include(s => s.Aldeia).Include(s => s.Clas).Include(p => p.Organizacao); // id ordenado com junções de tabela em paginas de lista.
            return View(await _contextShinobi.ToPagedListAsync(numeroPagina, itemPagina));
        }

        [Authorize]
        public async Task<IActionResult> Bingo()
        {
        
            var Shinobi = _Context.Shinobi.OrderByDescending(a => a.IdShinobi).Include(s => s.Aldeia).Include(s => s.Clas).Include(p => p.Organizacao);
            return View(await Shinobi.ToListAsync()); //retornar...
        }

        [Authorize]
        public IActionResult Create()
        {
            ViewData["Aldeia_Id"] = new SelectList(_Context.Aldeia, "IdAldeia", "NomeAldeia"); //retorno do relacionamento
            ViewData["Cla_Id"] = new SelectList(_Context.Clas, "IdClas", "NomeClas");
            ViewData["Organizacao_Id"] = new SelectList(_Context.Organizacao, "IdOrganizacao", "NomeOrganizacao");
            return View();
        }

        [HttpPost] 
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ShinobiViewModel model, IList<IFormFile> file)
        {
            IFormFile imgShinobi = file.FirstOrDefault();


            if (imgShinobi != null || imgShinobi.ContentType.ToLower().StartsWith("image/"))
            {
                MemoryStream ms = new MemoryStream();
                imgShinobi.OpenReadStream().CopyTo(ms);
                model.ImagemShinobi = ms.ToArray();

                ViewData["Aldeia_Id"] = new SelectList(_Context.Aldeia, "IdAldeia", "NomeAldeia", model.Aldeia_Id); //com ViewData retorna um select no html que dára as opções contidas em NomeAldeia com valores IdAldeia para o atr Id_Aldeia
                ViewData["Cla_Id"] = new SelectList(_Context.Clas, "IdClas", "NomeClas", model.Cla_Id); //com ViewData retorna um select no html que dára as opções contidas em NomeAldeia com valores IdAldeia para o atr Id_Cla
                ViewData["Organizacao_Id"] = new SelectList(_Context.Organizacao, "IdOrganizacao", "NomeOrganizacao", model.Organizacao_Id); //com ViewData retorna um select no html que dára as opções contidas em NomeAldeia com valores IdAldeia para o atr Id_Aldeia

                Shinobi shinobi = new Shinobi
                {
                    Aldeia_Id = model.Aldeia_Id,
                    Cla_Id = model.Cla_Id,
                    Organizacao_Id = model.Organizacao_Id,
                    NomeShinobi = model.NomeShinobi,
                    ImagemShinobi = model.ImagemShinobi,
                    Especialidade = model.Especialidade,
                    Renegado = model.Renegado,
                    Vivo = model.Vivo,
                    Elemento = model.Elemento,
                    Graduacao = model.Graduacao
                };

                if (shinobi != null)
                {
                    _Context.Add(shinobi); //Context recebe o obj
                    await _Context.SaveChangesAsync(); //context é salvo no sql
                    return RedirectToAction(nameof(Index)); //retorno de pagina
                }
            }
            return View(model);
        }
    }
}