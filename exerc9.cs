namespace c_
{
    public class Exerc9
    {
        public void exe() {
            System.Console.WriteLine(
         "Foi realizada uma pesquisa de algumas características físicas da\n"+
        "população de uma certa região, a qual coletaram os seguintes dados\n"+
        "referentes a cada habitante para serem analisados:\n"+
        "a. sexo (masculino e feminino)\n"+
        "b. cor dos olhos (azuis, verdes ou castanhos) - cor dos cabelos\n"+
        "(louros, castanhos, pretos)\n"+
        "c. idade\n"+
        "Faça um algoritmo que determine e escreva:\n"+
        "d. a maior idade dos habitantes;\n"+
        "e. a quantidade de indivíduos do sexo feminino cuja idade está\n"+
        "entre 18 e 35 anos, inclusive;\n"+
        "f. a quantidade de indivíduos que tenham olhos verdes e cabelos louros;\n"+
        "Para encerrar o programa peça ao usuário para digitar -1." );

        string _option ="";
        int maiorIdade=0;
        int quantFem=0;
        int quantLoiro=0;
    
        do
        {
            System.Console.WriteLine("\nDeseja inserir dados um habitante, Digite '-1' pra sair, ou tecle <Enter> pra continuar" );
            _option = System.Console.ReadLine().ToLower();

            if(_option!="-1"){
                System.Console.WriteLine("Digite a cor dos olhos: \n'a' p/ azul \n'v' p/ verdes \n'c' p/ castanhos");
                var corOlhos = (System.Console.ReadLine().Substring(0,1).ToLower());
                System.Console.WriteLine("Digite a cor do cabelo: \n'l' p/ loiro \n'p' p/ preto \n'c' p/ castanhos");
                var corCabelo = (System.Console.ReadLine().Substring(0,1).ToLower());
                System.Console.WriteLine("Digite a idade");
                var idade = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Digite o sexo: \n'm' p/ masculino \n'f' p/ feminino");
                var sexo = (System.Console.ReadLine().ToLower());

                if(maiorIdade<idade) maiorIdade=idade;
                if(sexo=="f"&&idade>18&&idade<35) quantFem++;
                if(corCabelo=="l"&&corOlhos=="v") quantLoiro++;
            }
        } while (_option != "-1");
            System.Console.WriteLine($"\n Quantidade de indivíduos que tenham olhos verdes e cabelos louros Resumo da pesquisa dos habitantes:\n\u00BB Maior idade: {maiorIdade} \n\u00BB A quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos: {quantFem} \n\u00BB Quantidade de indivíduos que tenham olhos verdes e cabelos louros: {quantLoiro}");

        }
    }
}