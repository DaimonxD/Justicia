using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace Justicia
{
    class PROFUGOS
    {
        string cadena;
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;


        public PROFUGOS()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=JUSTICIA.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Profugos";

            adaptador = new OleDbDataAdapter(comando);

            tabla = new DataTable();

            adaptador.Fill(tabla);

            DataColumn[] vec = new DataColumn[1];
            vec[0] = tabla.Columns["nombre"];
            tabla.PrimaryKey = vec;
        }

        public DataTable GetData()
        {
            return tabla;
        }


    }
}
