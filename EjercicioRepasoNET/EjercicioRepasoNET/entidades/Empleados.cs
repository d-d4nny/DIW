namespace entidades
{
    public class Empleados
    {
        private int numEmpleado;
        private string nombre;
        private string apellidos;
        private string dni;
        private string fechaNacimiento;
        private string titulacion;
        private int numSeguridadSocial;
        private int numCuentaCorriente;

        public Empleados(int numEmpleado, string nombre, string apellidos, string dni, string fechaNacimiento, string titulacion, int numSeguridadSocial, int numCuentaCorriente)
        {
            this.numEmpleado = numEmpleado;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
            this.titulacion = titulacion;
            this.numSeguridadSocial = numSeguridadSocial;
            this.numCuentaCorriente = numCuentaCorriente;
        }

        public int NumEmpleado
        {
            get { return numEmpleado; }
            set { numEmpleado = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public string Titulacion
        {
            get { return titulacion; }
            set { titulacion = value; }
        }

        public int NumSeguridadSocial
        {
            get { return numSeguridadSocial; }
            set { numSeguridadSocial = value; }
        }

        public int NumCuentaCorriente
        {
            get { return numCuentaCorriente; }
            set { numCuentaCorriente = value; }
        }

        public override string ToString()
        {
            return "Empleado ID: " + numEmpleado +
                ", Nombre: " + nombre +
                ", Apellidos: " + apellidos +
                ", DNI: " + dni +
                ", Fecha de Nacimiento: " + fechaNacimiento +
                ", Titulación: " + titulacion +
                ", Número de Seguridad Social: " + numSeguridadSocial +
                ", Número de Cuenta Corriente: " + numCuentaCorriente;
        }
    }
}
