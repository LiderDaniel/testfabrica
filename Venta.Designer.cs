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
            ((System.ComponentModel.ISupportInitialize)(this.datagridventa)).BeginInit();
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
            this.datagridventa.Location = new System.Drawing.Point(12, 12);
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
            this.label3.Location = new System.Drawing.Point(430, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "CANTIDAD";
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Location = new System.Drawing.Point(433, 337);
            this.textBox_cantidad.MaxLength = 1000;
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(192, 20);
            this.textBox_cantidad.TabIndex = 16;
            this.textBox_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cantidad_KeyPress);
            // 
            // textBox_codproducto
            // 
            this.textBox_codproducto.Location = new System.Drawing.Point(183, 337);
            this.textBox_codproducto.MaxLength = 100;
            this.textBox_codproducto.Name = "textBox_codproducto";
            this.textBox_codproducto.Size = new System.Drawing.Size(233, 20);
            this.textBox_codproducto.TabIndex = 15;
            this.textBox_codproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_codproducto_KeyPress);
            // 
            // textBox_codventa
            // 
            this.textBox_codventa.Location = new System.Drawing.Point(12, 337);
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
            this.label2.Location = new System.Drawing.Point(180, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "CODIGO PRODUCTO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "CODIGO VENTA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "NOMBRE PRODUCTO";
            // 
            // textBox_nombreproducto
            // 
            this.textBox_nombreproducto.Location = new System.Drawing.Point(653, 337);
            this.textBox_nombreproducto.MaxLength = 50;
            this.textBox_nombreproducto.Name = "textBox_nombreproducto";
            this.textBox_nombreproducto.Size = new System.Drawing.Size(192, 20);
            this.textBox_nombreproducto.TabIndex = 25;
            this.textBox_nombreproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nombreproducto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(852, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "COD CLIENTE";
            // 
            // textBox_codcliente
            // 
            this.textBox_codcliente.Location = new System.Drawing.Point(855, 337);
            this.textBox_codcliente.MaxLength = 100;
            this.textBox_codcliente.Name = "textBox_codcliente";
            this.textBox_codcliente.Size = new System.Drawing.Size(115, 20);
            this.textBox_codcliente.TabIndex = 27;
            this.textBox_codcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_codcliente_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1001, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "PRECIO VENTA";
            // 
            // textBox_precioventa
            // 
            this.textBox_precioventa.Location = new System.Drawing.Point(1004, 337);
            this.textBox_precioventa.MaxLength = 100;
            this.textBox_precioventa.Name = "textBox_precioventa";
            this.textBox_precioventa.Size = new System.Drawing.Size(138, 20);
            this.textBox_precioventa.TabIndex = 29;
            this.textBox_precioventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_precioventa_KeyPress);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1166, 421);
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
            ((System.ComponentModel.ISupportInitialize)(this.datagridventa)).EndInit();
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
    }
}