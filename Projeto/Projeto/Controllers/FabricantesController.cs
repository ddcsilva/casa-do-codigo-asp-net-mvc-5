using Projeto.Contexts;
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
    }
}