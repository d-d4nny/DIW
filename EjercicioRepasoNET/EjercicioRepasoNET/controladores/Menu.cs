using Servicios;
using entidades;
using System;
using System.Collections.Generic;

namespace Controladores
{
    class Menu
    {
        public const string RUTA_ARCHIVO_LOG = "C:\\logs.txt";

        static void Main(string[] args)
        {
            List<Empleados> bdMain = new List<Empleados>();
            IntzMenu intM = new ImplMenu();
            IntzEmpleado intE = new ImplEmpleado();
            bool cerrarMenu = false;
            int opcion;

            try
            {
                do
                {
                    intM.MostrarMenu();
                    Console.WriteLine("Introduce una opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            intE.RegistroEmpleado(bdMain);
                            break;
                        case 2:
                            intE.ModificarRegistro(bdMain);
                            break;
                        case 3:
                            intE.ExportarFichero(bdMain);
                            break;
                        case 4:
                            cerrarMenu = true;
                            break;
                        default:
                            Console.WriteLine("\n**[ERROR] Opción elegida no disponible **");
                            break;
                    }

                } while (!cerrarMenu);
            }
            catch (FormatException)
            {
                Console.WriteLine("\n**[ERROR] Entrada inválida: por favor ingrese un número entero **");
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine("\n**[ERROR] Ocurrió una excepción no esperada: " + nre.Message + " **");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n**[ERROR] Ocurrió una excepción no esperada: " + ex.Message + " **");
            }
        }
    }
}
