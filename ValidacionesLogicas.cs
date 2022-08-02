using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //traeremos las liberias de form
using System.Text.RegularExpressions; // para poder utilizar expresiones regulares

namespace f2
{
    class ValidacionesLogicas
    {
        public static bool soloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) //capturamos cada tecla que se preciona
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }
        public static bool textVacios(TextBox ptxt) // para texto vacios
        {
            if (ptxt.Text == String.Empty)
            {
                ptxt.Focus();

                return true;
            }
            else
                return false;
        }

        public static bool validarEmail(string pCorreo)
        {
            return pCorreo !=null && Regex.IsMatch(pCorreo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        
    }
}
