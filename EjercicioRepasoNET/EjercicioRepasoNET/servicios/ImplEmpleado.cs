using entidades;
using System;
using System.Collections.Generic;
using System.IO;

namespace Servicios
{
    public class ImplEmpleado : IntzEmpleado
    {
        private int contadorIdEmpleado = 0;

        public void ExportarFichero(List<Empleados> bdMain)
        {
            StreamWriter fichero = null;

            try
            {
                fichero = new StreamWriter("./Empleados.txt");

                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("(La lista se guarda en la carpeta debug)");
                Console.WriteLine("1. Listar todos los registros.");
                Console.WriteLine("2. Imprimir un registro específico por número de empleado.");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (bdMain.Count == 0)
                        {
                            Console.WriteLine("No hay empleados registrados.");
                        }
                        else
                        {
                            Console.WriteLine("Lista de empleados:");
                            foreach (Empleados empleado in bdMain)
                            {
                                fichero.WriteLine(empleado);
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("Introduzca el número de empleado:");
                        int numeroEmpleado = int.Parse(Console.ReadLine());
                        bool encontrado = false;

                        foreach (Empleados empleado in bdMain)
                        {
                            if (empleado.NumEmpleado == numeroEmpleado)
                            {
                                fichero.WriteLine(empleado);
                                encontrado = true;
                                break;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No se encontró un empleado con ese número.");
                        }
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("[ERROR] - FICHERO NO ENCONTRADO: " + fichero + "\n" + ioe);
            }
            finally
            {
                if (fichero != null)
                    fichero.Close();
            }
        }

        public void RegistroEmpleado(List<Empleados> bdMain)
        {
            int numEmpleado, numSeguridadSocial, numCuentaCorriente;
            string nombre, apellidos, dni, titulacion, fechaNacimiento;

            Console.WriteLine("Introduzca su Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca sus Apellidos: ");
            apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca su DNI: ");
            dni = Console.ReadLine();
            Console.WriteLine("Introduzca su Fecha de Nacimiento: ");
            fechaNacimiento = Console.ReadLine();
            Console.WriteLine("Introduzca su Titulacion mas alta: ");
            titulacion = Console.ReadLine();
            Console.WriteLine("Introduzca su Numero de la Seguridad Social: ");
            numSeguridadSocial = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca su Numero de la Cuenta Corriente: ");
            numCuentaCorriente = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEmpleado Registrado.");

            contadorIdEmpleado++;
            numEmpleado = contadorIdEmpleado;

            bdMain.Add(new Empleados(numEmpleado, nombre, apellidos, dni, fechaNacimiento, titulacion, numSeguridadSocial, numCuentaCorriente));
        }

        public void ModificarRegistro(List<Empleados> bdMain)
        {
            int opcion;

            Console.WriteLine("Introduzca el Id del Empleado a modificar: ");
            int buscaId = int.Parse(Console.ReadLine());
            bool idEncontrado = false;

            foreach (Empleados empleado in bdMain)
            {
                if (empleado.NumEmpleado == buscaId)
                {
                    idEncontrado = true;

                    Console.WriteLine("Empleado encontrado. ¿Qué campo deseas modificar?");
                    Console.WriteLine("1. Nombre");
                    Console.WriteLine("2. Apellidos");
                    Console.WriteLine("3. DNI");
                    Console.WriteLine("4. Fecha de Nacimiento");
                    Console.WriteLine("5. Titulacion");
                    Console.WriteLine("6. Numero de la Seguridad Social");
                    Console.WriteLine("7. Numero de la Cuenta Corriente");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Introduce el nuevo nombre: ");
                            string nuevoNombre = Console.ReadLine();
                            empleado.Nombre = nuevoNombre;
                            break;
                        case 2:
                            Console.Write("Introduce los nuevos apellidos: ");
                            string nuevosApellidos = Console.ReadLine();
                            empleado.Apellidos = nuevosApellidos;
                            break;
                        case 3:
                            Console.Write("Introduce el nuevo DNI: ");
                            string nuevoDNI = Console.ReadLine();
                            empleado.Dni = nuevoDNI;
                            break;
                        case 4:
                            Console.Write("Introduce la nueva fecha de nacimiento: ");
                            string nuevaFechaNacimiento = Console.ReadLine();
                            empleado.FechaNacimiento = nuevaFechaNacimiento;
                            break;
                        case 5:
                            Console.Write("Introduce la nueva titulacion: ");
                            string nuevaTitulacion = Console.ReadLine();
                            empleado.Titulacion = nuevaTitulacion;
                            break;
                        case 6:
                            Console.Write("Introduce el nuevo numero de la seguridad social: ");
                            int nuevoNumSeguridadSocial = int.Parse(Console.ReadLine());
                            empleado.NumSeguridadSocial = nuevoNumSeguridadSocial;
                            break;
                        case 7:
                            Console.Write("Introduce el nuevo numero de la cuenta corriente: ");
                            int nuevoNumCuentaCorriente = int.Parse(Console.ReadLine());
                            empleado.NumCuentaCorriente = nuevoNumCuentaCorriente;
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }

                    bdMain[bdMain.IndexOf(empleado)] = empleado;
                    Console.WriteLine("Empleado modificado correctamente.");
                    break;
                }
            }

            if (!idEncontrado)
            {
                Console.WriteLine("No se ha encontrado ningun empleado con ese Id");
            }
        }
    }
}
