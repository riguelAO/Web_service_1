using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Trabajo_grupal
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod(Description = "Sumar dos numeros")]
        public double Sumar(double nro1, double nro2)
        {
            return nro1 + nro2;
        }
        //RESTA
        [WebMethod(Description = "Resta dos numeros")]
        public double Resta(double nro1, double nro2)
        {
            return nro1 - nro2;
        }
        //Multiplicacion
        [WebMethod(Description = "Multiplicacion de dos numeros")]
        public double Multiplicacion(double nro1, double nro2)
        {
            return nro1 * nro2;
        }
        //Division
        [WebMethod(Description = "Division de dos numeros")]
        public double Division(double nro1, double nro2)
        {
            return nro1 / nro2;
        }

        private int Factorial(int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }

        [WebMethod(Description = "Factorial de un numero")]
        public int Fact(int n)
        {
            return Factorial(n);
        }

        [WebMethod(Description = "Potencia de un numero")]
        public int Potencia(int a, int b)
        {
            int Potencia = 1;
            for (int i = 0; i < b; ++i)
            {
                Potencia *= a;
            }
            return Potencia;
        }

        [WebMethod(Description = "Seno de Angulo")]
        public double Seno(double angulo)
        {
            angulo = (angulo * Math.PI) / 180;
            return Math.Sin(angulo);
        }
        [WebMethod(Description = "Tangente de Angulo")]
        public double Tangente(double angulo)
        {
            angulo = (angulo * Math.PI) / 180;
            return Math.Tan(angulo);
        }
        //INVERSO
        [WebMethod(Description = "Inversa de un número")]
        public Double inversa(Double numero)
        {
            Double inversa = 0;
            inversa = 1 / numero;
            return inversa;
        }
        //RAIZ
        [WebMethod(Description = "Raiz cuadrada de un numero")]
        public Double raiz_cuadrada(int numero)
        {
            double raizcu = 0;
            raizcu = Math.Sqrt(numero);
            return raizcu;
        }
        //RAIZ ENESIMA
        [WebMethod(Description = "Raiz n - esima de un numero")]
        public Double raiz_n_esima(int numero, int raiz)
        {
            double resp = 0;
            double expo = 1 / raiz;
            resp = Math.Pow(numero, expo);
            return resp;
        }
    }
}
