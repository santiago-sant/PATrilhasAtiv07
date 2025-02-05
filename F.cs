class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um numero :");
			int entrada1 = int.Parse(Console.ReadLine());
			while (entrada1 > 0) {
				Console.WriteLine("Numeros pares entre 0 e " + entrada1);
				for( int i = 0; i <= entrada1; i += 2){
					Console.WriteLine(i);
			}
			
		
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
