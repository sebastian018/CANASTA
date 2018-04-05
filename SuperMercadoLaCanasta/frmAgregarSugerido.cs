using Entidades.PedidoSugerido;
using Entidades.SugeridoPedidoSugerido;
using Entidades.Sugeridos;
using Entidades.Usuarios;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Logica.PedidoSugerido;
using Logica.SugeridoPedidoSugerido;
using Logica.Sugeridos;
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

namespace SuperMercadoLaCanasta
{
    public partial class frmAgregarSugerido : Form
    {
        List<EClSugeridos> listaSugueridos = new List<EClSugeridos>();
        LClSugeridos lSugeridos;
        LClPedidoSugerido lSugeridoPedido;
        LClSugeridoPedidoSugerido lSugeridoPedidoSugerido;
        EClUsuarios usuarioSesion;

        public frmAgregarSugerido(EClUsuarios user)
        {
            InitializeComponent();
            usuarioSesion = user;
        }

        private void frmAgregarSugerido_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString();
            lblUsuario.Text = usuarioSesion.usuario;
            mtdCargarEmbalage();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidad.Text == "")
                {
                    MessageBox.Show("Ingrese cantidad");
                } else if (cmbEmbalage.SelectedText == "Seleccione" || cmbEmbalage.SelectedValue.ToString() == "0")
                {
                    MessageBox.Show("Ingrese embalage");
                }
                else
                {
                    EClSugeridos sugerido = new EClSugeridos();

                    sugerido.almacen = usuarioSesion.codUsuario.ToString();
                    sugerido.cantidad = int.Parse(txtCantidad.Text);
                    sugerido.codigoBarras = txtCodigoBarras.Text;
                    sugerido.departamento = int.Parse(lblIdDepartamento.Text);
                    sugerido.descripcion = txtDescripcion.Text;
                    sugerido.embalage = cmbEmbalage.SelectedValue.ToString();
                    sugerido.fecha = txtFecha.Text;
                    sugerido.id_departamento = int.Parse(lblIdDepartamento.Text);
                    sugerido.nombreDepartamento = txtDepartamento.Text;

                    if (listaSugueridos == null)
                    {
                        listaSugueridos = new List<EClSugeridos>();
                    }

                    listaSugueridos.Add(sugerido);

                    dgvSugeridos.DataSource = null;
                    dgvSugeridos.DataSource = listaSugueridos;
                    mtdRecargarCampos();
                    mtdOcultarColumnas();
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
                            txtDescripcion.Text = sugerido.descripcion;
                            lblIdDepartamento.Text = sugerido.departamento.ToString();

                            txtCantidad.Focus();
                            txtCantidad.Enabled = true;
                            cmbEmbalage.Enabled = true;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSugeridos.DataSource != null)
                {
                    lSugeridoPedido = new LClPedidoSugerido();
                    lSugeridoPedidoSugerido = new LClSugeridoPedidoSugerido();
                    EclSugeridoTable objSugeridoTable;
                    EclPedidoSugerido pedidoSugerido = new EclPedidoSugerido();
                    EClSugeridoPedidoSugerido sugeridoPedidoSugerido;
                    List<int> sugeridosIngresados = new List<int>();
                    List<int> sugeridoPedido = new List<int>();

                    #region Sugerido
                    foreach (DataGridViewRow row in dgvSugeridos.Rows)
                    {
                        objSugeridoTable = new EclSugeridoTable();

                        objSugeridoTable.almacen = usuarioSesion.codUsuario;
                        objSugeridoTable.codigo_barras = row.Cells[1].Value.ToString();
                        objSugeridoTable.descripcion_producto = row.Cells[2].Value.ToString();
                        objSugeridoTable.cantidad = int.Parse(row.Cells[3].Value.ToString());
                        objSugeridoTable.embalaje = row.Cells[4].Value.ToString();
                        objSugeridoTable.id_departamento = int.Parse(row.Cells[5].Value.ToString());
                        objSugeridoTable.descipcion_departamento = row.Cells[7].Value.ToString();
                        objSugeridoTable.fecha = DateTime.Parse(row.Cells[9].Value.ToString());

                        List<int> idSugerido = lSugeridos.mtdInsertarSugerido(objSugeridoTable);
                        sugeridosIngresados.Add(idSugerido[1]);
                    }
                    #endregion

                    #region Pedido Sugerido
                    pedidoSugerido.consecutivo = "";
                    pedidoSugerido.estado = "Activo";

                    sugeridoPedido = lSugeridoPedido.mtdInsertarPedidoSugerido(pedidoSugerido);
                    #endregion

                    #region Sugerido Pedido Sugerido

                    foreach (var item in sugeridosIngresados)
                    {
                        sugeridoPedidoSugerido = new EClSugeridoPedidoSugerido();

                        sugeridoPedidoSugerido.idSugerido = item;
                        sugeridoPedidoSugerido.idPedidoSugerido = int.Parse(sugeridoPedido[1].ToString());

                        lSugeridoPedidoSugerido.mtdInsertarPedidoSugerido(sugeridoPedidoSugerido);
                    }
                    #endregion

                    if (MessageBox.Show("¿Desea guardar PDF?", "La Canasta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                        {
                            lblRuta.Text = folderBrowserDialog1.SelectedPath;
                            mtdGenerarPdf(sugeridoPedido[1].ToString());
                        }
                    }

                    MessageBox.Show("Su pedido se ha generado con número de referencia P0000"+ sugeridoPedido[1].ToString());
                    mtdBlanquearTodo();
                }
                else
                {
                    MessageBox.Show("Ingrese sugeridos");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Metodos
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

        private void mtdRecargarCampos()
        {
            try
            {
                txtFecha.Text = DateTime.Now.ToString();
                txtCodigoBarras.Text = "";
                txtCantidad.Text = "";
                txtDepartamento.Text = "";
                txtDescripcion.Text = "";
                cmbEmbalage.SelectedValue = "0";
                txtCantidad.Enabled = false;
                cmbEmbalage.Enabled = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo para ocultar las columas no necesarias para el usuario y se cambian los nombres de las columnas
        /// </summary>
        private void mtdOcultarColumnas()
        {
            try
            {
                dgvSugeridos.Columns[0].Visible = false;
                dgvSugeridos.Columns[5].Visible = false;
                dgvSugeridos.Columns[6].Visible = false;
                dgvSugeridos.Columns[8].Visible = false;

                dgvSugeridos.Columns[1].HeaderText = "Codigo Barras";
                dgvSugeridos.Columns[2].HeaderText = "Descripción";
                dgvSugeridos.Columns[3].HeaderText = "Cantidad";
                dgvSugeridos.Columns[4].HeaderText = "Embalage";
                dgvSugeridos.Columns[7].HeaderText = "Departamento";
                dgvSugeridos.Columns[9].HeaderText = "Fecha";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo para dejar todo desde cero
        /// </summary>
        private void mtdBlanquearTodo()
        {
            try
            {
                txtFecha.Text = DateTime.Now.ToString();
                txtCodigoBarras.Text = "";
                txtCantidad.Text = "";
                txtDepartamento.Text = "";
                txtDescripcion.Text = "";
                cmbEmbalage.SelectedValue = "0";
                txtCantidad.Enabled = false;
                cmbEmbalage.Enabled = false;
                listaSugueridos = null;
                dgvSugeridos.DataSource = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void mtdGenerarPdf(string consecutivo)
        {
            try
            {
                string fecha = DateTime.Now.ToShortDateString().ToString().Replace("/", "-");

                Document doc = new Document(PageSize.LETTER);
                PdfWriter writer = PdfWriter.GetInstance(doc,
                                            new FileStream(lblRuta.Text+"/Sugueridos" + fecha + "_P0000" + consecutivo +".pdf", FileMode.Create));
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

                foreach (DataGridViewRow row in dgvSugeridos.Rows)
                {
                    // Llenamos la tabla con información
                    codigoBarras = new PdfPCell(new Phrase(row.Cells[1].Value.ToString()));
                    codigoBarras.BorderWidth = 0.45f;

                    producto = new PdfPCell(new Phrase(row.Cells[2].Value.ToString()));
                    producto.BorderWidth = 0.45f;

                    cantidad = new PdfPCell(new Phrase(row.Cells[3].Value.ToString()));
                    cantidad.BorderWidth = 0.45f;

                    embalage = new PdfPCell(new Phrase(row.Cells[4].Value.ToString()));
                    embalage.BorderWidth = 0.45f;

                    departamento = new PdfPCell(new Phrase(row.Cells[7].Value.ToString()));
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
                Console.WriteLine("Error al imprimir sugeridos: " + ex.Message);
            }
        }
    }
}
