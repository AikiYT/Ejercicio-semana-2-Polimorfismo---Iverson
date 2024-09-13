using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_semana_2_Polimorfismo___Iverson
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Empleado> empleados = new List<Empleado>
        {
            new DocentePorHora("Iverson", 40), // 40 horas trabajadas
            new DocenteContratoFijo("Francis", 3000, 500), // Salario base de 3000 con bonificación de 500
            new EmpleadoAdministrativo("Abinader", 2500, 300) // Salario base de 2500 con bonificación de 300
        };

            // Calcular y mostrar el salario de cada empleado
            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine($"{empleado.MostrarTipoEmpleado()}: {empleado.Nombre}, Salario: {empleado.CalcularSalario()}, {empleado.MostrarBono()}");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
            }








    
            Console.WriteLine("Presiona cualquier tecla para cerrar la consola...");
            Console.ReadKey();
           
        }
    }
}
