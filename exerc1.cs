namespace c_
{
    public class Exerc1
    {
        public void exe() {
            System.Console.WriteLine(
                "Some os números de 1 a 100 e imprima o valor.\n"
            );

            int num = 0;
            for (int i = 1; i <= 100; i++)
            {
             num+=i;
             System.Console.WriteLine($"Número atual é {i}, número atual somado com o anterior é {num}");   
            }
            System.Console.WriteLine($"\u00BB O número total é {num}");

        } 
    }
}