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
            this.BT_SALIR = new System.Windows.Forms.Button();
            this.BT_EDITAR = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BT_ELIMINAR = new System.Windows.Forms.Button();
            this.BT_AGREGAR = new System.Windows.Forms.Button();
            this.BT_LISTA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_BUSCAR = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1137, 296);
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
            this.BT_LISTA.Text = "LISTA DE CLIENTES";
            this.BT_LISTA.UseVisualStyleBackColor = true;
            this.BT_LISTA.Click += new System.EventHandler(this.BT_LISTA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "PRECIO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(480, 337);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(292, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 337);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "NOMBRE DEL PRODUCTO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "CODIGO PRODUCTO";
            // 
            // BT_BUSCAR
            // 
            this.BT_BUSCAR.Location = new System.Drawing.Point(27, 390);
            this.BT_BUSCAR.Name = "BT_BUSCAR";
            this.BT_BUSCAR.Size = new System.Drawing.Size(175, 23);
            this.BT_BUSCAR.TabIndex = 26;
            this.BT_BUSCAR.Text = "BUSCAR";
            this.BT_BUSCAR.UseVisualStyleBackColor = true;
            this.BT_BUSCAR.Click += new System.EventHandler(this.BT_BUSCAR_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(804, 337);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(292, 20);
            this.textBox4.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "+";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 421);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.BT_BUSCAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_SALIR);
            this.Controls.Add(this.BT_EDITAR);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BT_ELIMINAR);
            this.Controls.Add(this.BT_AGREGAR);
            this.Controls.Add(this.BT_LISTA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "Producto";
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_BUSCAR;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
    }
}