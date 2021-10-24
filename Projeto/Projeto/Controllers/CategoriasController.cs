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
        // GET: Categorias
        public ActionResult Index()
        {
            return View();
        }
    }
}