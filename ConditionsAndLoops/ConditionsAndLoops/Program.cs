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
		//int a = 13;
		//int count = 0;
		//for(int i=2; i<a/2; i++)
		//{
		//	if (a % i == 0)
		//		count++;
		//}
		//if(count>0)
		//	Console.WriteLine("Murekkeebdir");
		//else
		//	Console.WriteLine("Sadedir");


		//3
		//int a = 5641;
		//int mertebe;
		//while (a > 0){
		//	mertebe = a % 10;
		//	Console.WriteLine($"Mertebeler: {mertebe}");
		//	a /= 10;
		//}


		//4
		//int a = 8;

		//for (int i=0; ;i++) { 
		//
		//
		//}


		//5
		//int m = 54;
		//int count = 0;
		//for(int i=1; i < m; i++)
		//{
		//	if (i % 3 == 0)
		//		count++; 
		//}
		//Console.WriteLine(count);


		//6
		//int num=6;
		//for(int i = 1; i <= num; i++)
		//{
		//	if(num%i==0)
		//		Console.Write(i+" ");
		//}


		//7



		//8
		int n=2315;
		int lastNumber;
		int multiple=1;
		while (n > 0)
		{
			lastNumber = n % 10;
			n /= 10;
			multiple *= lastNumber;
		}
		Console.WriteLine(multiple);


		//9




		//10
		//int x =5;
		//int y =5;
		//int z =5;
		//if(x==y && y==z)
		//	Console.WriteLine("her biri beraberdir");
		//else if(x<=y && x<=z)
		//	Console.WriteLine("en kicik xdir");
		//else if (y <= x && y <= z)
		//	Console.WriteLine("en kicik ydir");
		//else
		//	Console.WriteLine("en kicik zdir");
	}
}