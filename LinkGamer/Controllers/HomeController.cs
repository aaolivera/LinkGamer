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
        public ActionResult Index(string filtro = "", int pagina = 1, string ordenarPor = "Id", DirOrden dirOrden = DirOrden.Asc)
        {
            servicio.ListarUsuarios();
            ListQuery(filtro, pagina, ordenarPor, dirOrden);
            return View();
        }

        private void ListQuery(string filtro, int pagina, string ordenarPor, DirOrden dirOrden)
        {
            var paginacion = new Paginacion(ordenarPor, dirOrden, pagina, 10);
            //ViewBag.Productos = _servicio.ListarProductos(filtro, paginacion);
        }
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
