using System;

namespace Servicios
{
    public class ImplMenu : IntzMenu
    {
        public void MostrarMenu()
        {
            Console.WriteLine("\n------- Menú -------");
            Console.WriteLine(" 1 Registrar Empleado ");
            Console.WriteLine(" 2 Modificar Empleado ");
            Console.WriteLine(" 3 Exportar Fichero  ");
            Console.WriteLine(" 4 Cerrar App         ");
        }
    }
}
