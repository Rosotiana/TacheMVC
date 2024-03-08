using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TacheMVC.Models
{
    public class DBconnection
    {
        public static NpgsqlConnection connectionString = new NpgsqlConnection
             (ConfigurationManager.ConnectionStrings["DBConnexion"].ConnectionString);
    }
}