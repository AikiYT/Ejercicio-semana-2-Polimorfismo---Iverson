using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_2_Polimorfismo___Iverson
{
    public class DocenteContratoFijo : Empleado
    {
        public decimal SalarioBase { get; set; }
        public decimal Bonificacion { get; set; }

        public DocenteContratoFijo(string nombre, decimal salarioBase, decimal bonificacion) : base(nombre)
        {
            SalarioBase = salarioBase;
            Bonificacion = bonificacion;
        }

        // Cálculo del salario: salario base + bonificación
        public override decimal CalcularSalario()
        {
            return SalarioBase + Bonificacion;
        }

        public override string MostrarTipoEmpleado()
        {
            return "Empleado Con contrato fijo";
        }

        public override string MostrarBono()
        {
            return "bono de 500";
        }
    }
}
