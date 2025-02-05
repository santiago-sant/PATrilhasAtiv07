sing System;

class Program
{
    public static void Main(string[] args)
    {
        int entrada1;

        do
        {
            Console.WriteLine("Digite um número:");
            entrada1 = int.Parse(Console.ReadLine());

            if (entrada1 > 0)
            {
                Console.WriteLine("Números pares entre 0 e " + entrada1);
                for (int i = 0; i <= entrada1; i += 2)
                {
                    Console.WriteLine(i);
                }
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

        } while (entrada1 > 0);
    }
