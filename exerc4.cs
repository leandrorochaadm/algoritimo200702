namespace c_
{
    public class Exerc4
    {
    public void exe() {
            System.Console.WriteLine(
            "Dado o conjunto de instruções a seguir, faça um algoritmo com quatro\n"+
            "variações, colocando o comando de repetição adequadamente, de forma a:\n");

            System.Console.WriteLine("a. Executar o conjunto 10 vezes;");
            for (int i = 0; i < 10; i++)
            {System.Console.WriteLine("\u00BB "+i);           
            }

            System.Console.WriteLine("b. Não executar nenhuma vez;\n \u00BB ");

            System.Console.WriteLine("c. Executar o conjunto 100 vezes utilizando duas estruturas de repetição;");

            int c =0;
            while (c<50)
            {
                System.Console.WriteLine("\u00BB "+c);   
                c++;
            }

            do
            {
                System.Console.WriteLine("\u00BB "+c);   
                c++;
            } while (c<100);
            

            System.Console.WriteLine("d. Executar N vezes, onde N é uma variável informada pelo usuário.");
            System.Console.Write("Digite um número inteiro: ");
            int d = int.Parse(System.Console.ReadLine());
                int _d = 1;
            
            while (_d<=d)
            {
             System.Console.WriteLine("\u00BB "+_d);   
             _d++;
            }

        } 
    }
}