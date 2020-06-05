using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataBook_Bingo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DataBook_Bingo.Controllers
{
    public class ShinobiController : Controller
    {
        private readonly DataBook_BingoContext _Context; //Art Context

        public ShinobiController(DataBook_BingoContext _context)
        {
            _Context = _context;
        }//construtor

        public async Task<IActionResult> Index()
        {
            var _contextShinobi = _Context.Shinobi.Include(s => s.Aldeia).Include(q => q.Clas); //variavel contem caracteristicas da tabela Shinobi com relação(Include) a Aldeia
            return View(await _contextShinobi.ToListAsync()); //retornar...
        }

        public IActionResult Create()
        {
            ViewData["Aldeia_Id"] = new SelectList(_Context.Aldeia, "IdAldeia", "NomeAldeia"); //retorno do relacionamento
            ViewData["Cla_Id"] = new SelectList(_Context.Clas, "IdClas", "NomeClas");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdShinobi,Aldeia_Id,Cla_Id,NomeShinobi,ImagemShinobi,Especialidade,Renegado,Vivo,Elemento,Graduacao,Membro,Nivel")] Shinobi shinobi, IList<IFormFile> file)
        {
            IFormFile imgShinobi = file.FirstOrDefault();
            if (imgShinobi != null || imgShinobi.ContentType.ToLower().StartsWith("image/"))
            {
                MemoryStream ms = new MemoryStream();
                imgShinobi.OpenReadStream().CopyTo(ms);
                shinobi.ImagemShinobi = ms.ToArray();
                if (shinobi.ImagemShinobi != null)
                {
                    _Context.Add(shinobi); //Context recebe o obj
                    await _Context.SaveChangesAsync(); //context é salvo no sql
                    return RedirectToAction(nameof(Index)); //retorno de pagina
                }
            }
            ViewData["Aldeia_Id"] = new SelectList(_Context.Aldeia, "IdAldeia", "NomeAldeia", shinobi.Aldeia_Id); //com ViewData retorna um select no html que dára as opções contidas em NomeAldeia com valores IdAldeia para o atr Id_Aldeia
            ViewData["Cla_Id"] = new SelectList(_Context.Clas, "IdClas", "NomeClas", shinobi.Cla_Id); //com ViewData retorna um select no html que dára as opções contidas em NomeAldeia com valores IdAldeia para o atr Id_Aldeia

            return View(shinobi);
        }
    }
}