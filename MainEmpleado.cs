using System;
using TareaProgramacion;

namespace Tarea
{
    class MainEmpleado
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicacion de Gestión de Empleados");

            List<Empleado> listaEmpleados = new List<Empleado>();

            listaEmpleados.Add(new Empleado("Ashlee", 1080, 3000, true));
            listaEmpleados.Add(new Empleado("Luis", 1096, 2000.986, false));
            listaEmpleados.Add(new Empleado("Andrea", 0098, 100, true));

            foreach (var empleado in listaEmpleados)
            {
                empleado.MostrarDatos();
            }

            static Empleado BuscarEmpleado(List<Empleado> Empleados, int NumeroEmpleado)
            {
                foreach (var empleado in Empleados)
                {
                    if (empleado.ObtenerNumeroEmpleado() == NumeroEmpleado)
                    {
                        return empleado;
                    }
                }
                return null;
            }

            int NumeroEmpleadoCambiarEstado = 2508;
            Empleado empleadoCambiarEstado = BuscarEmpleado(listaEmpleados, NumeroEmpleadoCambiarEstado)

            if (empleadoCambiarEstado != null)
            {
                empleadoCambiarEstado.CambiarEstado(1);
                empleadoCambiarEstado.MostrarDatos();
            }
            else
            {
                Console.WriteLine($"Empleado con número {NumeroEmpleadoCambiarEstado} no encontrado");
            }

            
            int numeroEmpleado = 1080;
            Empleado empleadoAumento = BuscarEmpleado(listaEmpleados, numeroEmpleado);
            if (empleadoAumento != null)
            {
                double Aumento = 0.30;

                empleadoAumento.AumentoDeSalario(Aumento);
                empleadoAumento.MostrarDatos();
            }
            else
            {
                Console.WriteLine($"Empleado con número {numeroEmpleado} no encontrado");
            }


        }

    }
}
