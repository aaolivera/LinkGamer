﻿using System.ServiceModel;
using Dominio.Comandos;

namespace Servicios
{
    [ServiceContract(Namespace = "http://LinkGamer.com.ar")]
    public interface IServicioComandos
    {
        [OperationContract]
        Resultado Ejecutar(Comando comando);
    }
}
