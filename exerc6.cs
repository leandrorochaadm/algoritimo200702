using System;
using System.Collections.Generic;
using System.Linq;

namespace c_
{
    public class Exerc6
    {
        public void exe() {
            System.Console.WriteLine(
            "Faça um algoritmo que calcule a média de salários de uma empresa,\n"+
            "pedindo ao usuário a quantidade de funcionários, o nome e o salário\n"+
            "de cada funcionário e devolvendo a média, o salário mais alto e o\n"+
            "salário mais baixo.\n"
            );

        List<String> listNome = new List<String>();
        List<double> listSalario = new List<double>();
        double soma = 0.0;


        System.Console.WriteLine("Quantos funcionários deseja adicionar?");
        int length = int.Parse(System.Console.ReadLine());
        for (int i = 1; i <= length; i++)
        {
        System.Console.WriteLine($"\n\u00BB Voçê irá digitar os dados do funcionário {i} de {length}");

         System.Console.WriteLine("Digite o nome do funcionário");
         var nome = System.Console.ReadLine();
         listNome.Add(nome);
        //   System.Console.WriteLine(listNome);

         System.Console.WriteLine("Digite o salário do funcionário");
         var salario = double.Parse(System.Console.ReadLine());
         listSalario.Add(salario);
        }

        System.Console.WriteLine($"\n\u00BB Infomações dos salários dos funcionários: \n - Maior: {listSalario.Max()} \n - Menor: {listSalario.Min()} \n - Média: {listSalario.Average()}");

        } 
    }
}