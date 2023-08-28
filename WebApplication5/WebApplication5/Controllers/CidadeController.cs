using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class CidadeController : Controller
    {
        public IActionResult Index()
        {
            var cidade = new Cidade //o new é uma instanciação
                                      //da classe para criar o objeto
            {
                id = 01,
                nomecidade = "Novo Hamburgo",
                uf = "RS",
                pais = "Brasil"
            };
            return View(cidade);
        }
        [HttpPost] //-->salva tratado
        public IActionResult ListaCidade(int id, string nomecidade, 
            string uf, string pais)
        {

            ViewData["id"] = id;
            ViewData["nomecidade"] = nomecidade;
            ViewData["uf"] = uf;
            ViewData["pais"] = pais;


            return View();

        }
    }
}
