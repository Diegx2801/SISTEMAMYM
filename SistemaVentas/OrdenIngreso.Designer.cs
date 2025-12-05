namespace SistemaVentas
{
    partial class OrdenIngreso
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
            this.dgvPedidosAprobados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroOrdenIngreso = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblOrdenIngreso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.gbdOrdenIngreso = new System.Windows.Forms.GroupBox();
            this.Nrpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNroPedidoCompraSeleccionado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosAprobados)).BeginInit();
            this.gbdOrdenIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPedidosAprobados
            // 
            this.dgvPedidosAprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosAprobados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nrpedido,
            this.Fecha,
            this.Proveedor,
            this.Estado,
            this.Observacion});
            this.dgvPedidosAprobados.Location = new System.Drawing.Point(76, 58);
            this.dgvPedidosAprobados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPedidosAprobados.Name = "dgvPedidosAprobados";
            this.dgvPedidosAprobados.RowHeadersWidth = 51;
            this.dgvPedidosAprobados.RowTemplate.Height = 24;
            this.dgvPedidosAprobados.Size = new System.Drawing.Size(624, 253);
            this.dgvPedidosAprobados.TabIndex = 40;
            this.dgvPedidosAprobados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidosAprobados_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 26);
            this.label1.TabIndex = 45;
            this.label1.Text = "Registrar Orden de Ingreso";
            // 
            // txtNroOrdenIngreso
            // 
            this.txtNroOrdenIngreso.Location = new System.Drawing.Point(134, 38);
            this.txtNroOrdenIngreso.Name = "txtNroOrdenIngreso";
            this.txtNroOrdenIngreso.Size = new System.Drawing.Size(199, 20);
            this.txtNroOrdenIngreso.TabIndex = 14;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(18, 74);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblOrdenIngreso
            // 
            this.lblOrdenIngreso.AutoSize = true;
            this.lblOrdenIngreso.Location = new System.Drawing.Point(18, 41);
            this.lblOrdenIngreso.Name = "lblOrdenIngreso";
            this.lblOrdenIngreso.Size = new System.Drawing.Size(109, 13);
            this.lblOrdenIngreso.TabIndex = 9;
            this.lblOrdenIngreso.Text = "Nro de Orden Ingreso";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(534, 74);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(534, 36);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(19, 105);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 36;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(133, 105);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(199, 20);
            this.txtObservaciones.TabIndex = 37;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(133, 68);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 38;
            // 
            // gbdOrdenIngreso
            // 
            this.gbdOrdenIngreso.Controls.Add(this.dtpFecha);
            this.gbdOrdenIngreso.Controls.Add(this.txtObservaciones);
            this.gbdOrdenIngreso.Controls.Add(this.lblObservaciones);
            this.gbdOrdenIngreso.Controls.Add(this.btnAgregar);
            this.gbdOrdenIngreso.Controls.Add(this.btnCancelar);
            this.gbdOrdenIngreso.Controls.Add(this.lblOrdenIngreso);
            this.gbdOrdenIngreso.Controls.Add(this.lblFecha);
            this.gbdOrdenIngreso.Controls.Add(this.txtNroOrdenIngreso);
            this.gbdOrdenIngreso.Location = new System.Drawing.Point(67, 349);
            this.gbdOrdenIngreso.Name = "gbdOrdenIngreso";
            this.gbdOrdenIngreso.Size = new System.Drawing.Size(633, 183);
            this.gbdOrdenIngreso.TabIndex = 43;
            this.gbdOrdenIngreso.TabStop = false;
            this.gbdOrdenIngreso.Text = "Datos Orden de Ingreso";
            // 
            // Nrpedido
            // 
            this.Nrpedido.HeaderText = "N° Pedido";
            this.Nrpedido.Name = "Nrpedido";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Observacion
            // 
            this.Observacion.HeaderText = "Observación";
            this.Observacion.Name = "Observacion";
            // 
            // txtNroPedidoCompraSeleccionado
            // 
            this.txtNroPedidoCompraSeleccionado.Location = new System.Drawing.Point(76, 323);
            this.txtNroPedidoCompraSeleccionado.Name = "txtNroPedidoCompraSeleccionado";
            this.txtNroPedidoCompraSeleccionado.Size = new System.Drawing.Size(73, 20);
            this.txtNroPedidoCompraSeleccionado.TabIndex = 46;
            // 
            // OrdenIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 552);
            this.Controls.Add(this.txtNroPedidoCompraSeleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbdOrdenIngreso);
            this.Controls.Add(this.dgvPedidosAprobados);
            this.Name = "OrdenIngreso";
            this.Text = "OrdenIngreso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosAprobados)).EndInit();
            this.gbdOrdenIngreso.ResumeLayout(false);
            this.gbdOrdenIngreso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPedidosAprobados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroOrdenIngreso;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblOrdenIngreso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox gbdOrdenIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nrpedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.TextBox txtNroPedidoCompraSeleccionado;
    }
}