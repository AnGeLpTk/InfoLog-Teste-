namespace TesteVaga
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int cpf { get; set; }

        public static void Message()
        {
            Console.WriteLine("Let's GO");
        }

        public static void MultiplicationNumberRandom()
        {
            int number1 = 20;
            int number2 = 30;

            Console.WriteLine($"O resultado é: {number1 + number2} ");
        }
    }
}
