using System;

class Program
{
    static void Main()
    {
        int numero;

        do
        {
            Console.Write("Digite um número inteiro: ");

            // Converte o valor inserido em inteiro
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                break; // Sai do loop se a entrada for válida
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro válido.");
            }

        } while (true); // Repete até o usuário inserir um número válido

        Console.WriteLine("Tabuada do número é:");

        // Exibe a tabuada do número até 10
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
            Console.ReadKey();
        }
    }
}
