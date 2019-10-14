using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaColecciones
{
    public class Calculadora
    {
        private static readonly Calculadora c = new Calculadora();
        

        private Calculadora()
        {
            
        }

        public static Calculadora getCalculadora() 
        {
            return c;
        }

        public int calcularMedia(List<int> numeros) {
            int resultado = 0;
            foreach (int num in numeros)
            {
                resultado += num;
            }
            return resultado;
        }


    }
}
