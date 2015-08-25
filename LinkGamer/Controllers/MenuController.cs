using System.Web.Mvc;
using System.Web.Security;
using Dominio.Recursos;
using LinkGamer.Models;
using Servicios;
using WebMatrix.WebData;

namespace LinkGamer.Controllers
{
    public class MenuController : BaseController
    {
        public MenuController(IServicioRepositorio servicio) : base(servicio)
        {
            ViewBag.Title = Textos.Menu_Titulo;
            ViewBag.Message = Textos.Menu_Mensaje;
        }

        [AllowAnonymous]
        public ActionResult Menu()
        {
            ViewBag.Title = Textos.Menu_Titulo;
            ViewBag.Message = Textos.Menu_Mensaje;
            return PartialView("_Menu");
        }
        
    }
}
