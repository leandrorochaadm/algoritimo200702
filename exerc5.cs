using System;
using System.Collections.Generic;

namespace c_
{
    public class Exerc5
    {
        public void exe() {
            System.Console.WriteLine(
                "Some os números de 1 a 100 e imprima o valor.\n"
            );

            Random randNum = new Random();
            List<double> listAltura = new List<double>();
            for (int i = 1; i <= 45; i++)
            {
            double altura = randNum.NextDouble()*(1.7-1.2)+1.2; //gerando double aleátorios entre 1.2 a 1.7
            listAltura.Add(altura);
            }
            var strAltura = string.Join(", ", listAltura.ToArray());

            double somaAltura=0.0;
            int quantAltura = 0;
            foreach (var item in listAltura)
            {
                if(item <1.7) somaAltura+=item; //na verdade nem precisava dessa verificação, pois o range de altura já está limitando
                quantAltura++;
            }

            var mediaAltura = somaAltura/quantAltura;

            System.Console.WriteLine($"\n\u00BB lista de idades: {strAltura}");
            System.Console.WriteLine($"\n\u00BB idade média dos alunos com menos de 1,70m de idade é {mediaAltura.ToString("0.00")}");

            List<int> listIdade = new List<int>();
            for (int i = 1; i <= 45; i++)
            {
            int idade = randNum.Next(18,60);  //gerando int aleátorios entre 1.2 a 1.7
            listIdade.Add(idade);
            }
            var strIdade = string.Join(", ", listIdade.ToArray());

            int somaIdade=0;
            int quantIdade = 0;
            foreach (var item in listIdade)
            {
                if(item >20) somaIdade+=item; 
                quantIdade++;
            }

            var mediaIdade = somaIdade/quantIdade;

            System.Console.WriteLine($"\n\u00BB lista de idades: {strIdade}");
            System.Console.WriteLine($"\n\u00BB idade média dos alunos com menos de 1,70m de idade é {mediaIdade}");

        } 
    }
}