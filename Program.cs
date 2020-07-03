﻿using System;

namespace c_
{
    class Program
    {
        private const byte exercInicial = 1;
        private const byte exercFinal = 9;

        static void Main(string[] args)
        {
            var exerc1 = new Exerc1();
            var exerc2 = new Exerc2();
            var exerc3 = new Exerc3();
            var exerc4 = new Exerc4();
            Byte _opition;

        do{
            System.Console.WriteLine($"\nDigite o número do exercicio que desejar entre {exercInicial} a {exercFinal}, ou número 0 pra sair");
            _opition = Convert.ToByte(System.Console.ReadLine().Substring(0,1));
            System.Console.WriteLine($"Você escolheu o exercício {_opition}:");
            switch (_opition)
            {
                case 1 : exerc1.exe(); break;
                case 2 : exerc2.exe(); break;
                case 3 : exerc3.exe(); break;
                case 4 : exerc4.exe(); break;
                default: _opition =0;  break;
            }

        }while ((_opition != 0) && (_opition <= exercFinal) );
        System.Console.WriteLine("Nº do exercício não encontrado");
        }
    }
}
