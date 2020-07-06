﻿using System;

namespace c_
{
    class Program
    {
        private const byte exercInicial = 1;
        private const byte exercFinal = 10;

        static void Main(string[] args)
        {
            var exerc1 = new Exerc1();
            var exerc2 = new Exerc2();
            var exerc3 = new Exerc3();
            var exerc4 = new Exerc4();
            var exerc5 = new Exerc5();
            var exerc6 = new Exerc6();
            var exerc7 = new Exerc7();
            var exerc8 = new Exerc8();
            Byte _opition;

        do{
            System.Console.WriteLine($"\nDigite o número do exercicio que desejar entre {exercInicial} a {exercFinal}, ou número 0 pra sair");
            _opition = Convert.ToByte(System.Console.ReadLine());
            System.Console.WriteLine($"Você escolheu o exercício {_opition}:");
            switch (_opition)
            {
                case 1 : exerc1.exe(); break;
                case 2 : exerc2.exe(); break;
                case 3 : exerc3.exe(); break;
                case 4 : exerc4.exe(); break;
                case 5 : exerc5.exe(); break;
                case 6 : exerc6.exe(); break;
                case 7 : exerc7.exe(); break;
                case 8 : exerc8.exe(); break;
                default: _opition =0;  break;
            }

        }while ((_opition != 0) && (_opition <= exercFinal) );
        System.Console.WriteLine("Nº do exercício não encontrado");
        }
    }
}
