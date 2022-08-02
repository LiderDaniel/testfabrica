using Oracle.DataAccess.Client;
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


        private string cadenaCone = "User Id=AAA111;Password=BBB222;Data Source=CCC333;Connection Timeout=60; Pooling=false";
        public string cadenaDeConeccion { get { return this.cadenaCone; } }

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

        private void gc_cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Microsoft.VisualBasic.Interaction.InputBox("Ingres los nuevo campos Codigo Cliente, ", "Nombre del cliente", "Apellido del cliente");

        }

        private void button2_Click(object sender, EventArgs e) //BOTON GUARDAR
        {


            string Nombre = textBox2.Text;

            string Apellido = textBox3.Text;

            //insert  ala tabla

            var datos = capaNegociosHijo.SP_INSERT_CLIENTES(Nombre, Apellido);
        }

        private void button3_Click(object sender, EventArgs e)
        {



            capaNegociosHijo.SP_DELETE_CLIENTES(Convert.ToDouble(textBox1.Text));


        }

       
        private void button4_Click(object sender, EventArgs e)//METODO PARA REALIZAR EL UPDATE
        {
          


            string PI_NOMBRE = textBox2.Text;

            string PI_APELLIDO = textBox3.Text;

            int PI_CODIGO_CLIENTE = Convert.ToInt32(textBox1.Text);

            capaNegociosHijo.SP_UPDATE_CLIENTES(PI_NOMBRE, PI_APELLIDO,PI_CODIGO_CLIENTE);






        }
        ErrorProvider errorP = new ErrorProvider();
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          bool valida =   ValidacionesLogicas.soloNumeros(e);
            if (!valida)
                errorP.SetError(textBox1, "Solo se acepta numeros");
            else
                errorP.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (ValidacionesLogicas.textVacios(textBox2))
                errorP.SetError(textBox2, "No puede dejar vacio");
            else

                errorP.Clear();

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

        }

        private void hijo_Leave(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (ValidacionesLogicas.textVacios(textBox3))
                errorP.SetError(textBox3, "No puede dejar vacio");
            else

                errorP.Clear();
        }
    }
}