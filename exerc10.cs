namespace c_
{
    public class Exerc10
    {
        public void exe() {
            System.Console.WriteLine(
            "Faça um algoritmo que calcule 4 notas do aluno, com as seguintes opções:\n"+
            "a. Aprovado se nota maior ou igual a 60;\n"+
            "b. De exame final se nota menor que 60;"
            );

            for (int i = 1; i <= 4; i++)
            {
                System.Console.WriteLine($"\nVoçê irá digitar os dados do aluno {i} de 4");
                System.Console.WriteLine("Digite a nota entre 0 e 100");
                double nota = double.Parse(System.Console.ReadLine());

                if(nota<=60) {System.Console.WriteLine("\n\u00BB Aluno aprovado");}
                else {System.Console.WriteLine("\n\u00BB Aluno de exame");}
            }

        } 
    }
}