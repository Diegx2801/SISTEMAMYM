namespace SistemaVentas
{
    partial class OrdenSalida
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.grupBoxDatos = new System.Windows.Forms.GroupBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.cboObra = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroOrdenSalida = new System.Windows.Forms.TextBox();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerra = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAnadirOrdenSalida = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtCodigoMaterial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.grupBoxDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 26);
            this.label1.TabIndex = 46;
            this.label1.Text = "Registrar Orden de Salida";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Location = new System.Drawing.Point(11, 54);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.RowTemplate.Height = 24;
            this.dgvDetalles.Size = new System.Drawing.Size(663, 344);
            this.dgvDetalles.TabIndex = 47;
            // 
            // grupBoxDatos
            // 
            this.grupBoxDatos.Controls.Add(this.chkEstado);
            this.grupBoxDatos.Controls.Add(this.cboObra);
            this.grupBoxDatos.Controls.Add(this.label4);
            this.grupBoxDatos.Controls.Add(this.dtpFecha);
            this.grupBoxDatos.Controls.Add(this.txtObservaciones);
            this.grupBoxDatos.Controls.Add(this.label2);
            this.grupBoxDatos.Controls.Add(this.lblRazonSocial);
            this.grupBoxDatos.Controls.Add(this.label3);
            this.grupBoxDatos.Controls.Add(this.txtNroOrdenSalida);
            this.grupBoxDatos.Location = new System.Drawing.Point(12, 416);
            this.grupBoxDatos.Name = "grupBoxDatos";
            this.grupBoxDatos.Size = new System.Drawing.Size(391, 184);
            this.grupBoxDatos.TabIndex = 50;
            this.grupBoxDatos.TabStop = false;
            this.grupBoxDatos.Text = "Datos Orden de Salida";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(8, 149);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(138, 17);
            this.chkEstado.TabIndex = 52;
            this.chkEstado.Text = "Estado de Orden Salida";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // cboObra
            // 
            this.cboObra.FormattingEnabled = true;
            this.cboObra.Location = new System.Drawing.Point(121, 51);
            this.cboObra.Name = "cboObra";
            this.cboObra.Size = new System.Drawing.Size(198, 21);
            this.cboObra.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Obra:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(120, 80);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 38;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(120, 109);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(199, 20);
            this.txtObservaciones.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Observaciones:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(5, 22);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(103, 13);
            this.lblRazonSocial.TabIndex = 9;
            this.lblRazonSocial.Text = "Nro de Orden Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha:";
            // 
            // txtNroOrdenSalida
            // 
            this.txtNroOrdenSalida.Location = new System.Drawing.Point(121, 22);
            this.txtNroOrdenSalida.Name = "txtNroOrdenSalida";
            this.txtNroOrdenSalida.Size = new System.Drawing.Size(199, 20);
            this.txtNroOrdenSalida.TabIndex = 14;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Location = new System.Drawing.Point(82, 112);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDetalle.TabIndex = 5;
            this.btnAgregarDetalle.Text = "Agregar";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(82, 74);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(129, 20);
            this.txtCantidad.TabIndex = 49;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Location = new System.Drawing.Point(26, 77);
            this.lblTotalItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(52, 13);
            this.lblTotalItems.TabIndex = 48;
            this.lblTotalItems.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Codigo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoMaterial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.btnAgregarDetalle);
            this.groupBox1.Controls.Add(this.lblTotalItems);
            this.groupBox1.Location = new System.Drawing.Point(423, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 150);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Materiales";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCerra);
            this.pnlAcciones.Controls.Add(this.btnAnular);
            this.pnlAcciones.Controls.Add(this.btnInicio);
            this.pnlAcciones.Controls.Add(this.btnAnadirOrdenSalida);
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Location = new System.Drawing.Point(433, 581);
            this.pnlAcciones.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(217, 58);
            this.pnlAcciones.TabIndex = 55;
            // 
            // btnCerra
            // 
            this.btnCerra.Location = new System.Drawing.Point(145, 11);
            this.btnCerra.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerra.Name = "btnCerra";
            this.btnCerra.Size = new System.Drawing.Size(56, 36);
            this.btnCerra.TabIndex = 22;
            this.btnCerra.Text = "Cerrar";
            this.btnCerra.UseVisualStyleBackColor = true;
            this.btnCerra.Click += new System.EventHandler(this.btnCerra_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(30, 241);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(91, 39);
            this.btnAnular.TabIndex = 18;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(64, 464);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(56, 19);
            this.btnInicio.TabIndex = 16;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnAnadirOrdenSalida
            // 
            this.btnAnadirOrdenSalida.Location = new System.Drawing.Point(9, 11);
            this.btnAnadirOrdenSalida.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnadirOrdenSalida.Name = "btnAnadirOrdenSalida";
            this.btnAnadirOrdenSalida.Size = new System.Drawing.Size(111, 36);
            this.btnAnadirOrdenSalida.TabIndex = 11;
            this.btnAnadirOrdenSalida.Text = "Añadir Orden de salida";
            this.btnAnadirOrdenSalida.UseVisualStyleBackColor = true;
            this.btnAnadirOrdenSalida.Click += new System.EventHandler(this.btnAnadirOrdenSalida_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(30, 300);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 38);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // txtCodigoMaterial
            // 
            this.txtCodigoMaterial.Location = new System.Drawing.Point(82, 38);
            this.txtCodigoMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.Size = new System.Drawing.Size(129, 20);
            this.txtCodigoMaterial.TabIndex = 52;
            // 
            // OrdenSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 663);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupBoxDatos);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.label1);
            this.Name = "OrdenSalida";
            this.Text = "OrdenSalida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.grupBoxDatos.ResumeLayout(false);
            this.grupBoxDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.GroupBox grupBoxDatos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroOrdenSalida;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerra;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnAnadirOrdenSalida;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cboObra;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtCodigoMaterial;
    }
}