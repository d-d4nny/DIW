using entidades;
using System.Collections.Generic;

namespace Servicios
{
    public interface IntzEmpleado
    {
        void ExportarFichero(List<Empleados> bdMain);

        void RegistroEmpleado(List<Empleados> bdMain);

        void ModificarRegistro(List<Empleados> bdMain);
    }
}
