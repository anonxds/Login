using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace InventarioLaboratorio
{
    class Sql
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public void filtro(string lab, string tipo, DataGridView dgvReactivo)
        {
            Sql s = new Sql();
          string  query = string.Format("Select Id, Nombre, Tipo, Capacidad, Estado, Laboratorio, Observaciones from Material where Tipo = '{0}' and  Laboratorio = '{1}' ", lab, tipo);
            s.dgrid(dgvReactivo, query);

        }
        public void setcon()
        {
            con = new SqlConnection("Server=tcp:karinaitt.database.windows.net,1433;Initial Catalog=Laboratorio;Persist Security Info=False;User ID=karina;Password=Jona6812;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
      
        private SqlDataAdapter db;

        public void Exe(string query)
        {
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void dgrid(DataGridView dg, string query)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            db = new SqlDataAdapter(query, con);
            ds.Reset();
            db.Fill(ds);
            dt = ds.Tables[0];
            dg.DataSource = dt;
            con.Close();
        }
    }
}
