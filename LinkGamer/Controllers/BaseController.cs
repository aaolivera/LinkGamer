﻿using System;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using LinkGamer.Filters;
using Servicios;

namespace LinkGamer.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly IServicioRepositorio servicio;

        protected BaseController(IServicioRepositorio servicio)
        {
            this.servicio = servicio;
        }


   
    }
}