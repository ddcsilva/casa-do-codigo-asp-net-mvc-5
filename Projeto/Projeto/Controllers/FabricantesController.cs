using Projeto.Contexts;
using Projeto.Models;
using System.Linq;
using System.Web.Mvc;

namespace Projeto.Controllers
{
    public class FabricantesController : Controller
    {
        private Contexto contexto = new Contexto();

        // GET: Fabricantes
        public ActionResult Index()
        {
            return View(contexto.Fabricantes.OrderBy(f => f.Nome));
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Fabricante fabricante)
        {
            contexto.Fabricantes.Add(fabricante);
            contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}