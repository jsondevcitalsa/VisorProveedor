using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace VisorProveedor.Conexion
{
    class Cone
    {
        public  SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Cone()
        {
            try
            {
            cn = new SqlConnection("Data Source=galgadot;Initial Catalog=Epicor10Test;Persist Security Info=True;User ID=sa;Password=Susana7*");
                cn.Open();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Conectado"+ex.ToString());
            }

        }
    }
}
