using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_AndreaGudiel_1115219
{
    public class Operar
    {
        public Double Operando(string regex)
        {
            var resultado = Evaluar(regex);
            return resultado;
        }


        public static Double Evaluar(String expression)
        {
            //Creo un DataTable
            System.Data.DataTable table = new System.Data.DataTable();
            //Realizo el cálculo..
            object result = table.Compute(expression, string.Empty);
            //Lo devuelvo convertido a Double
            return Convert.ToDouble(result);
        }
    }
}
