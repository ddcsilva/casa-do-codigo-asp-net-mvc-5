using Projeto.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Projeto.Controllers
{

    /// <summary>
    /// 1. Toda classe Controller deve ter seu nome finalizado com "Controller"
    /// 2. As actions devem ser public
    /// 3. As actions não podem ser static
    /// 4. As actions não podem ser sobrecarregadas com parâmetros, apenas com Attributes
    /// </summary>

    public class CategoriasController : Controller
    {
        private static IList<Categoria> listaCategorias = new List<Categoria>()
        {
            new Categoria()
            {
                CategoriaId = 1,
                Nome = "Notebooks"
            },
            new Categoria()
            {
                CategoriaId = 2,
                Nome = "Monitores"
            },
            new Categoria()
            {
                CategoriaId = 3,
                Nome = "Impressoras"
            },
            new Categoria()
            {
                CategoriaId = 4,
                Nome = "Mouses"
            },
            new Categoria()
            {
                CategoriaId = 5,
                Nome = "Desktops"
            }
        };

        // GET: Categorias
        public ActionResult Index()
        {
            return View(listaCategorias);
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            listaCategorias.Add(categoria);
            categoria.CategoriaId = listaCategorias.Select(c => c.CategoriaId).Max() + 1;

            return RedirectToAction("Index");
        }

        // GET: Edit
        public ActionResult Edit(long id)
        {
            return View(listaCategorias.Where(c => c.CategoriaId == id).First());
        }
    }
}