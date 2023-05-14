using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Типа_кликер__v1._0
{
    internal class LDB
    {
        MySqlConnection Lconnection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=loginandreg");

        public void LOpenC()
        {
            if (Lconnection.State == System.Data.ConnectionState.Closed)
            {
                Lconnection.Open();
            }
        }
        public void LCloseC()
        {
            if (Lconnection.State == System.Data.ConnectionState.Open)
            {
                Lconnection.Close();
            }
        }
        public MySqlConnection getLconnection()
        {
            return Lconnection;
        }
    }
}
