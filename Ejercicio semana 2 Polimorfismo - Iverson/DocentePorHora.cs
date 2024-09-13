using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_semana_2_Polimorfismo___Iverson
{
    public class DocentePorHora : Empleado
    {

        public int HorasTrabajadas { get; set; }
        private const decimal TarifaPorHora = 800; // Tarifa fija por hora que le puse

        public DocentePorHora(string nombre, int horasTrabajadas) : base(nombre)
        {
            HorasTrabajadas = horasTrabajadas;
        }

        // Cálculo del salario: horas trabajadas * tarifa por hora
        public override decimal CalcularSalario()
        {
            return HorasTrabajadas * TarifaPorHora;
        }

        public override string MostrarTipoEmpleado()
        {
            return "Empleado por hora";
        }
    }

}

