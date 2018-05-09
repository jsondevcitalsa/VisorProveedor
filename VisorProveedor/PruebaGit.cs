using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisorProveedor
{
    public partial class PruebaGit : MetroFramework.Forms.MetroForm
    {
        public PruebaGit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                    System.Data.DataTable dtVendor = new System.Data.DataTable();
                    Metodos.Metodo mt = new Metodos.Metodo();
       
                    dataGridView1.DataSource = dtVendor;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
