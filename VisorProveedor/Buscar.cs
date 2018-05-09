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
    public partial class frmBuscar : MetroFramework.Forms.MetroForm
    {
        public frmBuscar()
        {
            InitializeComponent();
        }
        public string VendorID;

        private void Buscar_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            try
            {
                string VendorID1 = "";
                int VendorNum = 0;
                string VendorNom = "";
                if (txtID.Text.Trim() == "")
                {

                    if (txtNum.Text.Trim() == "")
                    {

                        if (txtNom.Text.Trim() == "")
                        {
                            Metodos.Metodo mt = new Metodos.Metodo();
                            mt.ConNAda();
                            gdVerBus.DataSource = mt.ConNAda();

                        }
                        else
                        {
                            VendorNom = txtNom.Text;
                            Metodos.Metodo mt = new Metodos.Metodo();
                            mt.ConNom(VendorNom);
                            gdVerBus.DataSource = mt.ConNom(VendorNom);

                        }
                    }
                    else
                    {
                        VendorNum = Convert.ToInt32(txtNum.Text);
                        Metodos.Metodo mt = new Metodos.Metodo();
                        mt.ConNum(VendorNum);

                        gdVerBus.DataSource = mt.ConNum(VendorNum);

                    }
                }
                else
                {
                    VendorID1 = txtID.Text;
                    Metodos.Metodo mt = new Metodos.Metodo();
                    mt.Conid(VendorID1);

                    gdVerBus.DataSource = mt.Conid(VendorID1);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        public void gdVerBus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              
                mtok.PerformClick();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mtok_Click(object sender, EventArgs e)
        {
            VendorID = gdVerBus.CurrentRow.Cells["VendorID"].Value.ToString();
        
        }

        private void gdVerBus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
