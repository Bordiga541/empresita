using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace empresita
{
    internal class Datos
    {
        public DataTable GetTabla(string sql)
        {
            DataTable tabla = new DataTable();
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(sql, "Data Source=Empresita.db");
            adaptador.Fill(tabla);
            return tabla;
        }
    }
}
