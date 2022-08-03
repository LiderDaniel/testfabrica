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
            if (textBox2.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Nombre ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            string Nombre = textBox2.Text;

            if (textBox3.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Apellido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            string Apellido = textBox3.Text;


            if (textBox3.Text.Length >= 50)
            {
                MessageBox.Show("El Apellido debe de Tener Menos de 50 Carateres");
                return;
            }

            if (textBox2.Text.Length >= 50)
            {
                MessageBox.Show("El Nombre debe de Tener Menos de 50 Carateres");

                return;
            }

                if (String.IsNullOrEmpty(textBox2.Text)  )
            {
                label4.Text = ("Nose Cargo el campo Nombre");

            }
            else
                if (string.IsNullOrEmpty(textBox3.Text))
            {
                apellidomensaje.Text = ("Nose Cargo el campo Apellido");
            }

            else

            {
                //insert  ala tabla

                label4.Text = (" ");
                apellidomensaje.Text = (" ");

                var datos = capaNegociosHijo.SP_INSERT_CLIENTES(Nombre, Apellido);
                MessageBox.Show("Los Datos Ingresados Fueron Guardados Correctamente");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Codigo Cliente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                codigomensaje.Text = ("Nose Cargo el Campo Codigo");

            }
            else
            {
                codigomensaje.Text = (" ");

                capaNegociosHijo.SP_DELETE_CLIENTES(Convert.ToDouble(textBox1.Text));
                MessageBox.Show("El cliente con numero de id : " + textBox1.Text + " Fue Eliminado ");
            }

        }

       
        private void button4_Click(object sender, EventArgs e)//METODO PARA REALIZAR EL UPDATE
        {


            if (textBox2.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Nombre ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            string PI_NOMBRE = textBox2.Text;



            if (textBox3.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Nombre ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            string PI_APELLIDO = textBox3.Text;



            if (textBox1.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Codigo Cliente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int PI_CODIGO_CLIENTE = Convert.ToInt32(textBox1.Text);

            if(textBox3.Text.Length >= 50)
            {
                MessageBox.Show("El Apellido debe de Tener Menos de 50 Carateres");
                return;
            }

            if (textBox2.Text.Length >= 50)
            {
                MessageBox.Show("El Nombre debe de Tener Menos de 50 Carateres");

                return;
            }
                if (String.IsNullOrEmpty(textBox2.Text))
            {
               
                label4.Text = ("Debe de ingresar el nombre para editar ");

            }

              if (string.IsNullOrEmpty(textBox3.Text))
            {

                apellidomensaje.Text = ("Debe de ingresar el apellido para editar");

            }
            else

            if (string.IsNullOrEmpty(textBox1.Text))
            {

                codigomensaje.Text = ("Debe Ingresar un Codigo para  Poder  Editar");
            }

            else

            {
                //insert  ala tabla
               
                    label4.Text = (" ");
                    apellidomensaje.Text = (" ");

                    capaNegociosHijo.SP_UPDATE_CLIENTES(PI_NOMBRE, PI_APELLIDO, PI_CODIGO_CLIENTE);

                    MessageBox.Show("La Edicion fue Realizada el Cliente con codigo : " + textBox1.Text + " con Exito ");


            

            }

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}