namespace SuperMercadoLaCanasta
{
    partial class frmSugeridos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSugeridos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.tbcCrearSugerido = new System.Windows.Forms.TabControl();
            this.tbcCrear = new System.Windows.Forms.TabPage();
            this.lblIdDepartamento = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAlmacen = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEmbalage = new System.Windows.Forms.ComboBox();
            this.labelemba = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcModificar = new System.Windows.Forms.TabPage();
            this.tbcVersugerido = new System.Windows.Forms.TabPage();
            this.btnVerSugerido = new System.Windows.Forms.Button();
            this.dgvSugerido = new System.Windows.Forms.DataGridView();
            this.lblTituloSugerido = new System.Windows.Forms.Label();
            this.Erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbcCrearSugerido.SuspendLayout();
            this.tbcCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            this.tbcVersugerido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugerido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erroricono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-163, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ingrese codigo de barras";
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(-160, 252);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(140, 20);
            this.txtCodigoBarra.TabIndex = 26;
            // 
            // tbcCrearSugerido
            // 
            this.tbcCrearSugerido.Controls.Add(this.tbcCrear);
            this.tbcCrearSugerido.Controls.Add(this.tbcModificar);
            this.tbcCrearSugerido.Controls.Add(this.tbcVersugerido);
            this.tbcCrearSugerido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbcCrearSugerido.Location = new System.Drawing.Point(24, 131);
            this.tbcCrearSugerido.Name = "tbcCrearSugerido";
            this.tbcCrearSugerido.SelectedIndex = 0;
            this.tbcCrearSugerido.Size = new System.Drawing.Size(944, 431);
            this.tbcCrearSugerido.TabIndex = 28;
            // 
            // tbcCrear
            // 
            this.tbcCrear.Controls.Add(this.lblIdDepartamento);
            this.tbcCrear.Controls.Add(this.txtCodigoBarras);
            this.tbcCrear.Controls.Add(this.btnEnviar);
            this.tbcCrear.Controls.Add(this.label9);
            this.tbcCrear.Controls.Add(this.btnCancelar);
            this.tbcCrear.Controls.Add(this.nupCantidad);
            this.tbcCrear.Controls.Add(this.label6);
            this.tbcCrear.Controls.Add(this.cmbAlmacen);
            this.tbcCrear.Controls.Add(this.label8);
            this.tbcCrear.Controls.Add(this.txtDepartamento);
            this.tbcCrear.Controls.Add(this.label7);
            this.tbcCrear.Controls.Add(this.cmbEmbalage);
            this.tbcCrear.Controls.Add(this.labelemba);
            this.tbcCrear.Controls.Add(this.txtDescrip);
            this.tbcCrear.Controls.Add(this.label4);
            this.tbcCrear.Controls.Add(this.txtFecha);
            this.tbcCrear.Controls.Add(this.label5);
            this.tbcCrear.Controls.Add(this.label3);
            this.tbcCrear.Controls.Add(this.label1);
            this.tbcCrear.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbcCrear.Location = new System.Drawing.Point(4, 22);
            this.tbcCrear.Name = "tbcCrear";
            this.tbcCrear.Padding = new System.Windows.Forms.Padding(3);
            this.tbcCrear.Size = new System.Drawing.Size(936, 405);
            this.tbcCrear.TabIndex = 0;
            this.tbcCrear.Text = "Crear";
            this.tbcCrear.UseVisualStyleBackColor = true;
            // 
            // lblIdDepartamento
            // 
            this.lblIdDepartamento.AutoSize = true;
            this.lblIdDepartamento.Location = new System.Drawing.Point(866, 14);
            this.lblIdDepartamento.Name = "lblIdDepartamento";
            this.lblIdDepartamento.Size = new System.Drawing.Size(0, 16);
            this.lblIdDepartamento.TabIndex = 66;
            this.lblIdDepartamento.Visible = false;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.BackColor = System.Drawing.Color.YellowGreen;
            this.txtCodigoBarras.Enabled = false;
            this.txtCodigoBarras.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCodigoBarras.Location = new System.Drawing.Point(19, 144);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(196, 39);
            this.txtCodigoBarras.TabIndex = 65;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Image = global::SuperMercadoLaCanasta.Properties.Resources.restaurar;
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviar.Location = new System.Drawing.Point(599, 312);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(73, 42);
            this.btnEnviar.TabIndex = 64;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(12, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 38);
            this.label9.TabIndex = 63;
            this.label9.Text = "Crear Sugerido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::SuperMercadoLaCanasta.Properties.Resources.error2;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(750, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 42);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nupCantidad
            // 
            this.nupCantidad.BackColor = System.Drawing.Color.YellowGreen;
            this.nupCantidad.Enabled = false;
            this.nupCantidad.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.nupCantidad.Location = new System.Drawing.Point(34, 324);
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(54, 39);
            this.nupCantidad.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "Codigo Barras";
            // 
            // cmbAlmacen
            // 
            this.cmbAlmacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbAlmacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAlmacen.BackColor = System.Drawing.Color.YellowGreen;
            this.cmbAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbAlmacen.Location = new System.Drawing.Point(689, 21);
            this.cmbAlmacen.Name = "cmbAlmacen";
            this.cmbAlmacen.Size = new System.Drawing.Size(171, 33);
            this.cmbAlmacen.TabIndex = 58;
            this.cmbAlmacen.Text = "Seleccione";
            this.cmbAlmacen.SelectedIndexChanged += new System.EventHandler(this.cmbAlmacen_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(594, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "Almacen";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.Color.YellowGreen;
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtDepartamento.Location = new System.Drawing.Point(689, 144);
            this.txtDepartamento.Multiline = true;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDepartamento.Size = new System.Drawing.Size(229, 39);
            this.txtDepartamento.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(684, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "Departamento";
            // 
            // cmbEmbalage
            // 
            this.cmbEmbalage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbEmbalage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmbalage.BackColor = System.Drawing.Color.YellowGreen;
            this.cmbEmbalage.Enabled = false;
            this.cmbEmbalage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmbalage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmbEmbalage.FormattingEnabled = true;
            this.cmbEmbalage.Location = new System.Drawing.Point(284, 324);
            this.cmbEmbalage.Name = "cmbEmbalage";
            this.cmbEmbalage.Size = new System.Drawing.Size(187, 33);
            this.cmbEmbalage.TabIndex = 54;
            this.cmbEmbalage.Text = "Seleccione";
            // 
            // labelemba
            // 
            this.labelemba.AutoSize = true;
            this.labelemba.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemba.Location = new System.Drawing.Point(279, 279);
            this.labelemba.Name = "labelemba";
            this.labelemba.Size = new System.Drawing.Size(77, 25);
            this.labelemba.TabIndex = 53;
            this.labelemba.Text = "Embalage";
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.YellowGreen;
            this.txtDescrip.Enabled = false;
            this.txtDescrip.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtDescrip.Location = new System.Drawing.Point(284, 144);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescrip.Size = new System.Drawing.Size(337, 39);
            this.txtDescrip.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "Descripcion ";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.YellowGreen;
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtFecha.Location = new System.Drawing.Point(362, 26);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(216, 39);
            this.txtFecha.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ingrese cantidad a pedir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 47;
            // 
            // tbcModificar
            // 
            this.tbcModificar.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbcModificar.Location = new System.Drawing.Point(4, 22);
            this.tbcModificar.Name = "tbcModificar";
            this.tbcModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbcModificar.Size = new System.Drawing.Size(936, 405);
            this.tbcModificar.TabIndex = 1;
            this.tbcModificar.Text = "Modificar";
            this.tbcModificar.UseVisualStyleBackColor = true;
            // 
            // tbcVersugerido
            // 
            this.tbcVersugerido.Controls.Add(this.btnVerSugerido);
            this.tbcVersugerido.Controls.Add(this.dgvSugerido);
            this.tbcVersugerido.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcVersugerido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbcVersugerido.Location = new System.Drawing.Point(4, 22);
            this.tbcVersugerido.Name = "tbcVersugerido";
            this.tbcVersugerido.Padding = new System.Windows.Forms.Padding(3);
            this.tbcVersugerido.Size = new System.Drawing.Size(936, 405);
            this.tbcVersugerido.TabIndex = 3;
            this.tbcVersugerido.Text = "Ver sugerido";
            this.tbcVersugerido.UseVisualStyleBackColor = true;
            // 
            // btnVerSugerido
            // 
            this.btnVerSugerido.Image = ((System.Drawing.Image)(resources.GetObject("btnVerSugerido.Image")));
            this.btnVerSugerido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerSugerido.Location = new System.Drawing.Point(65, 29);
            this.btnVerSugerido.Name = "btnVerSugerido";
            this.btnVerSugerido.Size = new System.Drawing.Size(75, 44);
            this.btnVerSugerido.TabIndex = 1;
            this.btnVerSugerido.Text = "Imprimir";
            this.btnVerSugerido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerSugerido.UseVisualStyleBackColor = true;
            this.btnVerSugerido.Click += new System.EventHandler(this.btnVerSugerido_Click);
            // 
            // dgvSugerido
            // 
            this.dgvSugerido.AllowUserToAddRows = false;
            this.dgvSugerido.AllowUserToDeleteRows = false;
            this.dgvSugerido.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvSugerido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSugerido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSugerido.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgvSugerido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSugerido.Location = new System.Drawing.Point(65, 79);
            this.dgvSugerido.Name = "dgvSugerido";
            this.dgvSugerido.ReadOnly = true;
            this.dgvSugerido.Size = new System.Drawing.Size(816, 222);
            this.dgvSugerido.TabIndex = 0;
            // 
            // lblTituloSugerido
            // 
            this.lblTituloSugerido.AutoSize = true;
            this.lblTituloSugerido.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSugerido.ForeColor = System.Drawing.Color.Green;
            this.lblTituloSugerido.Location = new System.Drawing.Point(360, 63);
            this.lblTituloSugerido.Name = "lblTituloSugerido";
            this.lblTituloSugerido.Size = new System.Drawing.Size(261, 65);
            this.lblTituloSugerido.TabIndex = 29;
            this.lblTituloSugerido.Text = "Sugeridos ";
            // 
            // Erroricono
            // 
            this.Erroricono.ContainerControl = this;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(877, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(27, 23);
            this.btnMinimizar.TabIndex = 33;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(900, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(27, 23);
            this.btnMaximizar.TabIndex = 32;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(922, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 23);
            this.btnCerrar.TabIndex = 31;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(949, 39);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // frmSugeridos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 575);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTituloSugerido);
            this.Controls.Add(this.tbcCrearSugerido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoBarra);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSugeridos";
            this.Text = ".:. Pedir Sugeridos .:.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSugeridos_Load);
            this.tbcCrearSugerido.ResumeLayout(false);
            this.tbcCrear.ResumeLayout(false);
            this.tbcCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            this.tbcVersugerido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSugerido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erroricono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.TabControl tbcCrearSugerido;
        private System.Windows.Forms.TabPage tbcCrear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAlmacen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEmbalage;
        private System.Windows.Forms.Label labelemba;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbcModificar;
        private System.Windows.Forms.Label lblTituloSugerido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblIdDepartamento;
        private System.Windows.Forms.TabPage tbcVersugerido;
        private System.Windows.Forms.Button btnVerSugerido;
        private System.Windows.Forms.DataGridView dgvSugerido;
        private System.Windows.Forms.ErrorProvider Erroricono;
        private System.Windows.Forms.ToolTip ttMensaje;
    }
}