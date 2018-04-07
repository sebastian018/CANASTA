namespace SuperMercadoLaCanasta
{
    partial class frmListarSugerido
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
            this.gvdSugeridos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnConsecutivo = new System.Windows.Forms.RadioButton();
            this.rbtnFechas = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvdSugeridos)).BeginInit();
            this.SuspendLayout();
            // 
            // gvdSugeridos
            // 
            this.gvdSugeridos.AllowUserToAddRows = false;
            this.gvdSugeridos.AllowUserToDeleteRows = false;
            this.gvdSugeridos.AllowUserToResizeColumns = false;
            this.gvdSugeridos.AllowUserToResizeRows = false;
            this.gvdSugeridos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvdSugeridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvdSugeridos.Location = new System.Drawing.Point(29, 177);
            this.gvdSugeridos.Name = "gvdSugeridos";
            this.gvdSugeridos.Size = new System.Drawing.Size(760, 194);
            this.gvdSugeridos.TabIndex = 0;
            this.gvdSugeridos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvdSugeridos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado Sugeridos";
            // 
            // rbtnConsecutivo
            // 
            this.rbtnConsecutivo.AutoSize = true;
            this.rbtnConsecutivo.Location = new System.Drawing.Point(45, 75);
            this.rbtnConsecutivo.Name = "rbtnConsecutivo";
            this.rbtnConsecutivo.Size = new System.Drawing.Size(14, 13);
            this.rbtnConsecutivo.TabIndex = 2;
            this.rbtnConsecutivo.TabStop = true;
            this.rbtnConsecutivo.UseVisualStyleBackColor = true;
            this.rbtnConsecutivo.CheckedChanged += new System.EventHandler(this.rbtnConsecutivo_CheckedChanged);
            // 
            // rbtnFechas
            // 
            this.rbtnFechas.AutoSize = true;
            this.rbtnFechas.Location = new System.Drawing.Point(45, 108);
            this.rbtnFechas.Name = "rbtnFechas";
            this.rbtnFechas.Size = new System.Drawing.Size(14, 13);
            this.rbtnFechas.TabIndex = 3;
            this.rbtnFechas.TabStop = true;
            this.rbtnFechas.UseVisualStyleBackColor = true;
            this.rbtnFechas.CheckedChanged += new System.EventHandler(this.rbtnFechas_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de Pedido";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Enabled = false;
            this.txtNumeroPedido.Location = new System.Drawing.Point(252, 72);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(177, 20);
            this.txtNumeroPedido.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Inicial";
            // 
            // txtFechaInicial
            // 
            this.txtFechaInicial.Enabled = false;
            this.txtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaInicial.Location = new System.Drawing.Point(252, 108);
            this.txtFechaInicial.Name = "txtFechaInicial";
            this.txtFechaInicial.Size = new System.Drawing.Size(177, 20);
            this.txtFechaInicial.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Entre";
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.Enabled = false;
            this.txtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaFinal.Location = new System.Drawing.Point(531, 108);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(177, 20);
            this.txtFechaFinal.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(633, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Location = new System.Drawing.Point(770, 398);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(19, 13);
            this.txtId.TabIndex = 11;
            this.txtId.Visible = false;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(29, 388);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 12;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Visible = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(144, 387);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmListarSugerido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 515);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFechaFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFechaInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtnFechas);
            this.Controls.Add(this.rbtnConsecutivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvdSugeridos);
            this.Name = "frmListarSugerido";
            this.Text = "frmListarSugerido";
            this.Load += new System.EventHandler(this.frmListarSugerido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvdSugeridos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvdSugeridos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnConsecutivo;
        private System.Windows.Forms.RadioButton rbtnFechas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtFechaInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtFechaFinal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnEliminar;
    }
}