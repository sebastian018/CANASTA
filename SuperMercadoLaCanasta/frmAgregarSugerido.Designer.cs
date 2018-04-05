namespace SuperMercadoLaCanasta
{
    partial class frmAgregarSugerido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblIdDepartamento = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvSugeridos = new System.Windows.Forms.DataGridView();
            this.cmbEmbalage = new System.Windows.Forms.ComboBox();
            this.lblEmbalage = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSugeridos = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugeridos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.btnGuardar);
            this.panelPrincipal.Controls.Add(this.lblUsuario);
            this.panelPrincipal.Controls.Add(this.lblIdDepartamento);
            this.panelPrincipal.Controls.Add(this.btnAgregar);
            this.panelPrincipal.Controls.Add(this.dgvSugeridos);
            this.panelPrincipal.Controls.Add(this.cmbEmbalage);
            this.panelPrincipal.Controls.Add(this.lblEmbalage);
            this.panelPrincipal.Controls.Add(this.txtCantidad);
            this.panelPrincipal.Controls.Add(this.lblCantidad);
            this.panelPrincipal.Controls.Add(this.txtDepartamento);
            this.panelPrincipal.Controls.Add(this.lblDepartamento);
            this.panelPrincipal.Controls.Add(this.txtDescripcion);
            this.panelPrincipal.Controls.Add(this.lblDescripcion);
            this.panelPrincipal.Controls.Add(this.txtCodigoBarras);
            this.panelPrincipal.Controls.Add(this.lblCodigo);
            this.panelPrincipal.Controls.Add(this.txtFecha);
            this.panelPrincipal.Controls.Add(this.lblFecha);
            this.panelPrincipal.Controls.Add(this.lblSugeridos);
            this.panelPrincipal.Location = new System.Drawing.Point(12, 12);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(906, 482);
            this.panelPrincipal.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(809, 443);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(27, 443);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 24);
            this.lblUsuario.TabIndex = 16;
            // 
            // lblIdDepartamento
            // 
            this.lblIdDepartamento.AutoSize = true;
            this.lblIdDepartamento.Enabled = false;
            this.lblIdDepartamento.Location = new System.Drawing.Point(4, 4);
            this.lblIdDepartamento.Name = "lblIdDepartamento";
            this.lblIdDepartamento.Size = new System.Drawing.Size(0, 13);
            this.lblIdDepartamento.TabIndex = 15;
            this.lblIdDepartamento.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(31, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar Sugerido";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvSugeridos
            // 
            this.dgvSugeridos.AllowUserToAddRows = false;
            this.dgvSugeridos.AllowUserToDeleteRows = false;
            this.dgvSugeridos.AllowUserToOrderColumns = true;
            this.dgvSugeridos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSugeridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSugeridos.Location = new System.Drawing.Point(30, 159);
            this.dgvSugeridos.Name = "dgvSugeridos";
            this.dgvSugeridos.ReadOnly = true;
            this.dgvSugeridos.Size = new System.Drawing.Size(855, 264);
            this.dgvSugeridos.TabIndex = 13;
            // 
            // cmbEmbalage
            // 
            this.cmbEmbalage.Enabled = false;
            this.cmbEmbalage.FormattingEnabled = true;
            this.cmbEmbalage.Location = new System.Drawing.Point(690, 83);
            this.cmbEmbalage.Name = "cmbEmbalage";
            this.cmbEmbalage.Size = new System.Drawing.Size(195, 21);
            this.cmbEmbalage.TabIndex = 12;
            // 
            // lblEmbalage
            // 
            this.lblEmbalage.AutoSize = true;
            this.lblEmbalage.Location = new System.Drawing.Point(620, 83);
            this.lblEmbalage.Name = "lblEmbalage";
            this.lblEmbalage.Size = new System.Drawing.Size(54, 13);
            this.lblEmbalage.TabIndex = 11;
            this.lblEmbalage.Text = "Embalage";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(393, 80);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(161, 20);
            this.txtCantidad.TabIndex = 10;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(299, 83);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Location = new System.Drawing.Point(108, 80);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(149, 20);
            this.txtDepartamento.TabIndex = 8;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(28, 83);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(74, 13);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(690, 46);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(195, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(620, 46);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(393, 43);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(161, 20);
            this.txtCodigoBarras.TabIndex = 4;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(299, 46);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(88, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo de Barras";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(82, 43);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(175, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(27, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblSugeridos
            // 
            this.lblSugeridos.AutoSize = true;
            this.lblSugeridos.Location = new System.Drawing.Point(390, 12);
            this.lblSugeridos.Name = "lblSugeridos";
            this.lblSugeridos.Size = new System.Drawing.Size(107, 13);
            this.lblSugeridos.TabIndex = 0;
            this.lblSugeridos.Text = "Ingreso de Sugeridos";
            // 
            // frmAgregarSugerido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 506);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "frmAgregarSugerido";
            this.Text = "frmAgregarSugerido";
            this.Load += new System.EventHandler(this.frmAgregarSugerido_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugeridos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label lblSugeridos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.DataGridView dgvSugeridos;
        private System.Windows.Forms.ComboBox cmbEmbalage;
        private System.Windows.Forms.Label lblEmbalage;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIdDepartamento;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnGuardar;
    }
}