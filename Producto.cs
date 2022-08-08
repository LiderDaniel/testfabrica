using System;
using Oracle.DataAccess.Client;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f2
{
    public partial class Producto : Form
    {

        businessLayer capaNegociosProducto = new businessLayer();


        private string cadenaCone = "User Id=AAA111;Password=BBB222;Data Source=CCC333;Connection Timeout=60; Pooling=false";
        public string cadenaDeConeccion { get { return this.cadenaCone; } }

        public void agregarConexiones(int posicion, string valorA, string valorB)
        {
            capaNegociosProducto.agregarConexion(posicion, valorA, valorB);
        }

        /// <summary>
        /// recibe los parametros para poder iniciarse
        /// con los datos de conexion a la base da datos
        /// </summary>
        /// <param name="cadenaDeConexion"></param>
        public Producto(businessLayer capaNegociosPadre)
        {
            InitializeComponent();
            this.capaNegociosProducto = capaNegociosPadre;
             listarproducto();
        }
        //public Producto()
        //{
        //    InitializeComponent();
        //}

        private void Producto_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {



            if (textBox1.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Codigo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }




            string mensaje = capaNegociosProducto.SP_DELETE_PRODUCTO(Convert.ToInt32(textBox1.Text));

            if( mensaje.Equals("OK"))
            {

           
            //capaNegociosProducto.SP_DELETE_PRODUCTO(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("El cliente con numero de id : " + textBox1.Text + " Fue Eliminado ");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BT_BUSCAR_Click(object sender, EventArgs e)
        {

        }
        private void listarproducto()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = capaNegociosProducto.SP_LISTAR_PRODUCTO();
        }

        private void BT_LISTA_Click(object sender, EventArgs e)
        {
            listarproducto();   
        }

        private void BT_AGREGAR_Click(object sender, EventArgs e)
        {
            //  int CODIGO_PRODUCTO = Convert.ToInt32(texbox_nombre.Text);


            if (texbox_nombre.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Nombre Producto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            string PI_PRODUCTO = texbox_nombre.Text;

            if (textBox_Precio.Text.Equals("0"))
            {

                MessageBox.Show("Nose Cargo el Campo Precio ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            double PI_PRECIO = Convert.ToDouble(textBox_Precio.Text);

            if (textBox4_Cantidad.Text.Equals("0"))
            {

                MessageBox.Show("Nose Cargo el Campo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int PI_CANTIDAD = Convert.ToInt32(textBox4_Cantidad.Text);
           
    
               

                var datos = capaNegociosProducto.SP_INSERT_PRODUCTO(PI_PRODUCTO, PI_PRECIO, PI_CANTIDAD);

                MessageBox.Show("Los Datos ingresados fueron guardados correctamente");


                listarproducto();
                limpiar();
            


        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (ValidacionesLogicas.textVacios(texbox_nombre))
                errorP.SetError(texbox_nombre, "No puede dejar vacio");
            else

                errorP.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BT_EDITAR_Click(object sender, EventArgs e)
        {

            if (texbox_nombre.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Nombre ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            string PI_PRODUCTO = texbox_nombre.Text;

            if (textBox_Precio.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Precio ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            float PI_PRECIO = float.Parse(textBox_Precio.Text);

            if (textBox4_Cantidad.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Cantidad ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int PI_CANTIDAD = Convert.ToInt32(textBox4_Cantidad.Text);


            if (textBox1.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Codigo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int PI_CODIGO_PRODCUTO = Convert.ToInt32(textBox1.Text);


      
            
               string mensaje = capaNegociosProducto.SP_UPDATE_PRODUCTO(PI_PRODUCTO, PI_PRECIO, PI_CANTIDAD, PI_CODIGO_PRODCUTO);

            if (mensaje.Equals("OK"))
            {

                MessageBox.Show("La Edicion fue Realizada el Cliente con codigo: " + textBox1.Text + " con Exito ");
                listarproducto();
                limpiar();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
            

           

        }
        ErrorProvider errorP = new ErrorProvider();
        private void textBox_Precio_TextChanged(object sender, EventArgs e)
        {
           
            if (ValidacionesLogicas.textVacios(textBox_Precio))
                errorP.SetError(textBox_Precio, "No puede dejar vacio");
            else

                errorP.Clear();
        }

        private void textBox4_Cantidad_TextChanged(object sender, EventArgs e)
        {
            if (ValidacionesLogicas.textVacios(textBox4_Cantidad))
                errorP.SetError(textBox4_Cantidad, "No puede dejar vacio");
            else

                errorP.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidacionesLogicas.soloNumeros(e);
            if (!valida)
                errorP.SetError(textBox1, "Solo se acepta numeros");
            else
                errorP.Clear();
        }

        private void textBox4_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidacionesLogicas.soloNumeros(e);
            if (!valida)
                errorP.SetError(textBox4_Cantidad, "Solo se acepta numeros");
            else
                errorP.Clear();
        }

        private void textBox_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidacionesLogicas.soloNumeros(e);
            if (!valida)
                errorP.SetError(textBox_Precio, "Solo se acepta numeros");
            else
                errorP.Clear();

        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void texbox_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidacionesLogicas.sololetras(e);

            if (!valida)

                errorP.SetError(texbox_nombre, "Solo se acepta letras");
            else
                errorP.Clear();
        }

        public void limpiar()
        {

            textBox1.Clear();
            texbox_nombre.Clear();
            textBox_Precio.Clear();
            textBox4_Cantidad.Clear();
        }
    }
}
