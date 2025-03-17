//#define Arrays_4_1
#define Arrays_4_2

using System;

#if Arrays_4_1
class Arrays_4_1
{
	static void Main()
	{
		Console.WriteLine("Написать программу, в которой создаётся одномерный числовой массив и заполняется " +
			"числами,\nкоторые при делении на 5 дают в остатке 2 (числа 2,7,12,17 и т.д)");
		try
		{
			Console.WriteLine("Введите размер массива: ");
			int size = Int32.Parse(Console.ReadLine());
			int[] nums = new int[size];
			for (int i = 0; i < size; i++)
			{
				nums[i] = 5 * i + 2;
				Console.Write("| " + nums[i] + " ");
			}
			Console.WriteLine("|");
		}
		catch
		{
			Console.WriteLine("You entered the wrong value!");
		}
	}
} 
#endif
#if Arrays_4_2
class Arrays_4_2
{
	static void Main()
	{
		Console.WriteLine("Написать программу, в которой создаётся массив из 11 целочисленных элементов.\n" +
			"Массив заполняется степенями двойки - числами 2^0=1;2^1=2;2^2=4;2^3=8 и так далее до 2^10=1024\n" +
			"При заполнении массива учесть, что начальный элемент равен 1, а каждый следующий больше предыдущего в 2 раза.");
		int size = 11;
		int[] nums = new int[size];
		for (int i = 0; i < size; i++)
		{
			if (i == 0)
			{
				nums[i] = 1;
			}
			else
			{
				nums[i] = nums[i-1] * 2;
			}
			Console.WriteLine($"2^{i}\t= " + nums[i]);
		}
		for (int i = 9; i >= 0; i--)
		{
			if(i == 0) nums[i] = 1;
			Console.WriteLine($"2^{i}\t= " + nums[i]);
		}
	}
}
#endif
