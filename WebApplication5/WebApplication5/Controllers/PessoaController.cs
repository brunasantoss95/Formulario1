using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Pessoa()
        {
            var pessoa = new Pessoa //o new é uma instanciação
                                    //da classe para criar o objeto
            {
                id = 01,
                nomepessoa = "Bruna",
                email = "bruna@liberato.com",
                vlr_renda = 2000
            };
            return View(pessoa);
        }
        [HttpPost] //-->salva tratado
        public IActionResult ListaPessoa(int id, string nomepessoa,
            string email, double vlr_renda)
        {

            ViewData["id"] = id;
            ViewData["nomepessoa"] = nomepessoa;
            ViewData["email"] = email;
            ViewData["vlr_renda"] = vlr_renda;


            return View();

        }
    }
}
