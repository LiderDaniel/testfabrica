namespace f2
{
    partial class Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            this.BT_SALIR = new System.Windows.Forms.Button();
            this.BT_EDITAR = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BT_ELIMINAR = new System.Windows.Forms.Button();
            this.BT_AGREGAR = new System.Windows.Forms.Button();
            this.BT_LISTA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.texbox_nombre = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4_Cantidad = new System.Windows.Forms.TextBox();
            this.CANTIDAD = new System.Windows.Forms.Label();
            this.mensajecodigo = new System.Windows.Forms.Label();
            this.mensajeproducto = new System.Windows.Forms.Label();
            this.mensajeprecio = new System.Windows.Forms.Label();
            this.mensajecantidad = new System.Windows.Forms.Label();
            this.codproducto = new System.Windows.Forms.Label();
            this.nombremensaje = new System.Windows.Forms.Label();
            this.preciomensaje = new System.Windows.Forms.Label();
            this.cantidadmensaje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_SALIR
            // 
            this.BT_SALIR.Location = new System.Drawing.Point(817, 390);
            this.BT_SALIR.Name = "BT_SALIR";
            this.BT_SALIR.Size = new System.Drawing.Size(100, 23);
            this.BT_SALIR.TabIndex = 23;
            this.BT_SALIR.Text = "SALIR";
            this.BT_SALIR.UseVisualStyleBackColor = true;
            this.BT_SALIR.Click += new System.EventHandler(this.button5_Click);
            // 
            // BT_EDITAR
            // 
            this.BT_EDITAR.Location = new System.Drawing.Point(710, 390);
            this.BT_EDITAR.Name = "BT_EDITAR";
            this.BT_EDITAR.Size = new System.Drawing.Size(75, 23);
            this.BT_EDITAR.TabIndex = 22;
            this.BT_EDITAR.Text = "EDITAR";
            this.BT_EDITAR.UseVisualStyleBackColor = true;
            this.BT_EDITAR.Click += new System.EventHandler(this.BT_EDITAR_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 296);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // BT_ELIMINAR
            // 
            this.BT_ELIMINAR.Location = new System.Drawing.Point(597, 390);
            this.BT_ELIMINAR.Name = "BT_ELIMINAR";
            this.BT_ELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BT_ELIMINAR.TabIndex = 20;
            this.BT_ELIMINAR.Text = "ELIMINAR";
            this.BT_ELIMINAR.UseVisualStyleBackColor = true;
            this.BT_ELIMINAR.Click += new System.EventHandler(this.button3_Click);
            // 
            // BT_AGREGAR
            // 
            this.BT_AGREGAR.Location = new System.Drawing.Point(480, 390);
            this.BT_AGREGAR.Name = "BT_AGREGAR";
            this.BT_AGREGAR.Size = new System.Drawing.Size(75, 23);
            this.BT_AGREGAR.TabIndex = 19;
            this.BT_AGREGAR.Text = "AGREGAR ";
            this.BT_AGREGAR.UseVisualStyleBackColor = true;
            this.BT_AGREGAR.Click += new System.EventHandler(this.BT_AGREGAR_Click);
            // 
            // BT_LISTA
            // 
            this.BT_LISTA.Location = new System.Drawing.Point(221, 390);
            this.BT_LISTA.Name = "BT_LISTA";
            this.BT_LISTA.Size = new System.Drawing.Size(233, 23);
            this.BT_LISTA.TabIndex = 18;
            this.BT_LISTA.Text = "LISTA DE PRODUCTOS";
            this.BT_LISTA.UseVisualStyleBackColor = true;
            this.BT_LISTA.Click += new System.EventHandler(this.BT_LISTA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "PRECIO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Location = new System.Drawing.Point(480, 360);
            this.textBox_Precio.MaxLength = 50;
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(292, 20);
            this.textBox_Precio.TabIndex = 16;
            this.textBox_Precio.Text = "0";
            this.textBox_Precio.TextChanged += new System.EventHandler(this.textBox_Precio_TextChanged);
            this.textBox_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Precio_KeyPress);
            // 
            // texbox_nombre
            // 
            this.texbox_nombre.Location = new System.Drawing.Point(144, 360);
            this.texbox_nombre.MaxLength = 50;
            this.texbox_nombre.Name = "texbox_nombre";
            this.texbox_nombre.Size = new System.Drawing.Size(310, 20);
            this.texbox_nombre.TabIndex = 15;
            this.texbox_nombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.texbox_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texbox_nombre_KeyPress);
            this.texbox_nombre.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 360);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "NOMBRE DEL PRODUCTO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "CODIGO PRODUCTO";
            // 
            // textBox4_Cantidad
            // 
            this.textBox4_Cantidad.Location = new System.Drawing.Point(804, 360);
            this.textBox4_Cantidad.MaxLength = 50;
            this.textBox4_Cantidad.Name = "textBox4_Cantidad";
            this.textBox4_Cantidad.Size = new System.Drawing.Size(292, 20);
            this.textBox4_Cantidad.TabIndex = 27;
            this.textBox4_Cantidad.Text = "0";
            this.textBox4_Cantidad.TextChanged += new System.EventHandler(this.textBox4_Cantidad_TextChanged);
            this.textBox4_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_Cantidad_KeyPress);
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.AutoSize = true;
            this.CANTIDAD.Location = new System.Drawing.Point(801, 334);
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Size = new System.Drawing.Size(62, 13);
            this.CANTIDAD.TabIndex = 28;
            this.CANTIDAD.Text = "CANTIDAD";
            this.CANTIDAD.Click += new System.EventHandler(this.label4_Click);
            // 
            // mensajecodigo
            // 
            this.mensajecodigo.AutoSize = true;
            this.mensajecodigo.Location = new System.Drawing.Point(12, 360);
            this.mensajecodigo.Name = "mensajecodigo";
            this.mensajecodigo.Size = new System.Drawing.Size(0, 13);
            this.mensajecodigo.TabIndex = 29;
            // 
            // mensajeproducto
            // 
            this.mensajeproducto.AutoSize = true;
            this.mensajeproducto.Location = new System.Drawing.Point(141, 360);
            this.mensajeproducto.Name = "mensajeproducto";
            this.mensajeproducto.Size = new System.Drawing.Size(0, 13);
            this.mensajeproducto.TabIndex = 30;
            // 
            // mensajeprecio
            // 
            this.mensajeprecio.AutoSize = true;
            this.mensajeprecio.Location = new System.Drawing.Point(477, 360);
            this.mensajeprecio.Name = "mensajeprecio";
            this.mensajeprecio.Size = new System.Drawing.Size(0, 13);
            this.mensajeprecio.TabIndex = 31;
            // 
            // mensajecantidad
            // 
            this.mensajecantidad.AutoSize = true;
            this.mensajecantidad.Location = new System.Drawing.Point(804, 360);
            this.mensajecantidad.Name = "mensajecantidad";
            this.mensajecantidad.Size = new System.Drawing.Size(0, 13);
            this.mensajecantidad.TabIndex = 32;
            // 
            // codproducto
            // 
            this.codproducto.AutoSize = true;
            this.codproducto.Location = new System.Drawing.Point(9, 360);
            this.codproducto.Name = "codproducto";
            this.codproducto.Size = new System.Drawing.Size(0, 13);
            this.codproducto.TabIndex = 33;
            // 
            // nombremensaje
            // 
            this.nombremensaje.AutoSize = true;
            this.nombremensaje.Location = new System.Drawing.Point(141, 360);
            this.nombremensaje.Name = "nombremensaje";
            this.nombremensaje.Size = new System.Drawing.Size(0, 13);
            this.nombremensaje.TabIndex = 34;
            // 
            // preciomensaje
            // 
            this.preciomensaje.AutoSize = true;
            this.preciomensaje.Location = new System.Drawing.Point(477, 360);
            this.preciomensaje.Name = "preciomensaje";
            this.preciomensaje.Size = new System.Drawing.Size(0, 13);
            this.preciomensaje.TabIndex = 35;
            // 
            // cantidadmensaje
            // 
            this.cantidadmensaje.AutoSize = true;
            this.cantidadmensaje.Location = new System.Drawing.Point(801, 360);
            this.cantidadmensaje.Name = "cantidadmensaje";
            this.cantidadmensaje.Size = new System.Drawing.Size(0, 13);
            this.cantidadmensaje.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "LISTA DE PRODUCTOS";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1139, 421);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cantidadmensaje);
            this.Controls.Add(this.preciomensaje);
            this.Controls.Add(this.nombremensaje);
            this.Controls.Add(this.codproducto);
            this.Controls.Add(this.mensajecantidad);
            this.Controls.Add(this.mensajeprecio);
            this.Controls.Add(this.mensajeproducto);
            this.Controls.Add(this.mensajecodigo);
            this.Controls.Add(this.CANTIDAD);
            this.Controls.Add(this.textBox4_Cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_SALIR);
            this.Controls.Add(this.BT_EDITAR);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BT_ELIMINAR);
            this.Controls.Add(this.BT_AGREGAR);
            this.Controls.Add(this.BT_LISTA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Precio);
            this.Controls.Add(this.texbox_nombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_SALIR;
        private System.Windows.Forms.Button BT_EDITAR;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BT_ELIMINAR;
        private System.Windows.Forms.Button BT_AGREGAR;
        private System.Windows.Forms.Button BT_LISTA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.TextBox texbox_nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4_Cantidad;
        private System.Windows.Forms.Label CANTIDAD;
        private System.Windows.Forms.Label mensajecodigo;
        private System.Windows.Forms.Label mensajeproducto;
        private System.Windows.Forms.Label mensajeprecio;
        private System.Windows.Forms.Label mensajecantidad;
        private System.Windows.Forms.Label codproducto;
        private System.Windows.Forms.Label nombremensaje;
        private System.Windows.Forms.Label preciomensaje;
        private System.Windows.Forms.Label cantidadmensaje;
        private System.Windows.Forms.Label label4;
    }
}