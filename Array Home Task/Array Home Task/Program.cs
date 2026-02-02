using System.Numerics;
using System.Runtime.InteropServices;

internal class Program
{
	private static void Main(string[] args)
	{
		#region region1
		//Verilmiş Arrayın elementlərinin cəmini ekrana çap edin
		//int[] numbers = [15, 17, 45, 62, 51, 78, 94, 44];
		//int sum = 0;
		//for (int i = 0; i < numbers.Length; i++)
		//	sum += numbers[i];
		//Console.WriteLine($"Ededlerin cemi: {sum}");
		#endregion

		#region region2
		//Verilmiş int Arrayın ən böyük dəyərə sahib elementini tapın
		//int[] numbers = [15, 78, 54, 6, 30,71, 45, 32];
		//int max = numbers[0];
		//for (int i=0; i<numbers.Length ;i++) {
		//	if (max<numbers[i])
		//		max = numbers[i];	
		//}
		//Console.WriteLine($"En boyuk: {max}");
		#endregion

		#region region3
		//Verilmiş Arrayın ilk və son elementlərinin cəmini tapın
		//int[] numbers = [15,45,78,95,64,21,31,73];
		//Console.WriteLine($"Ilk eded: {numbers[0]}, Son eded {numbers[numbers.Length-1]}.\n"+
		//	$"Cemi: {numbers[0] + numbers[numbers.Length-1]}");
		#endregion

		#region region4
		//Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın
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


		#endregion

		#region region5
		//Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5
		//int number = -452;
		//int n = number;
		//int counter = 0;
		//if (n == 0)
		//{
		//	counter = 1;
		//}
		//else
		//{
		//	while (n > 0 || n < 0)
		//	{
		//		n = n / 10;
		//		counter++;
		//	}
		//}

		//Console.WriteLine($"{number} ededi {counter} mertebelidir.");
		#endregion

		#region region6
		//Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiryi
		//indexi tapan alqoritm(meselen 50 axtaririq egər siyahıda 50 ədədi yoxdursa -1 print
		//olsun, varsa var olduğu index)
		//int[] numbers = [5,7,12,24,56,75,84,95,105,115];
		//Console.WriteLine("Axtardiqiniz ededi daxil edin:");
		//int axtardiqiReqem = int.Parse(Console.ReadLine());
		//int find = -1;
		//for (int i=0;i<numbers.Length;i++)
		//{
		//	if (axtardiqiReqem == numbers[i]) {
		//		find = i;
		//		break;
		//	}
		//}
		//if (find != -1)
		//	Console.WriteLine($"Axtardiqiniz reqemin indexi: {find}");
		//else
		//	Console.WriteLine(find);
		#endregion

		#region region7
		//Tam ədədlər ardıcıllığı verilir.
		//Ardıcıllığın hər bir mənfi olmayan elementini 2 vahid artırmalı.
		//int[] numbers = [5, 7, -4, 12, 0, 24, -84,56, 75,-54, 84, 95,-51, 105, -115];
		//Console.WriteLine("Yeni array: ");
		//for (int i=0;i<numbers.Length;i++){
		//	if (numbers[i] >= 0)
		//		numbers[i] += 2;
		//	Console.Write(numbers[i] + " ");
		//}
		#endregion

		#region region8
		//Verilmiş array-da müəyyən bir elementin neçə dəfə təkrarlandığını tapın.
		//int[] numbers = [1,2,2,3,4,5,2,7,2,8,1,8,4,5,9,9,9,9,9,9];
		//Console.WriteLine("Eded daxil edin: ");
		//int eded = int.Parse(Console.ReadLine());
		//int count = default;
		//for (int i = 0; i<numbers.Length; i++)
		//{
		//	if (eded == numbers[i])
		//		count++;
		//}
		//if(count==0)
		//	Console.WriteLine("Axtardaginiz eded yoxdur");
		//else
		//	Console.WriteLine($"Axtardiginiz eded {count} defe tekrarlanir");
		#endregion

		#region region9
		//Verilmiş array-ı tərsinə çap edin.
		//int[] numbers = [1, 2, 3, 4];
		//for (int i = numbers.Length-1; i >=0; i--)
		//{
		//	Console.Write(numbers[i]+" ");
		//}
		#endregion

		#region region10
		//Verilmiş massivin ən kiçik elementini çıxışa verən proqram yazın
		//int[] numbers = [4, 2, 3, 4, 9, 5, 7, 4, 1, 10];
		//int min = numbers[0];
		//for (int i = 0; i < numbers.Length; i++)
		//{
		//	if (numbers[i]<min)
		//		min = numbers[i];
		//}
		//Console.WriteLine($"Verilmis massivin en kicik elementi {min}.");
		#endregion
		
	}
}