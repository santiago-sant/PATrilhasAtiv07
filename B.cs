class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um numero :");
			int entrada1 = int.Parse(Console.ReadLine());
			while (entrada1 > 0) {
				Console.WriteLine("A tabuada desse numero " + entrada1 + " :");
				for( int i = 1; i <= 10; i ++){
					Console.WriteLine(i*entrada1);
			}
			
		
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
