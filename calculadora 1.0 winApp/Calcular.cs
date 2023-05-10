using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_1._0_winApp
{
    public class Calcular
    {
        decimal primeiroNumero;
        decimal segundoNumero;
        string operacao = "";

        public string FazerOperacao()
        {
            decimal resultado = 0;
            switch (operacao)
            {                            
                case "+": resultado = primeiroNumero + segundoNumero; break;
                case "-": resultado = primeiroNumero - segundoNumero; break;
                case "*": resultado = primeiroNumero * segundoNumero; break;
                case "/": resultado = primeiroNumero / segundoNumero; break;
            }

            return resultado.ToString();
        }



    }
}
