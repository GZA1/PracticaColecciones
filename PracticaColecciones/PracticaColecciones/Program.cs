using System;
using System.Collections.Generic;

namespace PracticaColecciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = Calculadora.getCalculadora();

            Console.Write("Intruduzca los números sobre los que desee calcular la media \n" +
                "separados por un guión \"-\": \t");
            String numerosRaw = Console.ReadLine();
            String[] numeros = numerosRaw.Split("-");
            List<int> nums = new List<int>();
            foreach (String s in numeros)
            {
                try
                {
                    nums.Add(int.Parse(s));
                }
                catch (Exception ex) {
                    Console.Write("Error\n"+ex.GetBaseException()+"\n");
                    Console.ReadKey();
                    System.Environment.Exit(1);
                }
            }

            double media = 0;

            foreach(int i in nums)
            {
                media += i;
            }
                media = media / nums.Count;

            Console.Write(media + "\n");
            Console.ReadKey();
        }
    }
}
