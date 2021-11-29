using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Proyecto_Final
{
    class BaseDeDatos
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost;database=bmd_practica;Uid=root;pwd=2015030063");
            conectar.Open();
            return conectar;
        }
    }
}
