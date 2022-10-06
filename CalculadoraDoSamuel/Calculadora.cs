using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDoSamuel;

    public class Calculadora
    {
        public double NumUm { get; set; }
        public double NumDois { get; set; }

        public string Soma()
        {
            return Convert.ToString(NumUm + NumDois);
        }

        public string Sub()
        {
            return Convert.ToString(NumUm - NumDois);
        }
        public string Mult()
        {
            return Convert.ToString(NumUm * NumDois);
        }
        public string Div()
        {
            return Convert.ToString(NumUm / NumDois);
        }

}

