using Microsoft.AspNetCore.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class TarefaController : Controller
    {
        private static List<Tarefa> tarefas = new List<Tarefa>();

        public IActionResult Index()
        {
            return View(tarefas);
        }

        // Get
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Tarefa tarefa)
        {
            tarefa.Id = tarefas.Count + 1;
            tarefas.Add(tarefa);
            return RedirectToAction("Index");
        }

        public IActionResult Detalhes(int id)
        {
            Tarefa tarefa = tarefas.Find(t => t.Id == id);

            return View(tarefa);
        }

        public IActionResult Editar(int id)
        {
            Tarefa tarefa = tarefas.Find(t => t.Id == id);
            return View(tarefa);
        }

        [HttpPost]
        public IActionResult Editar(Tarefa tarefa)
        {
            Tarefa tarefaExistente = tarefas.Find(t => t.Id == tarefa.Id);
            tarefaExistente.Titulo = tarefa.Titulo;
            tarefaExistente.Concluida = tarefa.Concluida;
            tarefaExistente.DataInicio = tarefa.DataInicio;
            tarefaExistente.DataFim = tarefa.DataFim;
            return RedirectToAction("Index");
        }

        public IActionResult Deletar(int id)
        {
            Tarefa tarefa = tarefas.Find(t => t.Id == id);
            return View(tarefa);
        }

        [HttpPost]
        public IActionResult DeletarConfirmado(int id)
        {
            Tarefa tarefa = tarefas.Find(t => t.Id == id);
            tarefas.Remove(tarefa);
            return RedirectToAction("Index");
        }
    }
}
