using System.Web.Mvc;
using Dominio.Consultas;
using Servicios;

namespace LinkGamer.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IServicioRepositorio servcio):base(servcio)
        {
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            servicio.ListarUsuarios();

            return View();
        }

    }
}
