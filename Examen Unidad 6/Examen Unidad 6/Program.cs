using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_Unidad_6
{
    class Productos
    {
        public string nombre;
        public string descripcion;
        public float precio;
        public int stock;

        public Productos(string nombre, string descripcion, float precio, int stock)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }

        public void DesplegarDatos()
        {
            Console.WriteLine("El nombre del producto es: {0}",nombre);
            Console.WriteLine("Descripcion del producto: {0}",descripcion);
            Console.WriteLine("El precio del producto es: {0}$",precio);
            Console.WriteLine("La cantidad en stock del producto es: {0}",stock);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Productos.txt", true); //Creacion del Archivo
            int opc = 0;
            do
            {
                Console.WriteLine("Bienvenido a Amazon.");
                Console.WriteLine("1) Registrar Productos. \n2)Salir del Progrma");
                Console.Write("Elija su opcion: ");
                switch (opc)
                {
                    case 1:
                        {
                            string nombre, descripcion;
                            float precio;
                            int stock;
                            Console.Clear();
                            Console.Write("¿Cuál es el nombre del producto?: ");
                            nombre = Console.ReadLine();
                            Console.Clear();
                            Console.Write("¿Cuál es la descripcion del producto?: ");
                            descripcion = Console.ReadLine();
                            Console.Clear();
                            Console.Write("¿Cuál es el precio del producto?: ");
                            precio = float.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.Write("¿Cuál es la cantidad en stock del producto?: ");
                            stock = int.Parse(Console.ReadLine());
                            Console.Clear();

                            Productos p1 = new Productos(nombre, descripcion, precio, stock);

                            p1.DesplegarDatos();

                            sw.WriteLine("El nombre del producto es: {0}", p1.nombre);
                            sw.WriteLine("Descripcion del producto: {0}", p1.descripcion);
                            sw.WriteLine("El precio del producto es: {0}$", p1.precio);
                            sw.WriteLine("La cantidad en stock del producto es: {0}", p1.stock);

                            sw.Close();

                            Console.WriteLine("Escribiendo en el archivo...\n\n Presione Enter para continuar.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Gracias por usar el programa. \nPresiones <Enter> para salir. ");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Respuesta Incorrecta. \nPresione <Enter> para volver a introducir su opcion.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }

            } while (opc != 2);
        }
    }
}
