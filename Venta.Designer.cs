namespace f2
{
    partial class Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.datagridventa = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.textBox_codproducto = new System.Windows.Forms.TextBox();
            this.textBox_codventa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nombreproducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_codcliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_precioventa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gc_cliente = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridventa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(817, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "SALIR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(710, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "EDITAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // datagridventa
            // 
            this.datagridventa.BackgroundColor = System.Drawing.SystemColors.Info;
            this.datagridventa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagridventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridventa.Location = new System.Drawing.Point(272, 27);
            this.datagridventa.Name = "datagridventa";
            this.datagridventa.Size = new System.Drawing.Size(642, 296);
            this.datagridventa.TabIndex = 21;
            this.datagridventa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridventa_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "AGREGAR ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "LISTA DE VENTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "CANTIDAD";
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Location = new System.Drawing.Point(431, 364);
            this.textBox_cantidad.MaxLength = 1000;
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(192, 20);
            this.textBox_cantidad.TabIndex = 16;
            this.textBox_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cantidad_KeyPress);
            // 
            // textBox_codproducto
            // 
            this.textBox_codproducto.Location = new System.Drawing.Point(181, 364);
            this.textBox_codproducto.MaxLength = 100;
            this.textBox_codproducto.Name = "textBox_codproducto";
            this.textBox_codproducto.Size = new System.Drawing.Size(233, 20);
            this.textBox_codproducto.TabIndex = 15;
            this.textBox_codproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_codproducto_KeyPress);
            // 
            // textBox_codventa
            // 
            this.textBox_codventa.Location = new System.Drawing.Point(10, 364);
            this.textBox_codventa.MaxLength = 100;
            this.textBox_codventa.Name = "textBox_codventa";
            this.textBox_codventa.Size = new System.Drawing.Size(155, 20);
            this.textBox_codventa.TabIndex = 14;
            this.textBox_codventa.TextChanged += new System.EventHandler(this.textBox_codventa_TextChanged);
            this.textBox_codventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_codventa_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "CODIGO PRODUCTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "CODIGO VENTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "NOMBRE PRODUCTO";
            // 
            // textBox_nombreproducto
            // 
            this.textBox_nombreproducto.Location = new System.Drawing.Point(651, 364);
            this.textBox_nombreproducto.MaxLength = 50;
            this.textBox_nombreproducto.Name = "textBox_nombreproducto";
            this.textBox_nombreproducto.Size = new System.Drawing.Size(192, 20);
            this.textBox_nombreproducto.TabIndex = 25;
            this.textBox_nombreproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nombreproducto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(850, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "COD CLIENTE";
            // 
            // textBox_codcliente
            // 
            this.textBox_codcliente.Location = new System.Drawing.Point(853, 364);
            this.textBox_codcliente.MaxLength = 100;
            this.textBox_codcliente.Name = "textBox_codcliente";
            this.textBox_codcliente.Size = new System.Drawing.Size(115, 20);
            this.textBox_codcliente.TabIndex = 27;
            this.textBox_codcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_codcliente_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(999, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "PRECIO VENTA";
            // 
            // textBox_precioventa
            // 
            this.textBox_precioventa.Location = new System.Drawing.Point(1002, 364);
            this.textBox_precioventa.MaxLength = 100;
            this.textBox_precioventa.Name = "textBox_precioventa";
            this.textBox_precioventa.Size = new System.Drawing.Size(138, 20);
            this.textBox_precioventa.TabIndex = 29;
            this.textBox_precioventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_precioventa_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "LISTA DE VENTA";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // gc_cliente
            // 
            this.gc_cliente.BackgroundColor = System.Drawing.SystemColors.Info;
            this.gc_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gc_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gc_cliente.Location = new System.Drawing.Point(181, 455);
            this.gc_cliente.Name = "gc_cliente";
            this.gc_cliente.Size = new System.Drawing.Size(342, 296);
            this.gc_cliente.TabIndex = 39;
            this.gc_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gc_cliente_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(181, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "LISTA CLIENTES";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(574, 455);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 296);
            this.dataGridView2.TabIndex = 41;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(574, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "LISTA PRODUCTO";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(931, 312);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 43;
            this.button6.Text = "EXPORTAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1044, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "prueba";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 773);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gc_cliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_precioventa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_codcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_nombreproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.datagridventa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_cantidad);
            this.Controls.Add(this.textBox_codproducto);
            this.Controls.Add(this.textBox_codventa);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridventa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView datagridventa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_cantidad;
        private System.Windows.Forms.TextBox textBox_codproducto;
        private System.Windows.Forms.TextBox textBox_codventa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nombreproducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_codcliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_precioventa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gc_cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}