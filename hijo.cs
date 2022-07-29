using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace f2
{
    
    public partial class hijo : Form
    {
        /// <summary>
        /// la capa de negocios
        /// </summary>
        businessLayer capaNegociosHijo = new businessLayer();

        public void agregarConexiones(int posicion, string valorA, string valorB)
        {
            capaNegociosHijo.agregarConexion(posicion, valorA, valorB);
        }

        /// <summary>
        /// recibe los parametros para poder iniciarse
        /// con los datos de conexion a la base da datos
        /// </summary>
        /// <param name="cadenaDeConexion"></param>
        public hijo(businessLayer capaNegociosPadre)
        {
            InitializeComponent();
            this.capaNegociosHijo = capaNegociosPadre;
        }
        public void cargatabla()
        {
            gc_cliente.DataSource = null;
            gc_cliente.DataSource = capaNegociosHijo.SP_LISTAR_CLIENTES();
        }
        private void hijo_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargatabla();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}