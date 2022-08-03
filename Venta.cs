using System;
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
    public partial class Venta : Form
    {

        businessLayer capaNegociosVenta = new businessLayer();


        private string cadenaCone = "User Id=AAA111;Password=BBB222;Data Source=CCC333;Connection Timeout=60; Pooling=false";
        public string cadenaDeConeccion { get { return this.cadenaCone; } }

        public void agregarConexiones(int posicion, string valorA, string valorB)
        {
            capaNegociosVenta.agregarConexion(posicion, valorA, valorB);
        }

        /// <summary>
        /// recibe los parametros para poder iniciarse
        /// con los datos de conexion a la base da datos
        /// </summary>
        /// <param name="cadenaDeConexion"></param>
        public Venta(businessLayer capaNegociosPadre)
        {
            InitializeComponent();
            this.capaNegociosVenta = capaNegociosPadre;
        }
      

       private void listarventa()
        {
            datagridventa.DataSource = null;
            datagridventa.DataSource = capaNegociosVenta.SP_LISTAR_VENTA();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listarventa();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close ();   
        }

        private void datagridventa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_codproducto.Text.Equals(""))
            {

                
                MessageBox.Show("Nose Cargo el Campo cod producto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int PI_COD_PRODUCTO = Convert.ToInt32(textBox_codproducto.Text);

            if (textBox_cantidad.Text.Equals(""))
            {


                MessageBox.Show("Nose Cargo el Campo Cantidad ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int PI_CANTIDAD = Convert.ToInt32(textBox_cantidad.Text);


            if (textBox_cantidad.Text.Equals(""))
            {

            
                MessageBox.Show("Nose Cargo el Campo Nombre Producto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string PI_NOMBRE_PRODUCTO = textBox_nombreproducto.Text;
            if (textBox_cantidad.Text.Equals(""))
            {

               

                MessageBox.Show("Nose Cargo el Campo Cod Cliente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int PI_COD_CLIENTE = Convert.ToInt32(textBox_codcliente.Text);

            //nombremensaje.Text = " ";

            //preciomensaje.Text = " ";

            //cantidadmensaje.Text = " ";


            var datos = capaNegociosVenta.SP_INSERT_VENTA(PI_COD_PRODUCTO, PI_CANTIDAD, PI_NOMBRE_PRODUCTO, PI_COD_CLIENTE);

                MessageBox.Show("Los Datos ingresados fueron guardados correctamente");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_codventa.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Cod Venta ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            capaNegociosVenta.SP_DELETE_VENTA(Convert.ToInt32(textBox_codventa.Text));

            MessageBox.Show(" La Venta con Codigo : " + textBox_codventa.Text + " Fue Eliminada");
        }

        private void button4_Click(object sender, EventArgs e)
        {



            if (textBox_codproducto.Text.Equals(""))
            {


                MessageBox.Show("Nose Cargo el Campo cod producto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int PI_COD_PRODUCTO = Convert.ToInt32(textBox_codproducto.Text);




            if (textBox_cantidad.Text.Equals(""))
            {


                MessageBox.Show("Nose Cargo el Campo Cantidad ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int PI_CANTIDAD = Convert.ToInt32(textBox_cantidad.Text);





            if (textBox_nombreproducto.Text.Equals(""))
            {


                MessageBox.Show("Nose Cargo el Campo Nombre Producto ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string PI_NOMBRE_PRODUCTO = textBox_nombreproducto.Text;




            if (textBox_codcliente.Text.Equals(""))
            {



                MessageBox.Show("Nose Cargo el Campo Cod Cliente ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int PI_COD_CLIENTE = Convert.ToInt32(textBox_codcliente.Text);


            
            if (textBox_codventa.Text.Equals(""))

            {
                MessageBox.Show("Nose Cargo el Campo Cod Venta ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int PI_CODIGO_VENTA = Convert.ToInt32(textBox_codventa.Text);
           if (textBox_precioventa.Text.Equals(""))

            {
                MessageBox.Show("Nose Cargo el Campo Precio Venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
         }

            int V_PRECIO = Convert.ToInt32(textBox_precioventa.Text);


            capaNegociosVenta.SP_UPDATE_VENTA(PI_COD_PRODUCTO, PI_CANTIDAD, PI_NOMBRE_PRODUCTO, PI_COD_CLIENTE, PI_CODIGO_VENTA, V_PRECIO);
            MessageBox.Show("La Edicion fue Realizada el Cliente con codigo: " + textBox_codventa.Text + " con Exito ");
        }

        ErrorProvider errorP = new ErrorProvider();
        private void textBox_codventa_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox_codventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidacionesLogicas.soloNumeros(e);
            if (!valida)
                errorP.SetError(textBox_codventa, "Solo se acepta numeros");
            else
                errorP.Clear();
        }

        private void textBox_codproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidacionesLogicas.soloNumeros(e);
            if (!valida)
                errorP.SetError(textBox_codproducto, "Solo se acepta numeros");
            else
                errorP.Clear();
        }

        private void textBox_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidacionesLogicas.soloNumeros(e);
            if (!valida)
                errorP.SetError(textBox_cantidad, "Solo se acepta numeros");
            else
                errorP.Clear();
        }

        private void textBox_nombreproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ValidacionesLogicas.textVacios(textBox_nombreproducto))
                errorP.SetError(textBox_nombreproducto, "No puede dejar vacio");
            else

                errorP.Clear();
        }

        private void textBox_codcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidacionesLogicas.soloNumeros(e);
            if (!valida)
                errorP.SetError(textBox_codcliente, "Solo se acepta numeros");
            else
                errorP.Clear();
        }

        private void textBox_precioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidacionesLogicas.soloNumeros(e);
            if (!valida)
                errorP.SetError(textBox_precioventa, "Solo se acepta numeros");
            else
                errorP.Clear();
        }
    }
    }

