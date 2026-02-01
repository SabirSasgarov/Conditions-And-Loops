using System.ComponentModel;

internal class Program
{
	private static void Main(string[] args)
	{
		//1
		//int a = 0;
		//int b = 100;
		//int sum = 0
		//for (int i = a; i < b; i++)
		//{
		//	if (i % 2 == 0)
		//		sum += i;
		//}
		//Console.WriteLine("Sum: " + sum);


		//2
		//int a = 29;
		//int count = 0;
		//for (int i = 2; i < a / 2; i++)
		//{
		//	if (a % i == 0)
		//	{
		//		count++;
		//		break;
		//	}
		//}
		//if (count > 0)
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
		//int a = Convert.ToInt32(Console.ReadLine());
		//bool quvvetir = true;
		//while (a > 1)
		//{
		//	if (a % 2 == 1)
		//	{
		//		Console.WriteLine("Quvveti deyil");
		//		quvvetir = false;
		//		break;
		//	}
		//	a /= 2;
		//}
		//if (quvvetir)
		//	Console.WriteLine("Quvvetidir");


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
		//int x = 5;
		//int y = 17;
		//int ebob = -1;
		//for (int i = 2; i <= x; i++)//bütün rəqəmlər 1ə bölündüyü üçün i=2 yazmışam
		//{
		//	if (y % i == 0)
		//		ebob = i;
		//}
		//Console.WriteLine(ebob);


		//8
		//int n=2315;
		//int lastNumber;
		//int multiple=1;
		//while (n > 0)
		//{
		//	lastNumber = n % 10;
		//	n /= 10;
		//	multiple *= lastNumber;
		//}
		//Console.WriteLine(multiple);


		//9
		//int mehsul1 = 20;
		//int mehsul2 = 40;
		//int mehsul3 = 50;
		//if (mehsul1 == mehsul2 && mehsul2 == mehsul3)
		//	Console.WriteLine(mehsul1 + mehsul2);
		//else if (mehsul1 <= mehsul2 && mehsul1 <= mehsul3)
		//	Console.WriteLine(mehsul2 + mehsul3);
		//else if (mehsul2 <= mehsul1 && mehsul2 <= mehsul3)
		//	Console.WriteLine(mehsul1 + mehsul3);
		//else
		//	Console.WriteLine(mehsul1 + mehsul2);


		//10
		//int x = 9;
		//int y = 51;
		//int z = 6;
		//if (x == y && y == z)
		//	Console.WriteLine("her biri beraberdir");
		//else if (x <= y && x <= z)
		//	Console.WriteLine("en kicik x-dir");
		//else if (y <= x && y <= z)
		//	Console.WriteLine("en kicik y-dir");
		//else
		//	Console.WriteLine("en kicik z-dir");
	}
}