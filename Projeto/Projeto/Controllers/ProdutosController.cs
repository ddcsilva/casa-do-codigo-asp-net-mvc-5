using Projeto.Contexts;
using Projeto.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Projeto.Controllers
{
    public class ProdutosController : Controller
    {
        private Contexto contexto = new Contexto();

        // GET: Produtos
        public ActionResult Index()
        {
            var produtos = contexto.Produtos
                .Include(c => c.Categoria)
                .Include(f => f.Fabricante)
                .OrderBy(p => p.Nome);

            return View(produtos);
        }

        // GET: Produtos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Produtos/Create
        public ActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(contexto.Categorias.OrderBy(c => c.Nome), "CategoriaId", "Nome");
            ViewBag.FabricanteId = new SelectList(contexto.Fabricantes.OrderBy(c => c.Nome), "FabricanteId", "Nome");
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            try
            {
                contexto.Produtos.Add(produto);
                contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produtos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produtos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produtos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
