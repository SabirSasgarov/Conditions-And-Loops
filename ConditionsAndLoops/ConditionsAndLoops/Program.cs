using System.ComponentModel;

internal class Program
{
	private static void Main(string[] args)
	{
		//1
		int a = 0;
		int b = 100;
		int sum = 0;
		for (int i = a; i < b; i++)
		{
			if (i % 2 == 0)
				sum += i;
		}
		Console.WriteLine("Sum: " + sum);


		//2
		int number = 29;
		int count = 0;
		for (int i = 2; i < number / 2; i++)
		{
			if (number % i == 0)
			{
				count++;
				break;
			}
		}
		if (count > 0)
			Console.WriteLine("Murekkeebdir");
		else
			Console.WriteLine("Sadedir");


		//3
		int a3 = 5641;
		int mertebe;
		while (a3 > 0)
		{
			mertebe = a3 % 10;
			Console.WriteLine($"Mertebeler: {mertebe}");
			a3 /= 10;
		}


		//4
		int a4 = Convert.ToInt32(Console.ReadLine());
		bool quvvetir = true;
		while (a4 > 1)
		{
			if (a4 % 2 == 1)
			{
				Console.WriteLine("Quvveti deyil");
				quvvetir = false;
				break;
			}
			a4 /= 2;
		}
		if (quvvetir)
			Console.WriteLine("Quvvetidir");


		//5
		int m = 54;
		int count2 = 0;
		for (int i = 1; i < m; i++)
		{
			if (i % 3 == 0)
				count2++;
		}
		Console.WriteLine(count2);


		//6
		int num = 6;
		for (int i = 1; i <= num; i++)
		{
			if (num % i == 0)
				Console.Write(i + " ");
		}


		//7
		int x = 5;
		int y = 17;
		int ebob = -1;
		for (int i = 2; i <= x; i++)//bütün rəqəmlər 1ə bölündüyü üçün i=2 yazmışam
		{
			if (y % i == 0)
				ebob = i;
		}
		Console.WriteLine("\n"+ebob);


		//8
		int n = 2315;
		int lastNumber;
		int multiple = 1;
		while (n > 0)
		{
			lastNumber = n % 10;
			n /= 10;
			multiple *= lastNumber;
		}
		Console.WriteLine(multiple);


		//9
		int mehsul1 = 20;
		int mehsul2 = 40;
		int mehsul3 = 50;
		if (mehsul1 == mehsul2 && mehsul2 == mehsul3)
			Console.WriteLine(mehsul1 + mehsul2);
		else if (mehsul1 <= mehsul2 && mehsul1 <= mehsul3)
			Console.WriteLine(mehsul2 + mehsul3);
		else if (mehsul2 <= mehsul1 && mehsul2 <= mehsul3)
			Console.WriteLine(mehsul1 + mehsul3);
		else
			Console.WriteLine(mehsul1 + mehsul2);


		//10
		int X = 9;
		int Y = 51;
		int Z = 6;
		if (X == Y && Y == Z)
			Console.WriteLine("her biri beraberdir");
		else if (X <= Y && X <= Z)
			Console.WriteLine("en kicik x-dir");
		else if (Y <= X && Y <= Z)
			Console.WriteLine("en kicik y-dir");
		else
			Console.WriteLine("en kicik z-dir");
	}
}