using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Detalhe()
        {
            Aluno alunos = new Aluno()
            {
                AlunoId = 200,
                Nome = "Gonçalo",
                Apelido = "Mourato",
                Telefone = "930571912"
            };

            ViewBag.Nome = alunos.Nome;
            ViewData["Apelido"] = alunos.Apelido;
            return View(alunos);
        }

        [HttpPost]
        public IActionResult GuardarAluno(Aluno modelo)
        {
            return View(modelo);
        }

    }
}
