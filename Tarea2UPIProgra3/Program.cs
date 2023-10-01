using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tarea2UPIProgra3
{
    internal class Program
    {
        static void Main(string[] args)
        
        
     {
            int opcion = 0;
            do
            {
                Console.WriteLine("1-Ejercicio 1");
                Console.WriteLine("2-Ejercicio 2");
                Console.WriteLine("3-Ejercicio 3");
                Console.WriteLine("4-Salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine()); 

                switch (opcion) 
                {
                    case 1:
                        Ejercicio1();


                        break; 
                   
                    case 2:
                        Ejercicio2();


                        break; 
                    
                    case 3:
                        Ejercicio3();


                        break;
                    
                    case 4: break;
                    default: 
                        
                        Console.WriteLine("Opcion incorrecta");
                        Console.ReadLine(); 
                        break;


                }

            } while (opcion != 4);


        }
    
        public static void Ejercicio1()
        {
        //1 camisa sin descuento
        //de 2 a 5 con 15 descuento
        //mas de 5 con 20 descuento

        float precio = 0f;
        int cantidad;


            Console.WriteLine("Digite el precio");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad==1) //si la cantidad es 1
            {
                Console.WriteLine($"El precio de la camisa es de {cantidad * precio}");
            }

            if (cantidad>=2 && cantidad<=5)
            {
                Console.WriteLine($"El precio de la camisa es de {((precio- (precio*0.15f)) * cantidad)} con descuento de 15%");
            }
           
            if (cantidad > 5)
            {
               Console.WriteLine($"El precio de la camisa es de {((precio - (precio * 0.20f)) * cantidad)} con descuento de 20%");
            }
            Console.ReadLine ();
        }

        public static void Ejercicio2()
        {
            double prom;
            String carnet, nombre;
            double q_1 , q_2, q_3,t_1 , t_2, t_3, e_1 , e_2 , e_3 ;
            String prom_f;


            Console.WriteLine("******Ingrese la información del estudiante******");
            Console.WriteLine("Ingrese el carnet del estudiante: ");
            carnet = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del estudiante");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la nota del Quiz 1");
            q_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del Quiz 2");
            q_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del Quiz 3");
            q_3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de la tarea 1");
            t_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de la tarea 2");
            t_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de la tarea 3");
            t_3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del exámen 1");
            e_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del exámen 2");
            e_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del exámen 3");
            e_3 = Convert.ToDouble(Console.ReadLine());

            double p_quices = (q_1 + q_2 + q_3) /3 * 0.25;
            double p_tareas = (t_1 + t_2 + t_3) /3 * 0.30;
            double p_examen = (e_1 + e_2 + e_3) /3 * 0.45;

            prom = p_quices + p_tareas + p_examen;

            if (prom >= 70)
            {
                prom_f = "Aprobado";

            }
            else if (prom >=50 && prom < 70)
            {
                prom_f = "Aplazado";
            }
            else
            {
                prom_f = "Reprobado";
            }
            Console.WriteLine("\n Resultado Final:");
            Console.WriteLine("El Carnet del estudiante es: " + carnet);
            Console.WriteLine("El nombre del estudiante es: " + nombre);
            Console.WriteLine("El Porcentaje de los Quices es: " + p_quices.ToString(""));
            Console.WriteLine("Porcentaje de Tareas: " + p_tareas.ToString(""));
            Console.WriteLine("Porcentaje de Examenes: " + p_examen.ToString(""));
            Console.WriteLine("Promedio Final: " + prom.ToString("F2"));
            Console.WriteLine("El estudiante esta: " + prom_f);

        }

        public static void Ejercicio3()
        {
            double producto, total;
            int precio = 0;
            Console.WriteLine("******BIENVENIDO******");
            Console.WriteLine("Ingrese la cantidad de articulos: ");
            producto = Convert.ToDouble(Console.ReadLine());

            if (producto <= 10)
            {
                precio = 20;

            }
            else if (producto > 10)
            {
                precio = 15;
            }


           total = producto * precio;

            Console.WriteLine($"El precio por artículo es de: ${precio}");
            Console.WriteLine($"Su total a pagar es de: ${total}");
        }

    }


}
