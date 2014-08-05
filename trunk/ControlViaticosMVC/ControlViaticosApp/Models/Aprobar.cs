﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlViaticosApp.Models
{
    public class Aprobar
    {
        public int CodigoSolicitud { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public Empleado empleado { get; set; }
        public Ubigeo ubigeoOrigen { get; set; }
        public Ubigeo ubigeoDestino { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaRetorno { get; set; }
        public String SustentoViaje { get; set; }
        public Double TotalSolicitado { get; set; }
        public String FlagAprobado { get; set; }
        public DateTime FeAprobado { get; set; }
        public int CodigoEmpleadoAprueba { get; set; }
    }
}