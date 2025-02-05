class Program
{
    static void Main()
    {
        Console.Write("Digite uma sequência de números para serem somados : ");
        int soma = 0;
        string input;

        while (true)
        {
            Console.Write("Digite um número: "); 
            input = Console.ReadLine();

          
            if (string.IsNullOrWhiteSpace(input))
            {
                break; 
            }
            

            int numero;
            if (int.TryParse(input, out numero))
            {
                soma += numero;
            }
            else
            {
                Console.WriteLine("Os números são inválidos, por favor digite números válidos.");
            }
        }

        Console.WriteLine("A soma dos números é: " + soma);
        Console.ReadKey();
    }
}
