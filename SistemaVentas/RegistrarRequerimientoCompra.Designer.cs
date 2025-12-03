namespace SistemaVentas
{
    partial class RegistrarRequerimientoCompra
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.cboObra = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtObsGeneral = new System.Windows.Forms.TextBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.txtObsItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            this.lblBuscarMaterial = new System.Windows.Forms.Label();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCierra = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(302, 19);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(418, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRAR REQUERIMIENTO DE COMPRA";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.cboObra);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.dtpFecha);
            this.grpDatos.Controls.Add(this.txtObsGeneral);
            this.grpDatos.Controls.Add(this.cmbPrioridad);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.txtSolicitante);
            this.grpDatos.Controls.Add(this.lblObservacion);
            this.grpDatos.Controls.Add(this.lblSolicitante);
            this.grpDatos.Location = new System.Drawing.Point(18, 350);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(2);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(2);
            this.grpDatos.Size = new System.Drawing.Size(450, 245);
            this.grpDatos.TabIndex = 8;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos de Requerimiento";
            // 
            // cboObra
            // 
            this.cboObra.FormattingEnabled = true;
            this.cboObra.Location = new System.Drawing.Point(76, 71);
            this.cboObra.Name = "cboObra";
            this.cboObra.Size = new System.Drawing.Size(242, 21);
            this.cboObra.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(76, 187);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // txtObsGeneral
            // 
            this.txtObsGeneral.Location = new System.Drawing.Point(76, 146);
            this.txtObsGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.txtObsGeneral.Multiline = true;
            this.txtObsGeneral.Name = "txtObsGeneral";
            this.txtObsGeneral.Size = new System.Drawing.Size(242, 19);
            this.txtObsGeneral.TabIndex = 11;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(76, 109);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(242, 21);
            this.cmbPrioridad.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prioridad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Obra:";
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(76, 32);
            this.txtSolicitante.Margin = new System.Windows.Forms.Padding(2);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(242, 20);
            this.txtSolicitante.TabIndex = 5;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(4, 146);
            this.lblObservacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(70, 13);
            this.lblObservacion.TabIndex = 4;
            this.lblObservacion.Text = "Observación:";
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Location = new System.Drawing.Point(13, 35);
            this.lblSolicitante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(59, 13);
            this.lblSolicitante.TabIndex = 2;
            this.lblSolicitante.Text = "Solicitante:";
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.txtObsItem);
            this.grpItems.Controls.Add(this.label5);
            this.grpItems.Controls.Add(this.txtUnidad);
            this.grpItems.Controls.Add(this.label4);
            this.grpItems.Controls.Add(this.txtCantidad);
            this.grpItems.Controls.Add(this.label1);
            this.grpItems.Controls.Add(this.btnAgregarItem);
            this.grpItems.Controls.Add(this.txtNombreMaterial);
            this.grpItems.Controls.Add(this.lblBuscarMaterial);
            this.grpItems.Location = new System.Drawing.Point(18, 72);
            this.grpItems.Margin = new System.Windows.Forms.Padding(2);
            this.grpItems.Name = "grpItems";
            this.grpItems.Padding = new System.Windows.Forms.Padding(2);
            this.grpItems.Size = new System.Drawing.Size(450, 259);
            this.grpItems.TabIndex = 9;
            this.grpItems.TabStop = false;
            this.grpItems.Text = "Datos del Material";
            // 
            // txtObsItem
            // 
            this.txtObsItem.Location = new System.Drawing.Point(113, 154);
            this.txtObsItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtObsItem.Name = "txtObsItem";
            this.txtObsItem.Size = new System.Drawing.Size(254, 20);
            this.txtObsItem.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Observación:";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(113, 111);
            this.txtUnidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(254, 20);
            this.txtUnidad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unidad de Medida:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(113, 73);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(254, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad:";
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(359, 215);
            this.btnAgregarItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(58, 28);
            this.btnAgregarItem.TabIndex = 4;
            this.btnAgregarItem.Text = "Agregar";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Location = new System.Drawing.Point(113, 37);
            this.txtNombreMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(254, 20);
            this.txtNombreMaterial.TabIndex = 1;
            // 
            // lblBuscarMaterial
            // 
            this.lblBuscarMaterial.AutoSize = true;
            this.lblBuscarMaterial.Location = new System.Drawing.Point(13, 37);
            this.lblBuscarMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarMaterial.Name = "lblBuscarMaterial";
            this.lblBuscarMaterial.Size = new System.Drawing.Size(47, 13);
            this.lblBuscarMaterial.TabIndex = 0;
            this.lblBuscarMaterial.Text = "Material:";
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.Location = new System.Drawing.Point(552, 505);
            this.txtTotalItems.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.Size = new System.Drawing.Size(76, 20);
            this.txtTotalItems.TabIndex = 7;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Location = new System.Drawing.Point(483, 508);
            this.lblTotalItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(65, 13);
            this.lblTotalItems.TabIndex = 6;
            this.lblTotalItems.Text = "Total Items :";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItem,
            this.colMaterial,
            this.colUnidad,
            this.colCantidad,
            this.colObservacion});
            this.dgvDetalle.Location = new System.Drawing.Point(486, 72);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(499, 423);
            this.dgvDetalle.TabIndex = 5;
            // 
            // idItem
            // 
            this.idItem.HeaderText = "ID";
            this.idItem.Name = "idItem";
            // 
            // colMaterial
            // 
            this.colMaterial.HeaderText = "Material";
            this.colMaterial.MinimumWidth = 6;
            this.colMaterial.Name = "colMaterial";
            this.colMaterial.Width = 125;
            // 
            // colUnidad
            // 
            this.colUnidad.HeaderText = "Unidad Medida";
            this.colUnidad.MinimumWidth = 6;
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Width = 70;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 70;
            // 
            // colObservacion
            // 
            this.colObservacion.HeaderText = "Observación";
            this.colObservacion.MinimumWidth = 6;
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Width = 125;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCierra);
            this.pnlAcciones.Controls.Add(this.btnAnular);
            this.pnlAcciones.Controls.Add(this.btnInicio);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Location = new System.Drawing.Point(576, 537);
            this.pnlAcciones.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(217, 58);
            this.pnlAcciones.TabIndex = 23;
            // 
            // btnCierra
            // 
            this.btnCierra.Location = new System.Drawing.Point(145, 11);
            this.btnCierra.Margin = new System.Windows.Forms.Padding(2);
            this.btnCierra.Name = "btnCierra";
            this.btnCierra.Size = new System.Drawing.Size(56, 36);
            this.btnCierra.TabIndex = 22;
            this.btnCierra.Text = "Cerrar";
            this.btnCierra.UseVisualStyleBackColor = true;
            this.btnCierra.Click += new System.EventHandler(this.btnCierra_Click);
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
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(9, 11);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(111, 36);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Añadir Requerimiento";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            // RegistrarRequerimientoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 606);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.txtTotalItems);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.grpItems);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrarRequerimientoCompra";
            this.Text = "Registrar Requerimiento de Compra";
            this.Load += new System.EventHandler(this.RegistrarRequerimientoCompra_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpItems.ResumeLayout(false);
            this.grpItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.GroupBox grpItems;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.TextBox txtNombreMaterial;
        private System.Windows.Forms.Label lblBuscarMaterial;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.TextBox txtTotalItems;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCierra;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObsGeneral;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObsItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacion;
        private System.Windows.Forms.ComboBox cboObra;
    }
}