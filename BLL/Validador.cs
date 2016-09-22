<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Validador
    {
        /// <summary>
        /// funcion que valida que el texto sea un numero
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        public bool esNumeroPositivo(string campo)
        {
            bool resultado = false;
            int numero = 0;
            if (int.TryParse(campo, out numero) == true)
            {
                if (numero > 0)
                    resultado = true;
                else
                    resultado = false;
            }
            return resultado;
        }

        public bool FechaCorrecta(string campo)
        {
            bool respuesta = true;

            int anio = 0, mes = 0, dia = 0;
            string[] fecha = campo.Split(new char[] { '-' });
            string sanio = fecha[0];
            string smes = fecha[1];
            string sdia = fecha[2];

            if (int.TryParse(sanio, out anio) == false)
            {
                return false;
            }

            if (int.TryParse(smes, out mes) == false)
            {
                return false;
            }

            if (int.TryParse(sdia, out dia) == false)
            {
                return false;
            }

            if (((mes > 0) && (mes <= 12)) && ((dia > 0) && (dia <= 31)) && ((anio > 0) && (anio <= 100000)))
            {
                return true;
            }
            else
                return false;

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Validador
    {
        /// <summary>
        /// funcion que valida que el texto sea un numero
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        public bool esNumeroPositivo(string campo)
        {
            bool resultado=false;
            int numero=0;
            if (int.TryParse(campo, out numero) == true)
            {
                if (numero > 0)
                    resultado = true;
                else
                    resultado = false;
            }
            return resultado;        
        }

        public bool FechaCorrecta(string campo)
        {
            bool respuesta = true;

            int anio = 0, mes = 0, dia = 0;
            string[] fecha = campo.Split(new char[]{'-'});
            string sanio = fecha[0];
            string smes = fecha[1];
            string sdia = fecha[2];

            if (int.TryParse(sanio, out anio) == false)
            {
                return false;
            }

            if (int.TryParse(smes, out mes) == false)
            {
                return false;
            }

            if (int.TryParse(sdia, out dia) == false)
            {
                return false;
            }

            if (((mes > 0) && (mes <= 12)) && ((dia > 0) && (dia <= 31)) && ((anio > 0) && (anio <= 100000)))
            {
                return true;
            }
            else
                return false;

        }
    }
}
>>>>>>> origin/master
