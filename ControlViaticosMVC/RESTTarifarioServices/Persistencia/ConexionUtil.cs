﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTTarifarioServices.Persistencia
{
    public class ConexionUtil
    {
        public static string Cadena
        {
            get
            {
                return @"Data Source=MAVERICK-PC\SQLEXPRESS;Initial Catalog=CONTROLVIATICOS;Integrated Security=True";
                //return "Data Source=(local);Initial Catalog=CONTROLVIATICOS;Integrated Security=SSPI;";
            }
        }
    }
}