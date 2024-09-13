using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_2_Polimorfismo___Iverson
{
    public abstract class Empleado
    {
        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; set; }


        public abstract decimal CalcularSalario();


        public virtual string MostrarTipoEmpleado()
        {
            return "Empleado";
        }


        public virtual string MostrarBono()
        {
            return "Sin bono";
        }
    }
}





