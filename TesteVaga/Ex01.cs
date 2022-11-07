namespace TesteVaga
{
    class Ex01
    {
        //Método que vai ler os números digitados e retornar uma lista de double
        public static List<double> ReadNumbers()
        {
            double primeiroNumero = 0;
            double segundoNumero = 0;
            int flag = 0;

            Console.WriteLine("== CALCULADORA ==");

            while (flag == 0)
            {
                Console.WriteLine("Digite o primeiro número: ");
                primeiroNumero = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                segundoNumero = Convert.ToDouble(Console.ReadLine());

                if (primeiroNumero == 0 && segundoNumero == 0)
                {
                    flag = 0;
                    showError("OS DOIS NÚMEROS NÃO PODEM SER ZERO(0)","S");
                }
                else
                {
                    flag = 1;
                }
            }
            return new List<double> { primeiroNumero, segundoNumero };
        }

        //Método que faz a leitura do operador
        public static string MathOperator()
        {
            Console.WriteLine("Digite o operador da conta (+ - / ou *) CASO NENHUM SEJA SELECIONADO, SERÁ CONSIDERADO VÁLIDO TODOS!");
            string operador = Console.ReadLine();

            return operador;
        }

        //Método que realiza a operação mátematica com base no Input do usuário.
        public static void PerformOperation(List<double> numeros, string operador)
        {
            switch (operador)
            {
                case "+":
                    Console.WriteLine($"O resultado da soma entre {numeros[0]} e {numeros[1]}: é {numeros[0] + numeros[1]}");
                    break;

                case "-":
                    Console.WriteLine($"O resultado da subtração entre {numeros[0]} e {numeros[1]}: é {numeros[0] - numeros[1]}");
                    break;

                case "*":
                    Console.WriteLine($"O resultado da multiplicação entre {numeros[0]} e {numeros[1]}: é {numeros[0] * numeros[1]}");
                    break;

                case "/":
                    if (numeros[1] == 0 && operador == "/")
                    {
                        showError($"NÃO É POSSÍVEL DIVIDIR {numeros[0]} POR ZERO","S");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"O resultado da divisão entre {numeros[0]} e {numeros[1]}: é {numeros[0] / numeros[1]}");
                        break;
                    }

                default:
                    Console.WriteLine($"O resultado da soma entre {numeros[0]} e {numeros[1]}: é {numeros[0] + numeros[1]}");
                    Console.WriteLine($"O resultado da subtração entre {numeros[0]} e {numeros[1]}: é {numeros[0] - numeros[1]}");
                    Console.WriteLine($"O resultado da multiplicação entre {numeros[0]} e {numeros[1]}: é {numeros[0] * numeros[1]}");
                    if (numeros[1] == 0)
                    {
                        showError($"NÃO É POSSÍVEL DIVIDIR {numeros[0]} POR ZERO","N");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"O resultado da divisão entre {numeros[0]} e {numeros[1]}: é {numeros[0] / numeros[1]}");
                    }
                    break;
            }
        }

        //Método que exibe o erro com coloração diferente.
        public static void showError(string message, string clear)
        {
            if(clear == "S")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }
    }
}
