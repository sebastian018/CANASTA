using Entidades.PedidoSugerido;
using Logica.PedidoSugerido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMercadoLaCanasta
{
    public partial class frmListarSugerido : Form
    {
        public frmListarSugerido()
        {
            InitializeComponent();
        }

        #region Variables
        LClPedidoSugerido lObjPedidoSugerido;
        #endregion

        private void frmListarSugerido_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                lObjPedidoSugerido = new LClPedidoSugerido();

                mtdListarPorConsecutivo();
                mtdListarPorFechas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void rbtnConsecutivo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnConsecutivo.Checked)
                {
                    rbtnFechas.Checked = false;
                    txtNumeroPedido.Enabled = true;
                    txtFechaInicial.Enabled = false;
                    txtFechaFinal.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void rbtnFechas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbtnFechas.Checked)
                {
                    rbtnConsecutivo.Checked = false;
                    txtFechaInicial.Enabled = true;
                    txtFechaFinal.Enabled = true;
                    txtNumeroPedido.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mtdOcultarColumnas()
        {
            gvdSugeridos.Columns[0].Visible = false;

            gvdSugeridos.Columns[1].HeaderText = "Consecutivo";
            gvdSugeridos.Columns[2].HeaderText = "Fecha";
        }

        private void gvdSugeridos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int poc = gvdSugeridos.CurrentRow.Index;

                txtId.Text = gvdSugeridos[0, poc].Value.ToString();
                btnVer.Visible = true;
                btnEliminar.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                new FrmVerSugerido(int.Parse(txtId.Text)).Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar este pedido?", "La Canasta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EclPedidoSugerido pedidoSugerido = new EclPedidoSugerido();
                    pedidoSugerido.idPedidoSugerido = int.Parse(txtId.Text);
                    pedidoSugerido.estado = "Inactivo";

                    int result = lObjPedidoSugerido.mtdEliminarPedidoSugerido(pedidoSugerido);

                    if (result == 1)
                    {
                        mtdListarPorConsecutivo();
                        mtdListarPorFechas();

                        MessageBox.Show("Pedido eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar pedido");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mtdListarPorConsecutivo()
        {
            try
            {
                if (rbtnConsecutivo.Checked)
                {
                    if (txtNumeroPedido.Text != "")
                    {
                        gvdSugeridos.DataSource = lObjPedidoSugerido.mtdListarPedidoSugeridoPorConsecutivo(txtNumeroPedido.Text);
                        mtdOcultarColumnas();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese número de pedido");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mtdListarPorFechas()
        {
            try
            {
                if (rbtnFechas.Checked)
                {
                    gvdSugeridos.DataSource = lObjPedidoSugerido.mtdListarPedidoSugeridoPorFechas(DateTime.Parse(txtFechaInicial.Text), DateTime.Parse(txtFechaFinal.Text));
                    mtdOcultarColumnas();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
