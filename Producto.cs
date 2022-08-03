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
           


            if (String.IsNullOrEmpty(textBox1.Text))
            {
                codproducto.Text = ("Nose Cargo el Campo Codigo");

            }
            else
            {
                codproducto.Text = (" ");

                capaNegociosProducto.SP_DELETE_PRODUCTO(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("El cliente con numero de id : " + textBox1.Text + " Fue Eliminado ");
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

            string PI_PRODUCTO = texbox_nombre.Text;

            if (textBox_Precio.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Precio ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            double PI_PRECIO = Convert.ToDouble(textBox_Precio.Text);

            if (textBox4_Cantidad.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            int PI_CANTIDAD = Convert.ToInt32(textBox4_Cantidad.Text);
            if (textBox1.Text.Length > 50)
            {
                MessageBox.Show("El Codigo del Producto no Debe de Tener mas de 50 Carateres");
            }

            if (texbox_nombre.Text.Length > 50)
            {
                MessageBox.Show("El Nombre del Producto no Debe de Tener mas de 50 Carateres");
            }
            if (textBox_Precio.Text.Length > 50)
            {
                MessageBox.Show("El Precio del Producto no Debe de Tener mas de 50 Carateres");
            }
            if (textBox4_Cantidad.Text.Length > 50)
            {
                MessageBox.Show("La Cantidad del Producto no Debe de Tener mas de 50 Carateres");
            }



            if (String.IsNullOrEmpty(texbox_nombre.Text))
            {
                nombremensaje.Text = ("Nose Cargo el Campo Producto");

            }


            else
                if (String.IsNullOrEmpty(textBox_Precio.Text))
            {
                preciomensaje.Text = ("Nose Cargo el Campo Precio");

            }

            else
                 if (String.IsNullOrEmpty(textBox4_Cantidad.Text))
            {
                cantidadmensaje.Text = ("Nose Cargo el Campo Cantidad");

            }
            else
            {
                nombremensaje.Text = " ";

                preciomensaje.Text = " ";

                cantidadmensaje.Text = " ";


                var datos = capaNegociosProducto.SP_INSERT_PRODUCTO(PI_PRODUCTO, PI_PRECIO, PI_CANTIDAD);

                MessageBox.Show("Los Datos ingresados fueron guardados correctamente");
            }






            

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

            string PI_PRODUCTO = texbox_nombre.Text;

            float PI_PRECIO = float.Parse(textBox_Precio.Text);


            int PI_CANTIDAD = Convert.ToInt32(textBox4_Cantidad.Text);

            int PI_CODIGO_PRODCUTO = Convert.ToInt32(textBox1.Text);


            if (String.IsNullOrEmpty(texbox_nombre.Text))
            {

                nombremensaje.Text = ("Debe de ingresar el producto para editar ");

            }

            if (string.IsNullOrEmpty(textBox_Precio.Text))
            {

                preciomensaje.Text = ("Debe de ingresar el precio para editar");

            }
            else

          if (string.IsNullOrEmpty(textBox4_Cantidad.Text))
            {

                textBox4_Cantidad.Text = ("Debe Ingresar un cantidadd para  Poder  Editar");
            }
            else
            {
                nombremensaje.Text = " ";

                preciomensaje.Text = " ";

                cantidadmensaje.Text = " ";

                capaNegociosProducto.SP_UPDATE_PRODUCTO(PI_PRODUCTO, PI_PRECIO, PI_CANTIDAD, PI_CODIGO_PRODCUTO);

                MessageBox.Show("La Edicion fue Realizada el Cliente con codigo: " + textBox1.Text + " con Exito ");
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

        }
    }
}
