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
            listarventa();
            listarcliente();
            listarproducto();
        }
      public void ExportarDatos(DataGridView datalistado)
        {
         Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();
            exportarexcel.Application.Workbooks.Add(true);

            int indicecolumna = 0;
            foreach (DataGridViewColumn columna  in datalistado.Columns)
            {
                indicecolumna++;

                exportarexcel.Cells[1, indicecolumna] = columna.Name;
            }

            int indicefila = 0;

            foreach (DataGridViewRow fila in datalistado.Rows)
            {
                indicefila++;
                indicecolumna = 0;

                foreach (DataGridViewColumn columna in datalistado.Columns)
                {
                    indicecolumna++;
                    exportarexcel.Cells[indicefila + 1, indicecolumna] = fila.Cells[columna.Name].Value;
                }

            }
            exportarexcel.Visible = true;
        }
        public void listarcliente()
        {
            gc_cliente.DataSource = null;
            gc_cliente.DataSource = capaNegociosVenta.SP_LISTAR_CLIENTES();
        }
        private void listarproducto()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = capaNegociosVenta.SP_LISTAR_PRODUCTO();
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
            //
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

            //nombremensaje.Text = " ";

            //preciomensaje.Text = " ";

            //cantidadmensaje.Text = " ";


          

            string datos = capaNegociosVenta.SP_INSERT_VENTA(PI_COD_PRODUCTO, PI_CANTIDAD, PI_NOMBRE_PRODUCTO, PI_COD_CLIENTE);

            if (datos.Equals("OK"))
            {
                MessageBox.Show("Se agregaraon correctamente los cambios: " + textBox_codventa.Text + " con Exito ");
                limpiar();
                listarventa();
            }
            else
            {
                MessageBox.Show(datos);
                listarventa();
            }

          


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox_codventa.Text.Equals(""))
            {

                MessageBox.Show("Nose Cargo el Campo Cod Venta ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string mensaje = capaNegociosVenta.SP_DELETE_VENTA(Convert.ToInt32(textBox_codventa.Text));

            if (mensaje.Equals("OK"))

            {
                MessageBox.Show(" La Venta con Codigo : " + textBox_codventa.Text + " Fue Eliminada");
                limpiar();
                listarventa();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
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



            string mensaje = capaNegociosVenta.SP_UPDATE_VENTA(PI_COD_PRODUCTO, PI_CANTIDAD, PI_NOMBRE_PRODUCTO, PI_COD_CLIENTE, PI_CODIGO_VENTA, V_PRECIO);
            if (mensaje.Equals("OK"))
            {
                MessageBox.Show("La Edicion fue Realizada el Cliente con codigo: " + textBox_codventa.Text + " con Exito ");
                limpiar();
                listarventa();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
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

            bool valida = ValidacionesLogicas.sololetras(e);

            if (!valida)

                errorP.SetError(textBox_nombreproducto, "Solo se acepta letras");
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

        private void Venta_Load(object sender, EventArgs e)
        {

        }
        //limpiar 

        private void limpiar()
        {
            textBox_codventa.Clear();
            textBox_codproducto.Clear();
            textBox_cantidad.Clear();
            textBox_precioventa.Clear();
            textBox_codcliente.Clear();
            textBox_nombreproducto.Clear();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void gc_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ExportarDatos(datagridventa);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // string mensaje = capaNegociosVenta.(Convert.ToInt32(textBox_codventa.Text));
        
        }
    }
    }

