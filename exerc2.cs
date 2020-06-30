using System;
using System.Collections.Generic;

namespace c_
{
    public class Exerc2
    {
        public void exe() {
            System.Console.WriteLine(
                "Construa um Algoritmo que, para um grupo de 50 valores inteiros,\n"+
                "determine:\n"+
                "a. A soma dos números positivos;\n"+
                "b. A quantidade de valores negativos;\n"
            );

            int num = 0;
            int somaPositivos = 0;
            int quantNegativos = 0;

            Random randNum = new Random();
            List<int> list = new List<int>();
            for (int i = 1; i <= 50; i++)
            {
            num = randNum.Next(-1000,1000);
            list.Add(num);
            somaPositivos += num > 0 ? num : 0;
            quantNegativos += num >0 ? 1 :0;
            //  System.Console.WriteLine(num>=0? num : 0);
            //  System.Console.WriteLine(soma);
            }
            System.Console.WriteLine($"Lista com {list.Count} números aleatórios:");
            var str = string.Join(", ", list.ToArray());
             System.Console.WriteLine(str);
            System.Console.WriteLine($"\n\u00BB O total da soma dos números positivos é {somaPositivos}");
            System.Console.WriteLine($"\u00BB A quantidade de números negativos é {quantNegativos}");

        } 
    }
}