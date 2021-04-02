using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalosTiempo
{
    class Actividades
    {
        public void A31()
        {
            bool IngresoCorrecto = false;
            string ingreso;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                ingreso = Console.ReadLine();

                if (!int.TryParse(ingreso, out int Numero))
                {
                    Console.WriteLine("No ha ingresado un número");
                    continue;
                }
                IngresoCorrecto = true;

            } while (!IngresoCorrecto);


            if (!TimeSpan.TryParse(ingreso, out TimeSpan Intervalo))
            {
                Console.WriteLine("No ha ingresado un intervalo de tiempo");
            }
            else
            {
                Console.WriteLine("Ha ingresado un intervalo de tiempo");
            }
        }

        public void A32()
        {
            bool IngresoValido = false;
            DateTime FechaOk1;
            DateTime FechaOk2;

            do
            {
                Console.Write("Ingrese una fecha:");
                string Fecha1 = Console.ReadLine();

                if (!DateTime.TryParse(Fecha1, out FechaOk1))
                {
                    Console.WriteLine("Debe ingresar una fecha válida");
                    continue;
                }
                IngresoValido = true;
            } while (!IngresoValido);

            do
            {
                IngresoValido = false;
                Console.Write("Ingrese otra fecha:");
                string Fecha2 = Console.ReadLine();

                if (!DateTime.TryParse(Fecha2, out FechaOk2))
                {
                    Console.WriteLine("Debe ingresar una fecha válida");
                    continue;
                }
                IngresoValido = true;

            } while (!IngresoValido);

            var timespan = FechaOk1 - FechaOk2;

            Console.WriteLine("Intervalo en días: "+ timespan.Days);
            Console.WriteLine("Intervalo en Meses: " + (timespan.TotalDays)/30);
            Console.WriteLine("Intervalo en Años: " + (timespan.TotalDays)/365);
        }

        public void A33()
        {
            bool IngresoCorrecto = false;
            DateTime FechaOk;

            do
            {
                Console.WriteLine("Ingrese una fecha: ");
                string ingreso = Console.ReadLine();

                if (!DateTime.TryParse(ingreso, out FechaOk))
                {
                    Console.WriteLine("No ha ingresado una fecha correcta");
                    continue;
                }
                    IngresoCorrecto = true;

            } while (!IngresoCorrecto);

            //TimeSpan Intervalo = (365 -(FechaOk.AddDays(-FechaOk.Day).AddMonths(-FechaOk.Month)));

            //Console.WriteLine($"Faltan:{Intervalo.ToString()} días para terminar el año");
        }

    }
}
