using Projeto.Contexts;
using Projeto.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
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

        // GET: Fabricantes/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Fabricante fabricante = contexto.Fabricantes.Find(id);

            if (fabricante == null)
            {
                return HttpNotFound();
            }

            return View(fabricante);
        }

        // POST: Fabricantes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Fabricante fabricante)
        {
            if (ModelState.IsValid)
            {
                contexto.Entry(fabricante).State = EntityState.Modified;
                contexto.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(fabricante);
        }
    }
}