using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;
using System.Data.OleDb;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;




namespace f2
{
    /// <summary>
    /// aqui va todo el codigo del developer
    /// que relaciona formulario con el mundo exterior
    /// </summary>
    public class businessLayer
    {
        public readonly string[] ticketSb = new string[2];
        public string[] idInstanciaSb = new string[2];
        private string[] noise = new string[2];
        private string[] ticketResult = new string[2];

        #region interno
        //COMENTADO AL AGREGAR LA NUEVA FORMA DE CONECTAR EN LA REGION STANDAR
        //public businessLayer() { }
        public void agregarConexion(int posicion, string i_ticketSb, string i_idInstanacia)
        {
            ticketSb[posicion] = i_ticketSb;
            idInstanciaSb[posicion] = i_idInstanacia;
        }

        /// <summary>
        /// generar token de conexion sl SB
        /// </summary>
        private void generar() { generar(0); }
        /// <summary>
        /// generar token de conexion sl SB
        /// </summary>
        /// <param name="posicion"></param>
        private void generar(int posicion)
        {
            noise[posicion] = DateTime.Now.Ticks.ToString();
            ticketResult[posicion] = utiles.GetMD5(ticketSb[posicion] + noise[posicion]);
        }
        /// <summary>
        /// devuelve ticket de conexion actual al SB
        /// </summary>
        /// <returns></returns>
        private string elTicket() { return elTicket(0); }
        /// devuelve ticket de conexion actual al SB
        private string elTicket(int posicion)
        {
            return ticketResult[posicion];
        }
        /// <summary>
        /// la semilla para ocultar el ticket de sesion en la comunicacion
        /// </summary>
        /// <returns></returns>
        private string elNoise() { return elNoise(0); }
        /// <summary>
        /// la semilla para ocultar el ticket de sesion en la comunicacion
        /// </summary>
        /// <param name="posicion"></param>
        /// <returns></returns>
        private string elNoise(int posicion)
        {
            return noise[posicion];
        }
        /// <summary>
        /// devuelve la instanacia de conexion a la BD
        /// </summary>
        /// <returns></returns>
        private string laInstanacia() { return laInstanacia(0); }
        /// <summary>
        /// devuelve la instanacia de conexion a la BD
        /// </summary>
        /// <param name="posicion"></param>
        /// <returns></returns>


        private string laInstanacia(int posicion)
        {
            return idInstanciaSb[posicion];
        }
        #endregion

        #region  standar
        /// <summary>
        /// cadena de coneccion del ensamblado
        /// </summary>
        private string cadenaCone = "User Id=AAA111;Password=BBB222;Data Source=CCC333;Connection Timeout=60; Pooling=false";
        /// <summary>
        /// devuelve la cadena de conexion para oracle
        /// </summary>
        public string cadenaDeConeccion { get { return this.cadenaCone; } }
        /// <summary>
        /// constructor simple
        /// </summary>
        public businessLayer() { }
        /// <summary>
        /// contruye la clase de negocios 
        /// con datos de la BD
        /// </summary>
        /// <param name="usuario">usuario de oracle</param>
        /// <param name="passWord">password de oracle</param>
        /// <param name="dataSource">el TND a donde apuntar</param>
        public businessLayer(string usuario, string passWord, string dataSource)
        {
            cadenaCone = cadenaCone.Replace("AAA111", usuario).Replace("BBB222", passWord).Replace("CCC333", dataSource);
        }
        #endregion

        public OracleConnection AbrirConexion()
        {
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            return cone;
        }


        #region c o d i g o -- d e v e l o p e r

        /// <summary>
        /// Ejemplo - DataTable.
        /// </summary>
        /// <returns></returns>
        //public DataTable sp_lista_clientes_clt()
        //{
        //    /* --
        //    --
        //    -- procedimiento para consultar los clientes de CLT
        //    --

        //        clt.pkg_abm_clientes_contabilidad.sp_lista_clientes_clt(po_retorno => :po_retorno); */

        //    System.Data.DataTable clienteLista = new DataTable();
        //    OracleConnection cone = new OracleConnection(this.cadenaCone);
        //    OracleCommand coman = new OracleCommand("clt.pkg_abm_clientes_contabilidad.sp_lista_clientes_clt", cone);
        //    coman.CommandType = CommandType.StoredProcedure;

