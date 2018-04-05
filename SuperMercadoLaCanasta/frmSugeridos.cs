using Entidades.Sugeridos;
using Entidades.Usuarios;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Logica.Sugeridos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SuperMercadoLaCanasta
{
    public partial class frmSugeridos : Form
    {
        List<EClSugeridos> listaSugueridos = new List<EClSugeridos>();
        LClSugeridos lSugeridos;
        DataTable dt;

        public frmSugeridos(EClUsuarios user)
        {
            InitializeComponent();

            dt = new DataTable();

            //Centrar el Panel
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el Tamaño del Monitor
            Int32 alto = (desktopSize.Height - 380) / 2;
            Int32 altoTitulo = (desktopSize.Height - 560) / 2;
            Int32 ancho = (desktopSize.Width - 1000) / 2;
            tbcCrear.Location = new Point(ancho, alto);
            tbcCrearSugerido.Location = new Point(ancho, alto);
            tbcModificar.Location = new Point(ancho, alto);
            tbcVersugerido.Location = new Point(ancho, alto);
            lblTituloSugerido.Location = new Point(ancho, altoTitulo);

            this.ttMensaje.SetToolTip(this.txtCodigoBarras, "Ingrese un Codigo de Barras");
            this.ttMensaje.SetToolTip(this.nupCantidad, "Ingrese la Cantida de Pedido");
            this.ttMensaje.SetToolTip(this.cmbEmbalage, "Seleccione un Embalage");


        }

        private void frmSugeridos_Load(object sender, EventArgs e)
        {
            cmbAlmacen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmbalage.DropDownStyle = ComboBoxStyle.DropDownList;
            mtdCargarAlmacen();
            mtdCargarEmbalage();
            txtFecha.Text = DateTime.Now.ToString();

            this.ttMensaje.SetToolTip(this.cmbAlmacen, "Seleccione un Almacen");

            mtdCargarColumnas();
        }

        private void mtdCargarAlmacen()
        {
            cmbAlmacen.DisplayMember = "Text";
            cmbAlmacen.ValueMember = "Value";

            var items = new []
            {
                new { Text = "Seleccione", Value = "0" },
                new { Text = "Centro", Value = "CN1" },
                new { Text = "Iwoka", Value = "CN3" },
                new { Text = "Robledales", Value = "CN4" }
            };

            cmbAlmacen.DataSource = items;
        }

        /// <summary>
        /// Meotod para agregar columnas al grid
        /// </summary>
       private void mtdCargarColumnas()
        {
            dt = new DataTable();
            dt.Columns.Add("Código de barras");
            dt.Columns.Add("Descripción Producto");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Embalaje");
            dt.Columns.Add("Departamento");

            dgvSugerido.DataSource = dt; 
        }

        /// <summary>
        /// Metodo en donde se carga el combo box con los emlages
        /// </summary>
        private void mtdCargarEmbalage()
        {
            cmbEmbalage.DisplayMember = "Text";
            cmbEmbalage.ValueMember = "Value";

            var items = new[]
            {
                new { Text = "Seleccione", Value = "0" },
                new { Text = "Unidades", Value = "Unidades" },
                new { Text = "Cajas", Value = "Cajas" },
                new { Text = "Pacas", Value = "Pacas" }
            };

            cmbEmbalage.DataSource = items;
        }

        /// <summary>
        /// Boton para cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Dispose();
            this.Close();
        }

        /// <summary>
        /// Boton para minimizar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimizar_Click(object sender, EventArgs e)
            => this.WindowState = FormWindowState.Normal;

        /// <summary>
        /// Boton para maximizar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaximizar_Click(object sender, EventArgs e)
            => this.WindowState = FormWindowState.Maximized;

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nupCantidad.Value == 0)
                    MessageBox.Show("La Cantidad debe ser mayor a cero");
                else if (cmbEmbalage.SelectedValue.ToString() == "0")
                    MessageBox.Show("Seleccione un embalage");
                else
                {
                    lSugeridos = new LClSugeridos();

                    EClSugeridos sugerido = new EClSugeridos();
                    sugerido.almacen = cmbAlmacen.SelectedValue.ToString();
                    sugerido.cantidad = int.Parse(nupCantidad.Value.ToString());
                    sugerido.codigoBarras = txtCodigoBarras.Text;
                    sugerido.nombreDepartamento = txtDepartamento.Text;
                    sugerido.departamento = int.Parse(lblIdDepartamento.Text);
                    sugerido.descripcion = txtDescrip.Text;
                    sugerido.embalage = cmbEmbalage.SelectedValue.ToString();
                    sugerido.fecha = txtFecha.Text;

                    listaSugueridos.Add(sugerido);
                    dgvSugerido.DataSource = null;
                    listaSugueridos = listaSugueridos.OrderBy(s => s.nombreDepartamento).ToList();
                    dgvSugerido.DataSource = listaSugueridos;
                    //dgvSugerido.Sort(dgvSugerido.Columns["Departamento"], ListSortDirection.Descending);
                    mtdResaurarCampos();

                   // int resultado = lSugeridos.mtdInsertarSugerido(sugerido);

                    //if (resultado == 1)
                    //{
                        mtdResaurarCampos();
                        MessageBox.Show("Sugerido registrado exitósamente");
                        mtdVisualizarPedido(sugerido);
                    //}
                    //else
                        MessageBox.Show("Sugerido no registrado");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar sugerido: "+ex.Message);
            }
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (txtCodigoBarras.Text != "")
                    {
                        lSugeridos = new LClSugeridos(); 

                        EClSugeridos sugerido = lSugeridos.mtdListarProducto(txtCodigoBarras.Text).FirstOrDefault();

                        if (sugerido != null)
                        {
                            txtDepartamento.Text = sugerido.nombreDepartamento;
                            txtDescrip.Text = sugerido.descripcion;
                            lblIdDepartamento.Text = sugerido.departamento.ToString();

                            nupCantidad.Enabled = true;
                            cmbEmbalage.Enabled = true;
                            cmbAlmacen.Enabled = false;
                            btnEnviar.Enabled = true;
                        }
                        else
                            MessageBox.Show("Producto no encontrado");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al consultar codigo barras: " + ex.Message);
                }
            }
        }

        private void cmbAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAlmacen.SelectedValue.ToString() != "0")
            {
                txtCodigoBarras.Enabled = true;
                txtCodigoBarras.Focus();
            }
            else
                txtCodigoBarras.Enabled = false;
        }

        /// <summary>
        /// Boton para restaurar campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mtdResaurarCampos();
            cmbAlmacen.SelectedValue = "0";
            cmbAlmacen.Enabled = true;
            txtCodigoBarras.Enabled = false;
            dgvSugerido.DataSource = null;
        }

        /// <summary>
        /// Metodo para restaurar valores en ceros
        /// </summary>
        private void mtdResaurarCampos()
        {
            txtDepartamento.Text = "";
            txtDescrip.Text = "";
            txtCodigoBarras.Text = "";
            nupCantidad.Value = 0;
            nupCantidad.Enabled = false;
            cmbEmbalage.SelectedValue = "0";
            cmbEmbalage.Enabled = false;
            txtFecha.Text = DateTime.Now.ToString();
            btnEnviar.Enabled = false;
        }

        private void mtdVisualizarPedido(EClSugeridos sugerido)
        {
            DataRow row = dt.NewRow();
            row["Código de barras"] = sugerido.codigoBarras;
            row["Descripción Producto"] = sugerido.descripcion;
            row["Cantidad"] = sugerido.cantidad;
            row["Embalaje"] = sugerido.embalage;
            row["Departamento"] = sugerido.nombreDepartamento;
            dt.Rows.Add(row);

            dgvSugerido.DataSource = dt;
            
        }

        /// <summary>
        /// Boton para Mostrar Sugerido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerSugerido_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = DateTime.Now.ToShortDateString().ToString().Replace("/", "-");

                Document doc = new Document(PageSize.LETTER);
                PdfWriter writer = PdfWriter.GetInstance(doc,
                                            new FileStream("C:/Users/LUCHO/Documents/XXX/Sugueridos"+fecha+".pdf", FileMode.Create));
                doc.AddTitle("Sugueridos");
                doc.Open();

                doc.Add(new Paragraph("Mis Sugueridos"));
                doc.Add(Chunk.NEWLINE);

                PdfPTable tblPrueba = new PdfPTable(5);
                tblPrueba.WidthPercentage = 100;

                // Configuramos el título de las columnas de la tabla
                PdfPCell codigoBarras = new PdfPCell(new Phrase("Código de Barras"));
                codigoBarras.BorderWidth = 0.45f;

                PdfPCell producto = new PdfPCell(new Phrase("Producto"));
                producto.BorderWidth = 0.45f;

                PdfPCell cantidad = new PdfPCell(new Phrase("Cantidad"));
                cantidad.BorderWidth = 0.45f;

                PdfPCell embalage = new PdfPCell(new Phrase("Embalage"));
                embalage.BorderWidth = 0.45f;

                PdfPCell departamento = new PdfPCell(new Phrase("Departamento"));
                departamento.BorderWidth = 0.45f;

                // Añadimos las celdas a la tabla
                tblPrueba.AddCell(producto);
                tblPrueba.AddCell(cantidad);
                tblPrueba.AddCell(embalage);
                tblPrueba.AddCell(departamento);
                tblPrueba.AddCell(codigoBarras);

                foreach (DataGridViewRow row in dgvSugerido.Rows)
                {
                    // Llenamos la tabla con información
                    codigoBarras = new PdfPCell(new Phrase(row.Cells[0].Value.ToString()));
                    codigoBarras.BorderWidth = 0.45f;

                    producto = new PdfPCell(new Phrase(row.Cells[1].Value.ToString()));
                    producto.BorderWidth = 0.45f;

                    cantidad = new PdfPCell(new Phrase(row.Cells[2].Value.ToString()));
                    cantidad.BorderWidth = 0.45f;

                    embalage = new PdfPCell(new Phrase(row.Cells[3].Value.ToString()));
                    embalage.BorderWidth = 0.45f;

                    departamento = new PdfPCell(new Phrase(row.Cells[4].Value.ToString()));
                    departamento.BorderWidth = 0.45f;

                    // Añadimos las celdas a la tabla
                    tblPrueba.AddCell(producto);
                    tblPrueba.AddCell(cantidad);
                    tblPrueba.AddCell(embalage);
                    tblPrueba.AddCell(departamento);
                    tblPrueba.AddCell(codigoBarras);
                }

                doc.Add(tblPrueba);
                doc.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al imprimir sugeridos: "+ex.Message);
            }
        }

     
    }
}

                