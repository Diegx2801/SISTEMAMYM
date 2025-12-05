namespace SistemaVentas
{
    partial class BandejaRequerimientosCompras
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
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnPedidoCompra = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvRequerimientosCompras = new System.Windows.Forms.DataGridView();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cboObra = new System.Windows.Forms.ComboBox();
            this.lblObra = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtBuscarNumReq = new System.Windows.Forms.TextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ReqcompraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientosCompras)).BeginInit();
            this.statusBar.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnPedidoCompra);
            this.pnlAcciones.Controls.Add(this.btnAnular);
            this.pnlAcciones.Controls.Add(this.btnAtender);
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAcciones.Location = new System.Drawing.Point(941, 0);
            this.pnlAcciones.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(130, 551);
            this.pnlAcciones.TabIndex = 22;
            // 
            // btnPedidoCompra
            // 
            this.btnPedidoCompra.Location = new System.Drawing.Point(18, 93);
            this.btnPedidoCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btnPedidoCompra.Name = "btnPedidoCompra";
            this.btnPedidoCompra.Size = new System.Drawing.Size(91, 36);
            this.btnPedidoCompra.TabIndex = 25;
            this.btnPedidoCompra.Text = "PedidoCompra";
            this.btnPedidoCompra.UseVisualStyleBackColor = true;
            this.btnPedidoCompra.Click += new System.EventHandler(this.btnPedidoCompra_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(18, 146);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(91, 39);
            this.btnAnular.TabIndex = 18;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(18, 38);
            this.btnAtender.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(91, 36);
            this.btnAtender.TabIndex = 11;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(18, 209);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 38);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvRequerimientosCompras
            // 
            this.dgvRequerimientosCompras.AllowUserToDeleteRows = false;
            this.dgvRequerimientosCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequerimientosCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReqcompraID,
            this.ObraID,
            this.Fecha,
            this.Solicitante,
            this.Prioridad,
            this.Observacion,
            this.Estado});
            this.dgvRequerimientosCompras.Location = new System.Drawing.Point(19, 126);
            this.dgvRequerimientosCompras.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRequerimientosCompras.Name = "dgvRequerimientosCompras";
            this.dgvRequerimientosCompras.RowHeadersWidth = 51;
            this.dgvRequerimientosCompras.RowTemplate.Height = 24;
            this.dgvRequerimientosCompras.Size = new System.Drawing.Size(881, 380);
            this.dgvRequerimientosCompras.TabIndex = 20;
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 529);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusBar.Size = new System.Drawing.Size(941, 22);
            this.statusBar.TabIndex = 23;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(99, 17);
            this.toolStripStatusLabel1.Text = "Total de Registros";
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.comboBox2);
            this.grpFiltros.Controls.Add(this.cboObra);
            this.grpFiltros.Controls.Add(this.lblObra);
            this.grpFiltros.Controls.Add(this.lblEstado);
            this.grpFiltros.Controls.Add(this.txtBuscarNumReq);
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
            this.grpFiltros.Size = new System.Drawing.Size(891, 88);
            this.grpFiltros.TabIndex = 24;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros de búsqueda";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(314, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // cboObra
            // 
            this.cboObra.FormattingEnabled = true;
            this.cboObra.Location = new System.Drawing.Point(171, 41);
            this.cboObra.Name = "cboObra";
            this.cboObra.Size = new System.Drawing.Size(121, 21);
            this.cboObra.TabIndex = 18;
            // 
            // lblObra
            // 
            this.lblObra.AutoSize = true;
            this.lblObra.Location = new System.Drawing.Point(168, 23);
            this.lblObra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObra.Name = "lblObra";
            this.lblObra.Size = new System.Drawing.Size(36, 13);
            this.lblObra.TabIndex = 16;
            this.lblObra.Text = "Obra :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(311, 24);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Prioridad:";
            // 
            // txtBuscarNumReq
            // 
            this.txtBuscarNumReq.Location = new System.Drawing.Point(17, 42);
            this.txtBuscarNumReq.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarNumReq.Name = "txtBuscarNumReq";
            this.txtBuscarNumReq.Size = new System.Drawing.Size(122, 20);
            this.txtBuscarNumReq.TabIndex = 7;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(467, 42);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(91, 20);
            this.dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(611, 43);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(98, 20);
            this.dtpHasta.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(742, 36);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 30);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 27);
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
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar por N° Req";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(454, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Atender Requerimiento de Compra (Compras)";
            // 
            // ReqcompraID
            // 
            this.ReqcompraID.DataPropertyName = "ReqcompraID";
            this.ReqcompraID.HeaderText = "N° Req";
            this.ReqcompraID.MinimumWidth = 6;
            this.ReqcompraID.Name = "ReqcompraID";
            this.ReqcompraID.Width = 80;
            // 
            // ObraID
            // 
            this.ObraID.DataPropertyName = "ObraID";
            this.ObraID.HeaderText = "Obra";
            this.ObraID.MinimumWidth = 6;
            this.ObraID.Name = "ObraID";
            this.ObraID.Width = 160;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 135;
            // 
            // Solicitante
            // 
            this.Solicitante.DataPropertyName = "Solicitante";
            this.Solicitante.HeaderText = "Solicitante";
            this.Solicitante.MinimumWidth = 6;
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.Width = 150;
            // 
            // Prioridad
            // 
            this.Prioridad.DataPropertyName = "Prioridad";
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.MinimumWidth = 6;
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.Width = 125;
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // BandejaRequerimientosCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 551);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.dgvRequerimientosCompras);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BandejaRequerimientosCompras";
            this.Text = "Bandeja de Requerimientos de Compra";
            this.Load += new System.EventHandler(this.BandejaRequerimientosCompras_Load);
            this.pnlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientosCompras)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvRequerimientosCompras;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cboObra;
        private System.Windows.Forms.Label lblObra;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtBuscarNumReq;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPedidoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReqcompraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}