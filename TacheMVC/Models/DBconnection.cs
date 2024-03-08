using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TacheMVC.Models
{
    public class DBconnection
    {
        public static NpgsqlConnection connectionString = new NpgsqlConnection
             (ConfigurationManager.ConnectionStrings["DBConnexion"].ConnectionString);


        public static bool Logutilisateur(Utilisateur utilisateur)
        {
            var req = $"SELECT * FROM public.\"Utilisateur\" WHERE name = '{utilisateur.Name}' AND \"password\"='{utilisateur.Password}';";
            var hasUser = false;

            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                var reader = cmd.ExecuteReader();
                hasUser = reader.HasRows;
                connectionString.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

            return hasUser;
        }
    }
}