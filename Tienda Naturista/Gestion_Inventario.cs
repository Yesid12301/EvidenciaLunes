using CapaNegocios;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tienda_Naturista
{
    public partial class Gestion_Inventario : Form
    {
        public Gestion_Inventario()
        {
            InitializeComponent();
        }
        CN_inventario oCN_inventario = new CN_inventario();
        CN_inventario oCN_inventario2 = new CN_inventario();
        DataTable tablaInventario = new DataTable();
        private void Gestion_Inventario_Load(object sender, EventArgs e)
        {
            tablaInventario = oCN_inventario.BUSCARINVENTARIOS();
            dtgInventario.DataSource = tablaInventario;
            buscarInventario();
            dtgInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void buscarInventario()
        {
            CbxProductoInventario.DataSource = oCN_inventario2.BUSCARINVENTARIOS();
            CbxProductoInventario.ValueMember = "Codigo";
            CbxProductoInventario.DisplayMember = "Descripción";
        }

        private void BtnConsultarInventario_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(CbxProductoInventario.SelectedValue.ToString());
            dtgInventario.DataSource = oCN_inventario.BUSCARINVENTARIO(codigo);
        }

        private void BtnMostrarInventario_Click(object sender, EventArgs e)
        {
            dtgInventario.DataSource = oCN_inventario.BUSCARINVENTARIOS();
            buscarInventario();
        }

        private void btnExpoExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application exportar = new Microsoft.Office.Interop.Excel.Application();

            exportar.Application.Workbooks.Add(true);

            int Indicecolumna = 0;

            foreach (DataGridViewColumn columns in dtgInventario.Columns)
            {
                Indicecolumna++;
                exportar.Cells[1, Indicecolumna] = columns.Name;
            }
            int indicefila = 0;
            foreach (DataGridViewRow fila in dtgInventario.Rows)
            {
                indicefila++;
                Indicecolumna = 0;

                foreach (DataGridViewColumn columnas in dtgInventario.Columns)
                {
                    Indicecolumna++;
                    exportar.Cells[indicefila + 1, Indicecolumna] = fila.Cells[columnas.Name].Value;
                }
            }
            exportar.Visible = true;
        }
        private void btnExpoPDF_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(@"E:\Programacion\C#\PROYECTOS_MIOS\GRAFICA\Tienda\EvidenciaLunes\exportar\PdfInventario.pdf", FileMode.Create);
            {
                Document document = new Document();
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, fileStream);
                document.Open();

                PdfPTable Pdftable = new PdfPTable(dtgInventario.Columns.Count);

                foreach (DataGridViewColumn columns in dtgInventario.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(columns.HeaderText));
                    Pdftable.AddCell(cell);
                }
                if (dtgInventario.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dtgInventario.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            Pdftable.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }
                    MessageBox.Show("Se inserto correctamente :D");
                }
                else
                {
                    MessageBox.Show("Se inserto mal o no funciono algo");
                }
                document.Add(Pdftable);
                document.Close();
            }
        }
    }
}
