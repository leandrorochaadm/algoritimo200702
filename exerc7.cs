using System;
using System.Collections.Generic;
using System.Linq;

namespace c_
{
    public class Exerc7
    {
        public void exe() {
            System.Console.WriteLine(
                "Crie um programa que peça 10 números inteiros e apresente: a média, o maior e o menor.\n"
            );
        int soma= 0;
        int maior= 0;
        int menor= 0;

        for (int i = 1; i <= 10; i++)
        {
         var item = int.Parse(System.Console.ReadLine());
        
        if(i==1){
            soma = item;
            maior = item;
            menor = item;
        } else {
            soma+=item;
            if (maior <item) maior=item;
            if(menor > item) menor = item;
        }
            
        }

        System.Console.WriteLine($"\n\u00BB Resumo dos números digitados: \n - maior: {maior} \n - menor {menor}\n - média {soma/10}");

        } 
    }
}