        //    coman.Parameters.Add("PO_CURSOR", OracleDbType.RefCursor);
        //    coman.Parameters["PO_CURSOR"].Direction = ParameterDirection.Output;
        //    OracleDataAdapter adap = new OracleDataAdapter(coman);
        //    try
        //    {
        //        coman.Connection.Open();
        //        adap.Fill(clienteLista);
        //        coman.Connection.Close();
        //        coman.Connection.Dispose();
        //    }
        //    catch
        //    {
        //        throw;

        //    }
        //    return clienteLista;

        //}

        /// <summary>
        /// Ejemplo - String
        /// </summary>
        /// <param name="pi_descripcion"></param>
        /// <param name="pi_ruc"></param>
        /// <param name="pi_direccion"></param>
        /// <param name="pi_telefono"></param>
        /// <returns></returns>
        public string sp_inserta_clientes_clt(string pi_descripcion,
                                                 string pi_ruc,
                                                 string pi_direccion,
                                                 string pi_telefono)
        {
            /* --
            --
            -- procedimiento para insertar los clientes de CLT
            --

                clt.pkg_abm_clientes_contabilidad.sp_inserta_clientes_clt(pi_descripcion => :pi_descripcion,
                                                            pi_ruc => :pi_ruc,
                                                            pi_direccion => :pi_direccion,
                                                            pi_telefono => :pi_telefono,
                                                            po_retorno => :po_retorno); */
            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("clt.pkg_abm_clientes_contabilidad.sp_inserta_clientes_clt", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("pi_descripcion", pi_descripcion.Trim());
            coman.Parameters.Add("pi_ruc", pi_ruc.Trim());
            coman.Parameters.Add("pi_direccion", pi_direccion.Trim());
            coman.Parameters.Add("pi_telefono", pi_telefono.Trim());

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;
            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            return datos;

        }

        #endregion
        public DataTable SP_LISTAR_CLIENTES()
        {
            /* --
            --
            -- procedimiento para consultar los clientes de CLT
            --

             -- Call the procedure
             pkg_ABM.SP_LISTAR_CLIENTES(PO_CURSOR => :PO_CURSOR); */

            System.Data.DataTable CLIENTES = new DataTable();
            OracleConnection cone = new OracleConnection(this.cadenaCone);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_ABM.SP_LISTAR_CLIENTES", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PO_CURSOR", OracleDbType.RefCursor);
            coman.Parameters["PO_CURSOR"].Direction = ParameterDirection.Output;
            OracleDataAdapter adap = new OracleDataAdapter(coman);
            try
            {
                coman.Connection.Open();
                adap.Fill(CLIENTES);
                coman.Connection.Close();
                coman.Connection.Dispose();
            }
            catch
            {
                throw;

            }
            return CLIENTES;

        }




        public string SP_INSERT_CLIENTES(string PI_NOMBRE, string PI_APELLIDO)
        {
            /* --
            --
            -- procedimiento para insertar los clientes de CLT
            --

                clt.pkg_abm_clientes_contabilidad.sp_inserta_clientes_clt(pi_descripcion => :pi_descripcion,
                                                            pi_ruc => :pi_ruc,
                                                            pi_direccion => :pi_direccion,
                                                            pi_telefono => :pi_telefono,
                                                            po_retorno => :po_retorno); */
            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_ABM.SP_INSERT_CLIENTES", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PI_NOMBRE", PI_NOMBRE.Trim());
            coman.Parameters.Add("PI_APELLIDO", PI_APELLIDO.Trim());

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;
            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            return datos;

        }



