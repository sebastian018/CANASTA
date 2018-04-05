using Entidades.PedidoSugerido;
using Logica.PedidoSugerido;
using Logica.Sugeridos;
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
    public partial class FrmVerSugerido : Form
    {
        private int idSugerido;
        private LClSugeridos lSugerido;
        private LClPedidoSugerido lPedidoSugerido;

        public FrmVerSugerido(int id)
        {
            InitializeComponent();
            idSugerido = id;
        }

        private void FrmVerSugerido_Load(object sender, EventArgs e)
        {
            mtdCargarDatos();
        }

        /// <summary>
        /// Metodo en donde se cargan todos los datos del sugerido
        /// </summary>
        private void mtdCargarDatos()
        {
            try
            {
                lSugerido = new LClSugeridos();
                lPedidoSugerido = new LClPedidoSugerido();

                EclPedidoSugerido pedidoSugerido = lPedidoSugerido.mtdListarPedidoSugeridoPorId(idSugerido);
                lblNumeroPedido.Text = pedidoSugerido.consecutivo;

                dgvSugeridos.DataSource = lSugerido.mtdListarSugeridosPorPedido(idSugerido);
                mtdOcultarColumnas();
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
                dgvSugeridos.Columns[7].Visible = false;

                dgvSugeridos.Columns[1].HeaderText = "Codigo Barras";
                dgvSugeridos.Columns[2].HeaderText = "Descripción";
                dgvSugeridos.Columns[3].HeaderText = "Cantidad";
                dgvSugeridos.Columns[4].HeaderText = "Embalage";
                dgvSugeridos.Columns[6].HeaderText = "Departamento";
                dgvSugeridos.Columns[8].HeaderText = "Fecha";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            try
            {
                new frmListarSugerido().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
