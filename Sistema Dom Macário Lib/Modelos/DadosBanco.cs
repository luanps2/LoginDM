using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_Dom_Macário_Lib
{
    public class DadosBanco
    {
        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string DataBase { get; set; }
        public string conn { get; set; }
        public MySqlConnection mysql { get; set; }

    }
}