        public string SP_DELETE_CLIENTES(double pi_codigo)
        {

            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_ABM.SP_DELETE_CLIENTES", cone);
            coman.CommandType = System.Data.CommandType.StoredProcedure;


            coman.Parameters.Add("CODIGO_CLIENTE", OracleDbType.Int32).Value = Convert.ToInt32(pi_codigo);

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);  //NOSE UTILIZAN ESTOS DATOS  POR QUE SOLO PIDE UNO PARAMETRO Y NOSOTROS LE ESTABAMOS INGRESANDO DOS
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;
            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            return datos;

        }


        public string SP_UPDATE_CLIENTES(string PI_NOMBRE, string PI_APELLIDO, int PI_CODIGO_CLIENTE)
        {



            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_ABM.SP_UPDATE_CLIENTES", cone);
            coman.CommandType = CommandType.StoredProcedure;


            coman.Parameters.Add("PI_NOMBRE", PI_NOMBRE);
            coman.Parameters.Add("PI_APELLIDO", PI_APELLIDO);
            coman.Parameters.Add("PI_CODIGO_CLIENTE", PI_CODIGO_CLIENTE);

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);  //NOSE UTILIZAN ESTOS DATOS  POR QUE SOLO PIDE UNO PARAMETRO Y NOSOTROS LE ESTABAMOS INGRESANDO DOS
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;

            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            MessageBox.Show("Se a Actualizado los datos");
            return datos;

        }


        //PRODCUTO

        public DataTable SP_LISTAR_PRODUCTO()
        {
            /* --
            --
            -- procedimiento para consultar los clientes de CLT
            --

             -- Call the procedure
             pkg_ABM.SP_LISTAR_CLIENTES(PO_CURSOR => :PO_CURSOR); */

            System.Data.DataTable PRODUCTO = new DataTable();
            OracleConnection cone = new OracleConnection(this.cadenaCone);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_PRODUCTO.SP_LISTAR_PRODUCTO", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PO_CURSOR", OracleDbType.RefCursor);
            coman.Parameters["PO_CURSOR"].Direction = ParameterDirection.Output;
            OracleDataAdapter adap = new OracleDataAdapter(coman);
            try
            {
                coman.Connection.Open();
                adap.Fill(PRODUCTO);
                coman.Connection.Close();
                coman.Connection.Dispose();
            }
            catch
            {
                throw;

            }
            return PRODUCTO;

        }



        public string SP_INSERT_PRODUCTO(string PI_PRODUCTO, double PI_PRECIO, int PI_CANTIDAD)
        {
            /* --
            --
            -- procedimiento para insertar los clientes de CLT
            --

                clt.pkg_abm_clientes_contabilidad.sp_inserta_clientes_clt(pi_descripcion => :pi_descripcion,
                                                            pi_ruc => :pi_ruc,
                                                            pi_direccion => :pi_direccion,
                                                            pi_telefono => :pi_telefono,
                                                            po_retorno => :po_retorno); */
            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_PRODUCTO.SP_INSERT_PRODUCTO", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PI_PRODUCTO", PI_PRODUCTO.Trim());
            coman.Parameters.Add("PI_PRECIO", PI_PRECIO);
            coman.Parameters.Add("PI_CANTIDAD", PI_CANTIDAD);

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;
            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            return datos;

        }


        public string SP_DELETE_PRODUCTO(int pi_codigo)
        {

            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_PRODUCTO.SP_DELETE_PRODUCTO", cone);
            coman.CommandType = System.Data.CommandType.StoredProcedure;


            coman.Parameters.Add("CODIGO_PRODUCTO", OracleDbType.Int32).Value = Convert.ToInt32(pi_codigo);

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);  //NOSE UTILIZAN ESTOS DATOS  POR QUE SOLO PIDE UNO PARAMETRO Y NOSOTROS LE ESTABAMOS INGRESANDO DOS
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;



            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            return datos;

        }

        public string SP_UPDATE_PRODUCTO(string PI_PRODUCTO, float PI_PRECIO, int PI_CANTIDAD, int PI_CODIGO_PRODCUTO)
        {



            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_PRODUCTO.SP_UPDATE_PRODUCTO", cone);
            coman.CommandType = CommandType.StoredProcedure;


            coman.Parameters.Add("PI_PRODUCTO", PI_PRODUCTO);
            coman.Parameters.Add("PI_PRECIO", PI_PRECIO);
            coman.Parameters.Add("PI_CANTIDAD", PI_CANTIDAD);
            coman.Parameters.Add("PI_CODIGO_PRODCUTO", PI_CODIGO_PRODCUTO);

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);  //NOSE UTILIZAN ESTOS DATOS  POR QUE SOLO PIDE UNO PARAMETRO Y NOSOTROS LE ESTABAMOS INGRESANDO DOS
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;

            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            MessageBox.Show("Se a Actualizado los datos");
            return datos;

        }


        //VENTA


        public DataTable SP_LISTAR_VENTA()
        {
            /* --
            --
            -- procedimiento para consultar los clientes de CLT
            --

             -- Call the procedure
             pkg_ABM.SP_LISTAR_CLIENTES(PO_CURSOR => :PO_CURSOR); */

            System.Data.DataTable PRODUCTO = new DataTable();
            OracleConnection cone = new OracleConnection(this.cadenaCone);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_VENTA.SP_LISTAR_VENTA", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PO_CURSOR", OracleDbType.RefCursor);
            coman.Parameters["PO_CURSOR"].Direction = ParameterDirection.Output;
            OracleDataAdapter adap = new OracleDataAdapter(coman);
            try
            {
                coman.Connection.Open();
                adap.Fill(PRODUCTO);
                coman.Connection.Close();
                coman.Connection.Dispose();
            }
            catch
            {
                throw;

            }
            return PRODUCTO;

        }



        //GUARDAR EN LA TABLA
        public string SP_INSERT_VENTA(int PI_COD_PRODUCTO, int PI_CANTIDAD, string PI_NOMBRE_PRODUCTO, int PI_COD_CLIENTE)
        {
            /* --
            --
            -- procedimiento para insertar los clientes de CLT
            --

                clt.pkg_abm_clientes_contabilidad.sp_inserta_clientes_clt(pi_descripcion => :pi_descripcion,
                                                            pi_ruc => :pi_ruc,
                                                            pi_direccion => :pi_direccion,
                                                            pi_telefono => :pi_telefono,
                                                            po_retorno => :po_retorno); */
            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_VENTA.SP_INSERT_VENTA", cone);
            coman.CommandType = CommandType.StoredProcedure;

            coman.Parameters.Add("PI_COD_PRODUCTO ", PI_COD_PRODUCTO);
            coman.Parameters.Add("PI_CANTIDAD ", PI_CANTIDAD);
            coman.Parameters.Add("PI_NOMBRE_PRODUCTO ", PI_NOMBRE_PRODUCTO);
            coman.Parameters.Add(",PI_COD_CLIENTE  ", PI_COD_CLIENTE);


            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;
            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            return datos;

        }


        //DELETE VENTA
        public string SP_DELETE_VENTA(int COD_VENTA)
        {

            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_VENTA.SP_DELETE_VENTA", cone);
            coman.CommandType = System.Data.CommandType.StoredProcedure;


            coman.Parameters.Add("COD_VENTA", OracleDbType.Int32).Value = Convert.ToInt32(COD_VENTA);

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);  //NOSE UTILIZAN ESTOS DATOS  POR QUE SOLO PIDE UNO PARAMETRO Y NOSOTROS LE ESTABAMOS INGRESANDO DOS
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;
            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            return datos;

        }

        //UPDATE
        public string SP_UPDATE_VENTA(int PI_COD_PRODUCTO, float PI_CANTIDAD, string PI_NOMBRE_PRODUCTO, int PI_COD_CLIENTE, int PI_CODIGO_VENTA, int V_PRECIO)
        {



            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_VENTA.SP_UPDATE_VENTA", cone);
            coman.CommandType = CommandType.StoredProcedure;


            coman.Parameters.Add("PI_COD_PRODUCTO ", PI_COD_PRODUCTO);
            coman.Parameters.Add("PI_CANTIDAD ", PI_CANTIDAD);
            coman.Parameters.Add("PI_NOMBRE_PRODUCTO ", PI_NOMBRE_PRODUCTO);
            coman.Parameters.Add(",PI_COD_CLIENTE  ", PI_COD_CLIENTE);
            coman.Parameters.Add("PI_CODIGO_VENTA", PI_CODIGO_VENTA);
            coman.Parameters.Add("V_PRECIO", V_PRECIO);

            coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);  //NOSE UTILIZAN ESTOS DATOS  POR QUE SOLO PIDE UNO PARAMETRO Y NOSOTROS LE ESTABAMOS INGRESANDO DOS
            coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;

            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            MessageBox.Show("Se a Actualizado los datos");
            return datos;

        }


        //LISTAR PRECIO
        public string SP_LISTAR_PRECIO(int COD_VENTA)
        {

            string datos = "";
            OracleConnection cone = new OracleConnection(cadenaDeConeccion);
            OracleCommand coman = new OracleCommand("USER_ORA.PKG_VENTA.SP_LISTAR_PRECIO", cone);
            coman.CommandType = System.Data.CommandType.StoredProcedure;


            coman.Parameters.Add("COD_VENTA", OracleDbType.Int32).Value = Convert.ToInt32(COD_VENTA);

            //coman.Parameters.Add("po_retorno", OracleDbType.NVarchar2, 500);  //NOSE UTILIZAN ESTOS DATOS  POR QUE SOLO PIDE UNO PARAMETRO Y NOSOTROS LE ESTABAMOS INGRESANDO DOS
            //coman.Parameters["po_retorno"].Direction = ParameterDirection.Output;
            try
            {
                cone.Open();
                coman.ExecuteNonQuery();
                cone.Close();
                //datos = coman.Parameters["po_retorno"].Value.ToString();
            }
            catch
            {
                throw;

            }
            return datos;
        }

    }
}

