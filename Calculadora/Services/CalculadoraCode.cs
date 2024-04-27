using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraCode
    {
        private List<string> historico;
        private string data;

        public CalculadoraCode(string data)
        {
            historico = new List<string>();
            this.data = data;
        }

        public int Somar(int val1, int val2)
        {
            int resultado = val1 + val2;
            historico.Insert(0, "Resultado: " + resultado + "Data: " + data);
            return resultado;
        }

        public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            historico.Insert(0, "Resultado: " + resultado + "Data: " + data);
            return resultado;
        }

        public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;
             historico.Insert(0, "Resultado: " + resultado + "Data: " + data);
            return resultado;
        }

        public int Dividir(int val1, int val2)
        {
            int resultado = val1 / val2;
            historico.Insert(0, "Resultado: " + resultado + "Data: " + data);
            return resultado;
        }

        public List<string> Historico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}