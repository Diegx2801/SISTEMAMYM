namespace SistemaVentas
{
    partial class BandejaPedidoCompra
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
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.cboProveedorFiltro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboEstadoFiltro = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNroPedido = new System.Windows.Forms.TextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnValidarPedido = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFormaPago = new System.Windows.Forms.Button();
            this.btnProv = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvPedidoCompra = new System.Windows.Forms.DataGridView();
            this.PedidoCompraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.grpFiltros.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.cboProveedorFiltro);
            this.grpFiltros.Controls.Add(this.label4);
            this.grpFiltros.Controls.Add(this.cboEstadoFiltro);
            this.grpFiltros.Controls.Add(this.lblEstado);
            this.grpFiltros.Controls.Add(this.txtNroPedido);
            this.grpFiltros.Controls.Add(this.dtpDesde);
            this.grpFiltros.Controls.Add(this.dtpHasta);
            this.grpFiltros.Controls.Add(this.btnBuscar);
            this.grpFiltros.Controls.Add(this.label2);
            this.grpFiltros.Controls.Add(this.label1);
            this.grpFiltros.Controls.Add(this.label3);
            this.grpFiltros.Location = new System.Drawing.Point(9, 23);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Size = new System.Drawing.Size(780, 88);
            this.grpFiltros.TabIndex = 28;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Proveedor:";
            // 
            // cboEstadoFiltro
            // 
            this.cboEstadoFiltro.FormattingEnabled = true;
            this.cboEstadoFiltro.Location = new System.Drawing.Point(315, 42);
            this.cboEstadoFiltro.Name = "cboEstadoFiltro";
            this.cboEstadoFiltro.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoFiltro.TabIndex = 19;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(312, 26);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado:";
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
            this.btnBuscar.Location = new System.Drawing.Point(689, 36);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 30);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar por N° Pedido";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 533);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusBar.Size = new System.Drawing.Size(864, 22);
            this.statusBar.TabIndex = 27;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(99, 17);
            this.toolStripStatusLabel1.Text = "Total de Registros";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnValidarPedido);
            this.pnlAcciones.Controls.Add(this.button1);
            this.pnlAcciones.Controls.Add(this.btnFormaPago);
            this.pnlAcciones.Controls.Add(this.btnProv);
            this.pnlAcciones.Controls.Add(this.btnAnular);
            this.pnlAcciones.Controls.Add(this.btnInicio);
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAcciones.Location = new System.Drawing.Point(864, 0);
            this.pnlAcciones.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(130, 555);
            this.pnlAcciones.TabIndex = 26;
            // 
            // btnValidarPedido
            // 
            this.btnValidarPedido.Location = new System.Drawing.Point(20, 124);
            this.btnValidarPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnValidarPedido.Name = "btnValidarPedido";
            this.btnValidarPedido.Size = new System.Drawing.Size(91, 39);
            this.btnValidarPedido.TabIndex = 26;
            this.btnValidarPedido.Text = "Aprobar pedido compra";
            this.btnValidarPedido.UseVisualStyleBackColor = true;
            this.btnValidarPedido.Click += new System.EventHandler(this.btnAprobarPedidoCompra_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 25;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFormaPago
            // 
            this.btnFormaPago.Location = new System.Drawing.Point(20, 384);
            this.btnFormaPago.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormaPago.Name = "btnFormaPago";
            this.btnFormaPago.Size = new System.Drawing.Size(91, 25);
            this.btnFormaPago.TabIndex = 24;
            this.btnFormaPago.Text = "Formas de pago";
            this.btnFormaPago.UseVisualStyleBackColor = true;
            // 
            // btnProv
            // 
            this.btnProv.Location = new System.Drawing.Point(20, 342);
            this.btnProv.Margin = new System.Windows.Forms.Padding(2);
            this.btnProv.Name = "btnProv";
            this.btnProv.Size = new System.Drawing.Size(91, 25);
            this.btnProv.TabIndex = 19;
            this.btnProv.Text = "Proveedores";
            this.btnProv.UseVisualStyleBackColor = true;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(20, 176);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(91, 39);
            this.btnAnular.TabIndex = 18;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(37, 427);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(56, 19);
            this.btnInicio.TabIndex = 16;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(20, 285);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 38);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvPedidoCompra
            // 
            this.dgvPedidoCompra.AllowUserToDeleteRows = false;
            this.dgvPedidoCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PedidoCompraID,
            this.Fecha,
            this.ProveedorID,
            this.Estado,
            this.Observacion});
            this.dgvPedidoCompra.Location = new System.Drawing.Point(26, 126);
            this.dgvPedidoCompra.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedidoCompra.Name = "dgvPedidoCompra";
            this.dgvPedidoCompra.RowHeadersWidth = 51;
            this.dgvPedidoCompra.RowTemplate.Height = 24;
            this.dgvPedidoCompra.Size = new System.Drawing.Size(763, 380);
            this.dgvPedidoCompra.TabIndex = 25;
            // 
            // PedidoCompraID
            // 
            this.PedidoCompraID.DataPropertyName = "PedidoCompraID";
            this.PedidoCompraID.HeaderText = "N° Pedido";
            this.PedidoCompraID.MinimumWidth = 6;
            this.PedidoCompraID.Name = "PedidoCompraID";
            this.PedidoCompraID.Width = 80;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 135;
            // 
            // ProveedorID
            // 
            this.ProveedorID.DataPropertyName = "ProveedorID";
            this.ProveedorID.HeaderText = "Proveedor";
            this.ProveedorID.Name = "ProveedorID";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.HeaderText = "Observación";
            this.Observacion.Name = "Observacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "Bandeja Pedido de Compra";
            // 
            // BandejaPedidoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 555);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.dgvPedidoCompra);
            this.Name = "BandejaPedidoCompra";
            this.Text = "Bandeja Pedido Compra";
            this.Load += new System.EventHandler(this.BandejaPedidoCompra_Load);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.ComboBox cboEstadoFiltro;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNroPedido;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnFormaPago;
        private System.Windows.Forms.Button btnProv;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvPedidoCompra;
        private System.Windows.Forms.ComboBox cboProveedorFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnValidarPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoCompraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
    }
}