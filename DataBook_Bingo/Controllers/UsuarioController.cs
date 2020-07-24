using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Linq;
using DataBook_Bingo.Models;
using Microsoft.AspNetCore.Mvc;
using DataBook_Bingo.ViewModel;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using DataBook_Bingo.Utils;

namespace DataBook_Bingo.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DataBook_BingoContext _Context; //Art Context

        public UsuarioController(DataBook_BingoContext _context)
        {
            _Context = _context;
        }//construtor

        public ActionResult Cadastrar() //action da View Cadastrar
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CadastroViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (_Context.Usuarios.Count(u => u.EmailUsuario == model.Email) > 0)
            { //se na tabela usuarios conter mais que zero registros semelhantes a viewmodel.Login
                ModelState.AddModelError("Login", "ja está em uso!!!");
                return View(model);
            }

            Usuarios usuario = new Usuarios //instancia de obj
            {
                EmailUsuario = model.Email,
                SenhaUsuario = Hash.GerarHash(model.Senha, model.Email)// antes: viewmodel.Senha
            };

            _Context.Usuarios.Add(usuario); //obj context executa metodo user.
            _Context.SaveChanges(); //salvar comando.

            return RedirectToAction("Login", "Usuario");
        }

        public ActionResult Login() //parametro de retorno caso as pages não possui autorização
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Shinobis");
            }

            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }//verifica se existe algum erro de carregamento. se sim retorna a pagina anterior

            var usuario = _Context.Usuarios.FirstOrDefault(u => u.EmailUsuario == model.Email);
            //busca o login no bd e o joga na variavel usuario

            if (usuario == null) //se o usuario não receber nada.
            {
                ModelState.AddModelError("Login", "Login Inválido");
                return View(model);
            };

            if (usuario.SenhaUsuario != Hash.GerarHash(model.Senha, model.Email))
            {
                ModelState.AddModelError("Senha", "Senha Incorreta");
                return View(model);
            };//verifica se a senha corresponde a var usuario

            LoginClaim(usuario);

            return RedirectToAction("Index", "Shinobi");
        }

        private async void LoginClaim(Usuarios usuario)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, usuario.EmailUsuario),
                new Claim(ClaimTypes.Role, "Usuario_Comum")
            };

            var identidadeDeUsuario = new ClaimsIdentity(claims, "Login");
            ClaimsPrincipal claimPrincipal = new ClaimsPrincipal(identidadeDeUsuario);

            var propriedadesDeAutenticacao = new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTime.Now.ToLocalTime().AddHours(2),
                IsPersistent = true
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, propriedadesDeAutenticacao);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
