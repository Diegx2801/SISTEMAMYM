namespace SistemaVentas
{
    partial class RequerimientosCompras
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
            this.cboEstado = new System.Windows.Forms.ComboBox();
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
            this.dgvRequerimientos = new System.Windows.Forms.DataGridView();
            this.ReqcompraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObraID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEnviarCompras = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.cboEstado);
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
            this.grpFiltros.Location = new System.Drawing.Point(22, 42);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFiltros.Size = new System.Drawing.Size(885, 88);
            this.grpFiltros.TabIndex = 23;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros de búsqueda";
            this.grpFiltros.Enter += new System.EventHandler(this.grpFiltros_Enter);
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(314, 42);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 19;
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
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado:";
            // 
            // txtBuscarNumReq
            // 
            this.txtBuscarNumReq.Location = new System.Drawing.Point(17, 42);
            this.txtBuscarNumReq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarNumReq.Name = "txtBuscarNumReq";
            this.txtBuscarNumReq.Size = new System.Drawing.Size(122, 20);
            this.txtBuscarNumReq.TabIndex = 7;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(467, 42);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(91, 20);
            this.dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(611, 43);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(98, 20);
            this.dtpHasta.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(742, 36);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // dgvRequerimientos
            // 
            this.dgvRequerimientos.AllowUserToDeleteRows = false;
            this.dgvRequerimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequerimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReqcompraID,
            this.ObraID,
            this.Fecha,
            this.Solicitante,
            this.Prioridad,
            this.Observacion,
            this.Estado,
            this.TotalItems});
            this.dgvRequerimientos.Location = new System.Drawing.Point(22, 157);
            this.dgvRequerimientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRequerimientos.Name = "dgvRequerimientos";
            this.dgvRequerimientos.RowHeadersWidth = 51;
            this.dgvRequerimientos.RowTemplate.Height = 24;
            this.dgvRequerimientos.Size = new System.Drawing.Size(885, 401);
            this.dgvRequerimientos.TabIndex = 22;
            // 
            // ReqcompraID
            // 
            this.ReqcompraID.DataPropertyName = "ReqcompraID";
            this.ReqcompraID.HeaderText = "N°Req";
            this.ReqcompraID.MinimumWidth = 6;
            this.ReqcompraID.Name = "ReqcompraID";
            this.ReqcompraID.Width = 80;
            // 
            // ObraID
            // 
            this.ObraID.DataPropertyName = "ObraID";
            this.ObraID.HeaderText = "ObraID";
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
            this.Observacion.MinimumWidth = 6;
            this.Observacion.Name = "Observacion";
            this.Observacion.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // TotalItems
            // 
            this.TotalItems.DataPropertyName = "TotalItems";
            this.TotalItems.HeaderText = "TotalItems";
            this.TotalItems.MinimumWidth = 6;
            this.TotalItems.Name = "TotalItems";
            this.TotalItems.Width = 60;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(974, 208);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(91, 39);
            this.btnAnular.TabIndex = 31;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(988, 539);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(56, 19);
            this.btnInicio.TabIndex = 29;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(974, 53);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 36);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(974, 261);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 38);
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEnviarCompras
            // 
            this.btnEnviarCompras.Location = new System.Drawing.Point(974, 162);
            this.btnEnviarCompras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviarCompras.Name = "btnEnviarCompras";
            this.btnEnviarCompras.Size = new System.Drawing.Size(91, 34);
            this.btnEnviarCompras.TabIndex = 26;
            this.btnEnviarCompras.Text = "Enviar a Compras";
            this.btnEnviarCompras.UseVisualStyleBackColor = true;
            this.btnEnviarCompras.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(974, 108);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(91, 39);
            this.btnImprimir.TabIndex = 27;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Bandeja de Requerimiento de Compras Almacen";
            // 
            // RequerimientosCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 569);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEnviarCompras);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.dgvRequerimientos);
            this.Name = "RequerimientosCompras";
            this.Text = "Bandeja de Requerimientos de Compras";
            this.Load += new System.EventHandler(this.RequerimientosCompras_Load);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequerimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblObra;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtBuscarNumReq;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRequerimientos;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEnviarCompras;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboObra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReqcompraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObraID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItems;
    }
}