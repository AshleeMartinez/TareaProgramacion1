namespace TareaProgramacion
{
    class Empleado
    {
        private string Nombre;
        private int NumeroEmpleado;
        private decimal Salario;
        private bool Activo;

        public Empleado(string nombre, int numeroEmpleado, decimal salario, bool Activo)
        {
            this.Nombre = nombre;
            this.Activo = Activo;
            this.Salario = salario;    
            this.NumeroEmpleado = numeroEmpleado;
        }

        public void MostrarDatos()
        {
            string Estado = (Activo) ? "Activo" : "Domingo";
            Console.WriteLine($"Nombre: {Nombre}, Numero de Empleado: {NumeroEmpleado}, Salario: C${Salario}, Estado: {Estado} ";


        }
        public int ObtenerNumeroEmpleado()
        {
            return this.NumeroEmpleado;
        }

        public void CambiarEstado(int NuevoEstado)
        {
            if(NuevoEstado == 1)
            {
                Activo= true;
                Console.WriteLine("Empleado activado");
            }
            else if(NuevoEstado == 0) {
            Activo = false;
                Console.WriteLine("Empleado desactivado");
            }
            else
            {
                Console.WriteLine("Estado no valido");
            }
        }

    public void AumentoDeSalario(double NuevoSalario,double Xporcentaje)
        {
            this.Salario = NuevoSalario * (Xporcentaje);
            Console.WriteLine($"El empleado {Nombre}, tiene ahora C${this.Salario}");
        }

    }
}
