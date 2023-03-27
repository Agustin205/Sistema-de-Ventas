using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Verificacion
{
    public class VerificacionUser
    {

        public bool VerificacionMail(string pEmail)
        {
            bool resultado = false;
            Regex rx = new Regex(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$");
            if (rx.IsMatch(pEmail))
            {
                resultado = true;
            }
            else { resultado = false; }

            return resultado;
        }
        
        public bool VerificacionContraseña(string pass)
        {
            var Numero = new Regex(@"[0-9]{1}");
            var Mayuscula = new Regex(@"[A-Z]{1}");
            var CaracteresMinimos = new Regex(@".{5,}");
            var Minuscula = new Regex(@"[a-z]{1}");
            var Simbolos = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]{1}");

            bool isValidated = Numero.IsMatch(pass) && Mayuscula.IsMatch(pass) && CaracteresMinimos.IsMatch(pass) 
                               && Minuscula.IsMatch(pass) && Simbolos.IsMatch(pass);

            
            return isValidated;

        }

        public bool VerificacionUsuario(string usuario)
        {
            var Numero = new Regex(@"[0-9]+");
            
            var Mayuscula = new Regex(@"[A-Z]+");
            var CaracteresMinimos = new Regex(@".{4,}");
            var Minuscula = new Regex(@"[a-z]+");

            bool isValidated = Numero.IsMatch(usuario) && Mayuscula.IsMatch(usuario) && CaracteresMinimos.IsMatch(usuario)
                               && Minuscula.IsMatch(usuario);
            
            return isValidated;

        }

        public bool VerificacionDNI(string usuario)
        {

            var CaracteresMinimos = new Regex(@".{7,}");

            bool isValidated = CaracteresMinimos.IsMatch(usuario);

            return isValidated;

        }

        public bool VerificacionTelefono(string usuario)
        {

            var CaracteresMinimos = new Regex(@".{9,}");

            bool isValidated = CaracteresMinimos.IsMatch(usuario);

            return isValidated;

        }


        public bool IntentosFallidos(int pContador)
        {
            bool resultado = false;
            if(pContador >= 3)
            {
                resultado = true;
            }
            return resultado;
        }


    }
}
