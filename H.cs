using System;

class Program
{
    static void Main()
    {
        int numero;

        do
        {
            Console.Write("Digite um número inteiro: ");

            
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                break; 
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro válido.");
            }

        } while (true); 

        Console.WriteLine("Tabuada do número é:");

    
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
            Console.ReadKey();
        }
    }
}
