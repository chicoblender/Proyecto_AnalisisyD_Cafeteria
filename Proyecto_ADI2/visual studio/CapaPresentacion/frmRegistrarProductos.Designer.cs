namespace CapaPresentacion
{
    partial class frmRegistrarProductos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnSalirProd = new System.Windows.Forms.Button();
            this.btnVerListadoProd = new System.Windows.Forms.Button();
            this.btnCancelarProd = new System.Windows.Forms.Button();
            this.btnRegistrarProd = new System.Windows.Forms.Button();
            this.btnNuevoProd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRAR PRODUCTOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Precio:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(310, 27);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(310, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(310, 136);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 9;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(310, 93);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 12;
            // 
            // btnSalirProd
            // 
            this.btnSalirProd.Location = new System.Drawing.Point(390, 275);
            this.btnSalirProd.Name = "btnSalirProd";
            this.btnSalirProd.Size = new System.Drawing.Size(75, 23);
            this.btnSalirProd.TabIndex = 6;
            this.btnSalirProd.Text = "Salir";
            this.btnSalirProd.UseVisualStyleBackColor = true;
            this.btnSalirProd.Click += new System.EventHandler(this.btnSalirProd_Click);
            // 
            // btnVerListadoProd
            // 
            this.btnVerListadoProd.Location = new System.Drawing.Point(291, 275);
            this.btnVerListadoProd.Name = "btnVerListadoProd";
            this.btnVerListadoProd.Size = new System.Drawing.Size(75, 23);
            this.btnVerListadoProd.TabIndex = 5;
            this.btnVerListadoProd.Text = "Ver Listado";
            this.btnVerListadoProd.UseVisualStyleBackColor = true;
            this.btnVerListadoProd.Click += new System.EventHandler(this.btnVerListadoProd_Click);
            // 
            // btnCancelarProd
            // 
            this.btnCancelarProd.Location = new System.Drawing.Point(187, 275);
            this.btnCancelarProd.Name = "btnCancelarProd";
            this.btnCancelarProd.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProd.TabIndex = 4;
            this.btnCancelarProd.Text = "Cancelar";
            this.btnCancelarProd.UseVisualStyleBackColor = true;
            this.btnCancelarProd.Click += new System.EventHandler(this.btnCancelarProd_Click);
            // 
            // btnRegistrarProd
            // 
            this.btnRegistrarProd.Location = new System.Drawing.Point(95, 275);
            this.btnRegistrarProd.Name = "btnRegistrarProd";
            this.btnRegistrarProd.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarProd.TabIndex = 3;
            this.btnRegistrarProd.Text = "Registrar";
            this.btnRegistrarProd.UseVisualStyleBackColor = true;
            this.btnRegistrarProd.Click += new System.EventHandler(this.btnRegistrarProd_Click);
            // 
            // btnNuevoProd
            // 
            this.btnNuevoProd.Location = new System.Drawing.Point(6, 275);
            this.btnNuevoProd.Name = "btnNuevoProd";
            this.btnNuevoProd.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoProd.TabIndex = 2;
            this.btnNuevoProd.Text = "Nuevo";
            this.btnNuevoProd.UseVisualStyleBackColor = true;
            this.btnNuevoProd.Click += new System.EventHandler(this.btnNuevoProd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picImg);
            this.groupBox1.Controls.Add(this.btnSeleccionarImagen);
            this.groupBox1.Controls.Add(this.btnNuevoProd);
            this.groupBox1.Controls.Add(this.btnRegistrarProd);
            this.groupBox1.Controls.Add(this.btnCancelarProd);
            this.groupBox1.Controls.Add(this.btnVerListadoProd);
            this.groupBox1.Controls.Add(this.btnSalirProd);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(15, 36);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(155, 137);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 17;
            this.picImg.TabStop = false;
            this.picImg.Click += new System.EventHandler(this.picImg_Click);
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(29, 188);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(127, 23);
            this.btnSeleccionarImagen.TabIndex = 16;
            this.btnSeleccionarImagen.Text = "Seleccionar Imagen";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // frmRegistrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrarProductos";
            this.Text = "Registrar productos";
            this.Load += new System.EventHandler(this.frmRegistrarProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnSalirProd;
        private System.Windows.Forms.Button btnVerListadoProd;
        private System.Windows.Forms.Button btnCancelarProd;
        private System.Windows.Forms.Button btnRegistrarProd;
        private System.Windows.Forms.Button btnNuevoProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.PictureBox picImg;
    }
}