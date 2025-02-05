class Program
{
    static void Main()
    {
        int soma = 0;

        while (true) 
        {
            Console.Write("Digite um número inteiro positivo (ou um número negativo para sair): ");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero < 0)
                {
                    Console.WriteLine("Número negativo digitado. Encerrando o programa...");
                    break; 
                }

                soma += numero; 
                Console.WriteLine("O número escolhido foi :" + numero);
                Console.WriteLine("A soma da sequência dos números é: " + soma);
            }
            else
            {
                Console.WriteLine("Entrada inválida! Digite um número inteiro.");
            }
        }
    }
}
