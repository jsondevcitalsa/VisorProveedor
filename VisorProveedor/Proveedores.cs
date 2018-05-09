using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;


namespace VisorProveedor
{
    public partial class Proveedores : MetroFramework.Forms.MetroForm
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVendor.Text.Trim() == "")
                {
                    MessageBox.Show("Seleccione El Proveedor");
                }
                else { 
                    System.Data.DataTable dtVendor = new System.Data.DataTable();
                    Metodos.Metodo mt = new Metodos.Metodo();
                    dtVendor = mt.Datos(txtVendor.Text);
                    dtgVerdatos.DataSource = dtVendor;
                     }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void txtVendor_Click(object sender, EventArgs e)
        {
            
            dtgVerdatos.DataSource = null;
            frmBuscar frm = new frmBuscar();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                txtVendor.Text = frm.VendorID;
            }
        }
        public void ExportarDataGridViewExcel(DataGridView dtgVerdatos)
        {
            try
            {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            fichero.FileName = "Archivo Exportado";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < dtgVerdatos.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dtgVerdatos.Columns.Count; j++)
                    {
                        if ((dtgVerdatos.Rows[i].Cells[j].Value == null) == false)
                        {
                        hoja_trabajo.Cells[i + 1, j + 1] = dtgVerdatos.Rows[i].Cells[j].Value.ToString();
                         }
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
                MessageBox.Show("Excel Creado Correctamente");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Exportar Excel : " +ex.ToString());
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dtgVerdatos);
        }

      
    }
}
