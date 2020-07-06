namespace c_
{
    public class Exerc8
    {
        public void exe() {
            System.Console.WriteLine(
         "Faça um algoritmo que calcule e imprime a soma dos inteiros de 1 a\n"+
        "10. Utilize as estruturas ENQUANTO-FACA / REPITA-FACA para\n"+
        "fazer um laço com as instruções de cálculo e incremento. O laço deve\n"+
        "terminar quando o valor de x se tornar 11." );

System.Console.WriteLine("ENQUANTO-FACA");
        int x =0;
        while (x<11)
        {
            x++;
            System.Console.WriteLine(x);
        }
        
        System.Console.WriteLine("REPITA-FACA ");
        x=0;
        do
        {
            x++;
            System.Console.WriteLine(x);
    
        } while (x<11);
        } 
    }
}