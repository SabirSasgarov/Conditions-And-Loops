internal class Program
{
	private static void Main(string[] args)
	{
		int a = 0;
		int b = 100;
		int sum = 0;

		for (int i = a; i < b; i++)
		{
			if (i%2==0)
				sum+=i;
		}
		Console.WriteLine("Sum: " + sum);
	}
}