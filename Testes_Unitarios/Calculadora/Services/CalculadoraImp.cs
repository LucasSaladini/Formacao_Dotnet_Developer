using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool EPar(int num)
        {
            return num % 2 == 0;
        }
    }
}