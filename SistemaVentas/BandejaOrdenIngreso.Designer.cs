namespace SistemaVentas
{
    partial class BandejaOrdenIngreso
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
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.colNpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.cboProveedorFiltro = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtNroPedido = new System.Windows.Forms.TextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblBandejaOrdenIngreso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.AllowUserToDeleteRows = false;
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNpedido,
            this.colFecha,
            this.colProveedor,
            this.colEstado});
            this.dgvOrdenes.Location = new System.Drawing.Point(31, 170);
            this.dgvOrdenes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.RowHeadersWidth = 51;
            this.dgvOrdenes.RowTemplate.Height = 24;
            this.dgvOrdenes.Size = new System.Drawing.Size(776, 380);
            this.dgvOrdenes.TabIndex = 45;
            // 
            // colNpedido
            // 
            this.colNpedido.HeaderText = "N° Pedido";
            this.colNpedido.MinimumWidth = 6;
            this.colNpedido.Name = "colNpedido";
            this.colNpedido.Width = 80;
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 135;
            // 
            // colProveedor
            // 
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 125;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.cboProveedorFiltro);
            this.grpFiltros.Controls.Add(this.lblProveedor);
            this.grpFiltros.Controls.Add(this.txtNroPedido);
            this.grpFiltros.Controls.Add(this.dtpDesde);
            this.grpFiltros.Controls.Add(this.dtpHasta);
            this.grpFiltros.Controls.Add(this.btnBuscar);
            this.grpFiltros.Controls.Add(this.lblHasta);
            this.grpFiltros.Controls.Add(this.lblDesde);
            this.grpFiltros.Controls.Add(this.lblPedido);
            this.grpFiltros.Location = new System.Drawing.Point(31, 61);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Size = new System.Drawing.Size(776, 88);
            this.grpFiltros.TabIndex = 50;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros de búsqueda";
            // 
            // cboProveedorFiltro
            // 
            this.cboProveedorFiltro.FormattingEnabled = true;
            this.cboProveedorFiltro.Location = new System.Drawing.Point(166, 42);
            this.cboProveedorFiltro.Name = "cboProveedorFiltro";
            this.cboProveedorFiltro.Size = new System.Drawing.Size(121, 21);
            this.cboProveedorFiltro.TabIndex = 22;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(163, 24);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 21;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // txtNroPedido
            // 
            this.txtNroPedido.Location = new System.Drawing.Point(17, 42);
            this.txtNroPedido.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroPedido.Name = "txtNroPedido";
            this.txtNroPedido.Size = new System.Drawing.Size(122, 20);
            this.txtNroPedido.TabIndex = 7;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(458, 43);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(91, 20);
            this.dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(570, 43);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(98, 20);
            this.dtpHasta.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(688, 36);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 30);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(567, 28);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 6;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(455, 28);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 5;
            this.lblDesde.Text = "Desde";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(14, 24);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(109, 13);
            this.lblPedido.TabIndex = 8;
            this.lblPedido.Text = "Buscar por N° Pedido";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(854, 543);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(56, 19);
            this.btnInicio.TabIndex = 49;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(836, 313);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 38);
            this.btnCerrar.TabIndex = 48;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(836, 375);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(91, 39);
            this.btnImprimir.TabIndex = 47;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // lblBandejaOrdenIngreso
            // 
            this.lblBandejaOrdenIngreso.AutoSize = true;
            this.lblBandejaOrdenIngreso.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandejaOrdenIngreso.Location = new System.Drawing.Point(360, 20);
            this.lblBandejaOrdenIngreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBandejaOrdenIngreso.Name = "lblBandejaOrdenIngreso";
            this.lblBandejaOrdenIngreso.Size = new System.Drawing.Size(262, 26);
            this.lblBandejaOrdenIngreso.TabIndex = 44;
            this.lblBandejaOrdenIngreso.Text = "Bandeja Orden de Ingreso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(836, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 38);
            this.button1.TabIndex = 51;
            this.button1.Text = "Anular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(836, 195);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 38);
            this.button2.TabIndex = 52;
            this.button2.Text = "Generar Orden Ingreso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGenerarOrdenIngreso_Click);
            // 
            // BandejaOrdenIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 574);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvOrdenes);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblBandejaOrdenIngreso);
            this.Name = "BandejaOrdenIngreso";
            this.Text = "BandejaOrdenIngreso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNpedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.ComboBox cboProveedorFiltro;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtNroPedido;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblBandejaOrdenIngreso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}