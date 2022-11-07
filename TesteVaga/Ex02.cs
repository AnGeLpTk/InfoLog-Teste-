using TesteVaga;

namespace TesteVaga
{
    class Ex02
    {
        public static void ReplaySentence()
        {
            int flag = 0;

            while (flag == 0)
            {
                Console.WriteLine("== REPETE FRASE PTK ==");
                Console.WriteLine("Digite a frase que deseja repetir");
                string frase = Console.ReadLine();
                Console.WriteLine("Qual estrutura de repetição deseja utilizar\n#1- FOR\n#2- WHILE");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        flag = 1;
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(frase);
                        }
                        break;

                    case "2":

                        flag = 1;
                        int numberRepeting = 0;
                        while (numberRepeting <= 10)
                        {
                            Console.WriteLine(frase);
                            numberRepeting++;
                        }
                        break;

                    default:
                        Ex01.showError("DIGITE UMA OPÇÃO VÁLIDA!","S");
                        flag = 0;
                        break;
                }
            }   
        }
    }
}
