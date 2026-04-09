class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penamabahan(a, b));
		Console.WriteLine("Hasil Penambahan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
		
		Console.WriteLine("h";
		Console.ReadKey();
		
	}
	
	static int Penamabahan(int a, int b)
	{
		return a + b;
	}
	
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
}