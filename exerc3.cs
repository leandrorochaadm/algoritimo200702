namespace c_
{
    public class Exerc3
    {
    public void exe() {
            System.Console.WriteLine(
            "Faça um algoritmo que imprima todos os números pares\n"+
            "compreendidos entre 85 e 907. O algoritmo deve também calcular a\n"+
            "soma destes valores.\n"
            );

            int num = 0;
            for (int i = 86; i < 907; i++)
            {
            int temp = i % 2 != 0 ? 0 : i;
             num+= temp;
            if(temp != 0) System.Console.WriteLine($"o número {i} é par, o resultado dele somado com os anteriores é {num}");   
            }
            System.Console.WriteLine($"\u00BB O número total de números pares é {num}");

        } 
    }
}