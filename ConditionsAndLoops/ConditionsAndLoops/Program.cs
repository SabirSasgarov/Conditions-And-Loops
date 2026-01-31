internal class Program
{
	private static void Main(string[] args)
	{
		//1
		//int a = 0;
		//int b = 100;
		//int sum = 0;

		//for (int i = a; i < b; i++)
		//{
		//	if (i % 2 == 0)
		//		sum += i;
		//}
		//Console.WriteLine("Sum: " + sum);


		//2
		int a = 13;
		int count = 0;
		for(int i=2; i<a/2; i++)
		{
			if (a % i == 0)
				count++;
		}
		if(count>0)
			Console.WriteLine("Murekkeebdir");
		else
			Console.WriteLine("Sadedir");



	}
}