class Program
{
    static void Main()
    {
        Console.WriteLine("Crie uma senha: ");
        string entrada1 = Console.ReadLine();

        int tentativas = 0;
        const int limite = 3;

        while (tentativas < limite)
        {
            Console.WriteLine("Informe a senha: ");
            string senha = Console.ReadLine();

            if (senha == entrada1)
            {
                Console.WriteLine("Acesso permitido!");
                return; 
            }
            else
            {
                tentativas++;
                if (tentativas < limite)
                {
                    Console.WriteLine($"Senha incorreta! Tentativas restantes: {limite - tentativas}");
                }
            }
        }

        Console.WriteLine("Número máximo de tentativas atingido. Acesso bloqueado!");
    }
}
