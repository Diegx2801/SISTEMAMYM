namespace SistemaVentas
{
    partial class Inicio
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
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFormaPago = new System.Windows.Forms.Button();
            this.btnObra = new System.Windows.Forms.Button();
            this.btnTipoMaterial = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnOrdenIngreso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRequerimientoCompra = new System.Windows.Forms.Button();
            this.btnOrdenSalida = new System.Windows.Forms.Button();
            this.btnPedidoCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(30, 97);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(75, 23);
            this.btnMarca.TabIndex = 0;
            this.btnMarca.Text = "Marca";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Location = new System.Drawing.Point(30, 58);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnMaterial.TabIndex = 1;
            this.btnMaterial.Text = "Material";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANTENEDORES:";
            // 
            // btnFormaPago
            // 
            this.btnFormaPago.Location = new System.Drawing.Point(30, 138);
            this.btnFormaPago.Name = "btnFormaPago";
            this.btnFormaPago.Size = new System.Drawing.Size(75, 30);
            this.btnFormaPago.TabIndex = 3;
            this.btnFormaPago.Text = "Forma Pago";
            this.btnFormaPago.UseVisualStyleBackColor = true;
            this.btnFormaPago.Click += new System.EventHandler(this.btnFormaPago_Click);
            // 
            // btnObra
            // 
            this.btnObra.Location = new System.Drawing.Point(30, 188);
            this.btnObra.Name = "btnObra";
            this.btnObra.Size = new System.Drawing.Size(75, 23);
            this.btnObra.TabIndex = 4;
            this.btnObra.Text = "Obra";
            this.btnObra.UseVisualStyleBackColor = true;
            this.btnObra.Click += new System.EventHandler(this.btnObra_Click);
            // 
            // btnTipoMaterial
            // 
            this.btnTipoMaterial.Location = new System.Drawing.Point(30, 233);
            this.btnTipoMaterial.Name = "btnTipoMaterial";
            this.btnTipoMaterial.Size = new System.Drawing.Size(85, 23);
            this.btnTipoMaterial.TabIndex = 5;
            this.btnTipoMaterial.Text = "Tipo Material";
            this.btnTipoMaterial.UseVisualStyleBackColor = true;
            this.btnTipoMaterial.Click += new System.EventHandler(this.btnTipoMaterial_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(30, 275);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnProveedor.TabIndex = 6;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnOrdenIngreso
            // 
            this.btnOrdenIngreso.Location = new System.Drawing.Point(373, 58);
            this.btnOrdenIngreso.Name = "btnOrdenIngreso";
            this.btnOrdenIngreso.Size = new System.Drawing.Size(149, 62);
            this.btnOrdenIngreso.TabIndex = 9;
            this.btnOrdenIngreso.Text = "ORDEN INGRESO";
            this.btnOrdenIngreso.UseVisualStyleBackColor = true;
            this.btnOrdenIngreso.Click += new System.EventHandler(this.btnOrdenIngreso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CORE:";
            // 
            // btnRequerimientoCompra
            // 
            this.btnRequerimientoCompra.Location = new System.Drawing.Point(190, 158);
            this.btnRequerimientoCompra.Name = "btnRequerimientoCompra";
            this.btnRequerimientoCompra.Size = new System.Drawing.Size(149, 62);
            this.btnRequerimientoCompra.TabIndex = 11;
            this.btnRequerimientoCompra.Text = "REQUERIMIENTO COMPRA";
            this.btnRequerimientoCompra.UseVisualStyleBackColor = true;
            this.btnRequerimientoCompra.Click += new System.EventHandler(this.btnRequerimientoCompra_Click);
            // 
            // btnOrdenSalida
            // 
            this.btnOrdenSalida.Location = new System.Drawing.Point(373, 158);
            this.btnOrdenSalida.Name = "btnOrdenSalida";
            this.btnOrdenSalida.Size = new System.Drawing.Size(149, 62);
            this.btnOrdenSalida.TabIndex = 12;
            this.btnOrdenSalida.Text = "ORDEN SALIDA";
            this.btnOrdenSalida.UseVisualStyleBackColor = true;
            this.btnOrdenSalida.Click += new System.EventHandler(this.btnOrdenSalida_Click);
            // 
            // btnPedidoCompra
            // 
            this.btnPedidoCompra.Location = new System.Drawing.Point(190, 58);
            this.btnPedidoCompra.Name = "btnPedidoCompra";
            this.btnPedidoCompra.Size = new System.Drawing.Size(149, 62);
            this.btnPedidoCompra.TabIndex = 13;
            this.btnPedidoCompra.Text = "PEDIDO DE COMPRAS";
            this.btnPedidoCompra.UseVisualStyleBackColor = true;
            this.btnPedidoCompra.Click += new System.EventHandler(this.btnPedidoCompra_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 317);
            this.Controls.Add(this.btnPedidoCompra);
            this.Controls.Add(this.btnOrdenSalida);
            this.Controls.Add(this.btnRequerimientoCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOrdenIngreso);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.btnTipoMaterial);
            this.Controls.Add(this.btnObra);
            this.Controls.Add(this.btnFormaPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnMarca);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFormaPago;
        private System.Windows.Forms.Button btnObra;
        private System.Windows.Forms.Button btnTipoMaterial;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnOrdenIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRequerimientoCompra;
        private System.Windows.Forms.Button btnOrdenSalida;
        private System.Windows.Forms.Button btnPedidoCompra;
    }
}