using TesteVaga;

class Program
{
    //Método principal, onde é chamado todas as funções definidas nas outras classes.
    private static void Main()
    {
        int flag = 0;

        while(flag == 0)
        {
            Console.WriteLine("QUAL EXERCICIO DESEJA EXECUTAR?\n#1 - CALCULADORA\n#2 - REPETE-FRASE\n#3 - TESTE 3");
            string exercicio = Console.ReadLine();

            switch (exercicio)
            {
                case "1":
                    flag = 1;
                    Console.Clear();

                    try
                    {
                        var numeros = Ex01.ReadNumbers();
                        var operador = Ex01.MathOperator();
                        Ex01.PerformOperation(numeros, operador);
                    }

                    catch (FormatException)
                    {
                        Ex01.showError("TENTE DIGITAR NÚMEROS APENAS.","S");
                        flag = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        flag = 0;
                    }

                    Console.WriteLine("-----------------------------------------------------");
                    flag = 0;
                    break;

                case "2":
                    flag = 1;
                    Console.Clear();
                    
                    Ex02.ReplaySentence();
                    Console.WriteLine("-----------------------------------------------------");
                    flag = 0;
                    break;

                case "3":
                    flag = 1;

                    Person.Message();
                    Person.MultiplicationNumberRandom();
                    break;

                default:
                    flag = 0;
                    Ex01.showError("OPÇÃO INCORRETA!","S");
                    break;
            }
        }
    }
}