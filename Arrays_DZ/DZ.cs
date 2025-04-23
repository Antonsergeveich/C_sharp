//#define Arrays_4_1
//#define Arrays_4_2
//#define Arrays_4_3
//#define Arrays_4_4
//#define Arrays_4_5
//#define Arrays_4_6
//#define Arrays_4_6_BubbleSort
//#define Arrays_4_6_CocktailSort
//#define Arrays_4_6_InsertionSort
//#define Arrays_4_6_InsertionSort_2
//#define Arrays_4_6_SelectionSort
#define Arrays_4_6_Merge_Sort
//#define Array_4_6_QuickSort


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

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
#if Arrays_4_3
class Arrays_4_3
{
	static void Main()
	{
		//Написать программу, в которой создаётся одномерный символьный массив их 10 элементов.
		//Массив заповлняется буквами "через одну", начиная с буквы 'a':
		//то есть массив заполняется буквами 'a', 'c', 'e','g' и т.д.
		int size = 10;
		int i = 97; //'a'
		char[] symbs = new char[size];
		for (int j = 0; j < size; j++)
		{
			symbs[j] = (char)i;
			i += 2;
			Console.Write(symbs[j] + " ");
		}
		Console.WriteLine();
		for (int j = size - 1; j >= 0; j--)
		{
			symbs[j] = (char)(i - 2);
			i -= 2;
			Console.Write(symbs[j] + " ");
		}
		Console.ReadKey();

		//char[] arr = Enumerable.Range(0, 10).Select(x => (char)('a' + x * 2)).ToArray();
		/*метод Enumerable.Range() генерирует последовательность из 10 целых чисел, начиная с 0.
		Затем используется метод Select() для манипуляции этими значениями.
		Внутри метода каждое сгенерированное число (x) умножается на 2 (x * 2).*/
		//Console.WriteLine(string.Join(" ", arr)); //String.Join() — метод в C#, который объединяет элементы с указанием разделителя.
		//Console.ReadKey();
	}
}
#endif
#if Arrays_4_4
class Arrays_4_4
{
	static void Main()
	{
		/*Написать программу, в которой создаётся символьный массив из элементов английского алфавита.
		Массив заполнить большими прописными буквами английского алфавита. 
		Буквы берутся подряд, но только согласные(тоесть гласные буквы 'A','E','I'
		при присваивании значений элементам массива нужно пропустить)*/
		char[] symbs = new char[26];
		int i = 65; //'A'
		string vowels = "AEIOUY";
		int count = 1;
		int count_vowels = 0;
		for (int j = 0; j < symbs.Length; j++, count++, i++)
		{
			symbs[j] = (char)i;
			Console.Write(symbs[j] + " = " + count + "\t");
			if (vowels.Contains(symbs[j]))
			//Метод Contains() в C# возвращает true, если коллекция содержит определённый элемент, и false в противном случае.
			//https://learn.microsoft.com/ru-ru/dotnet/api/system.string.contains?view=net-8.0
			{
				Console.WriteLine();
				continue;
			}
			count_vowels++;
			Console.WriteLine(symbs[j] + " = " + count_vowels);
		}
		Console.WriteLine("==================================");
	}
}
#endif
#if Arrays_4_5
class Arrays_4_5
{
	static void Main()
	{
		/*Написать программу, в которой создаётся массив и заполняется случайными числами.
		Массив отображается в консольном окне. В этом массиве необходимо определить элемент с минимальным значением.
		В частности, программа должна вывести элемент с минимальным значением и индекс этого элемента.
		Если элементов с минимальным значением несколько, должны быть выведены индексы всех этих элементов.*/
		Random rnd = new Random();
		Console.Write("Введите размер массива: ");
		int size = Int32.Parse(Console.ReadLine());
		int[] numbers = new int[size];
		for (int i = 0; i < numbers.Length; i++)
		{
			numbers[i] = rnd.Next(8, 17); //https://learn.microsoft.com/ru-ru/dotnet/api/system.random.next?view=net-8.0
			if (i % 8 == 0) Console.WriteLine();
			Console.Write(numbers[i] + "\t|");
		}
		Console.WriteLine();
		int value = numbers[0];
		for (int i = 0; i < numbers.Length; i++)
		{
			if (numbers[i] < value)
				value = numbers[i];
		}
		Console.WriteLine("Значение минимального элемента:\t" + value);
		Console.Write("Индексы минимального элемента:\t");
		for (int i = 0; i < numbers.Length; i++)
		{
			if (numbers[i] == value) 
			{
				Console.Write(i + " ");
			}
		}
		Console.WriteLine();
		Console.ReadKey();
	}
}
#endif
#if Arrays_4_6
class Arrays_4_6
{
	static void Main()
	{
		/*Написать программу, в которой создаётся целочисленный массив,
		 заполняется случайными числами и после этого значения элементов в массиве
		 сортируются в порядке убывания значений.*/
		Console.Write("Введите размер массива: ");
		int size = Int32.Parse(Console.ReadLine());
		int[] nums = new int[size];
		Random rnd = new Random();
		for (int i = 0; i < nums.Length; i++)
		{
			nums[i] = rnd.Next(8, 129); 
			Console.Write(nums[i] + "\t|");
		}
		Console.WriteLine();
		Array.Sort(nums);
		for (int i = 0; i < nums.Length; i++)
		{
			Console.Write(nums[i] + "\t|");
		}
		Console.ReadKey();
	}
}
#endif
#if Arrays_4_6_BubbleSort
class Arrays_4_6_1
{
	static void Main()
	{
		Console.Write("Введите размер массива: ");
		int size = Int32.Parse(Console.ReadLine());
		int[] nums = new int[size];
		Random rnd = new Random();
		for (int i = 0; i < nums.Length; i++)
		{
			nums[i] = rnd.Next(8, 129);
			Console.Write(nums[i] + "\t");
		}
		Console.WriteLine();
		BubbleSort(nums);
		//for (int i = 1; i < nums.Length; i++)
		//{
		//	for (int j = 0; j < nums.Length - i; j++)
		//	{
		//		if (nums[j] < nums[j+1])
		//		{
		//			int buffer = nums[j + 1];
		//			nums[j+1] = nums[j];
		//			nums[j] = buffer;
		//		}
		//	}
		//}
		//for(int i = 1; i < nums.Length; i++)
		//{
		//	for(int j = 0; j < nums.Length - i; j++)
		//	{
		//		if (nums[j] > nums[j + 1])
		//		{
		//			int buffer = nums[j+1];
		//			nums[j+1] = nums[j];
		//			nums[j] = buffer;
		//		}
		//	}
		//}
		//for(int i = 0; i < nums.Length - 1; i++)
		//{
		//	for(int j = 0; j < nums.Length - i - 1; j++)
		//	{
		//		if (nums[j] > nums[j + 1])
		//		{
		//			int buffer = nums[j+1];
		//			nums[j+1] = nums[j];
		//			nums[j] = buffer;
		//		}
		//	}
		//}
		for (int i = 0; i < nums.Length; i++)
		{
			Console.Write(nums[i] + "\t");
		}
		Console.WriteLine();
	}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length - 1; i++)
	//	{
	//		for(int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length - 1; i++)
	//	{
	//		for(int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length - 1; i++)
	//	{
	//		for(int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length - 1; i++)
	//	{
	//		for (int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length - 1; i++)
	//	{
	//		for(int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length - 1;i++)
	//	{
	//		for(int j = 0; j < array.Length - i - 1;j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length - 1; i++)
	//	{
	//		for(int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length - 1; i++)
	//	{
	//		for(int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;	
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length-1;i++)
	//	{
	//		for(int j = 0; j < array.Length - i - 1; j++) 
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length - 1;i++)
	//	{
	//		for(int j = 0; j<array.Length-i-1;j++)
	//		{
	//			if (array[j+1] < array[j])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length - 1; i++)
	//	{
	//		for (int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j + 1] < array[j])
	//			{
	//				int buffer = array[j + 1];
	//				array[j + 1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length-1;i++)
	//	{
	//		for(int j = 0; j < array.Length-i-1; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length - 1 ;i++)
	//	{
	//		for(int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j] > array[j+1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length - 1; i++)
	//	{
	//		for(int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length-1;i++)
	//	{
	//		for(int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length-1;i++)
	//	{
	//		for(int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j + 1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length-1; i++)
	//	{
	//		for(int j = 0; j < array.Length-i-1; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j+1];
	//				array[j+1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length-1;i++)
	//	{
	//		for (int j = 0; j < array.Length - i - 1;j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j];
	//				array[j] = array[j + 1];
	//				array[j + 1] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length - 1;i++)
	//	{
	//		for (int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j];
	//				array[j] = array[j + 1];
	//				array[j + 1] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length - 1; i++)
	//	{
	//		for (int j = 0; j < array.Length - 1 - i; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j];
	//				array[j] = array[j+1];
	//				array[j+1] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length - 1; i++)
	//	{
	//		for (int j = 0; j < array.Length - 1 - i; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j];
	//				array[j] = array[j + 1];
	//				array[j + 1] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length - 1; i++)
	//	{
	//		for (int j = 0; j < array.Length - 1 - i; j++)
	//		{
	//			if (array[j] > array[j + 1])
	//			{
	//				int buffer = array[j];
	//				array[j] = array[j + 1];
	//				array[j + 1] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for(int i = 0; i < array.Length - 1; i++)
	//	{
	//		for(int j = 0; j < array.Length - i - 1; j++)
	//		{
	//			if (array[j + 1] < array[j])
	//			{
	//				int buffer = array[j + 1];
	//				array[j + 1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	//private static void BubbleSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length - 1;i++)
	//	{
	//		for (int j = 0;j < array.Length - i - 1;j++)
	//		{
	//			if (array[j + 1] < array[j])
	//			{
	//				int buffer = array[j + 1];
	//				array[j + 1] = array[j];
	//				array[j] = buffer;
	//			}
	//		}
	//	}
	//}
	private static void BubbleSort(int[] array)
	{
		for(int i = 0;i < array.Length - 1;i++)
		{
			for(int j = 0;j < array.Length - i - 1; j++)
			{
				if (array[j + 1] < array[j])
				{
					int buffer = array[j+ 1];
					array[j + 1] = array[j];
					array[j] = buffer;
				}
			}
		}
	}
}
#endif
#if Arrays_4_6_CocktailSort
class Arrays_4_6_CocktailSort
{
	static void Main()
	{
		Console.Write("Введите размер массива: ");
		int size = Int32.Parse(Console.ReadLine());
		int[] nums = new int[size];
		Random rnd = new Random();
		for (int i = 0; i < nums.Length; i++)
		{
			nums[i] = rnd.Next(8, 129);
			Console.Write(nums[i] + "\t|");
		}
		Console.WriteLine();
		CocktailSort(nums);
		for (int i = 0; i < nums.Length; i++)
		{
			Console.Write(nums[i] + "\t|");
		}
		Console.WriteLine();
	}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i + 1];
	//				array[i + 1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i-1];
	//				array[i-1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;	
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i + 1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i-1];
	//				array[i-1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i+1])
	//			{
	//				int buffer = array[i+1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i-1];
	//				array[i-1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i + 1];
	//				array[i + 1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i - 1] > array[i])
	//			{
	//				int buffer = array[i-1];
	//				array[i-1]= array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i+1])
	//			{
	//				int buffer = array[i+1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i-1];
	//				array[i-1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i + 1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i - 1] > array[i])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i - 1];
	//				array[i - 1] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i + 1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i-1];
	//				array[i-1] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i+1])
	//			{
	//				int buffer = array[i+1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i-1];
	//				array[i-1] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i + 1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i-1];
	//				array[i-1] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i + 1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i-1];
	//				array[i-1] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i+1])
	//			{
	//				int buffer = array[i+1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for(int i = right; i > left; i--)
	//		{
	//			if (array[i - 1] > array[i])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i-1];
	//				array[i-1] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++) 
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i + 1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for(int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i];
	//				array[i]= array[i-1];
	//				array[i-1] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i + 1] < array[i])
	//			{
	//				int buffer = array[i + 1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for(int i = right; i > left; i--)
	//		{
	//			if (array[i - 1] > array[i])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i - 1];
	//				array[i - 1] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i + 1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i - 1] > array[i])
	//			{
	//				int buffer = array[i];
	//				array[i]= array[i - 1];
	//				array[i-1] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i + 1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i-1];
	//				array[i-1] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i + 1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i - 1] > array[i])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i - 1];
	//				array[i - 1] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{
	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i + 1];
	//				array[i+1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		right--;
	//		for(int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i-1];
	//				array[i-1] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while (left < right)
	//	{

	//		for (int i = left; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i + 1];
	//				array[i + 1] = buffer;
	//			}
	//		}
	//		right--;
	//		for (int i = right; i > left; i--)
	//		{
	//			if (array[i - 1] > array[i])
	//			{
	//				int buffer = array[i - 1];
	//				array[i - 1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while(left < right)
	//	{
	//		for(int i = 0; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i+ 1];
	//				array[i+ 1] = buffer;
	//			}
	//		}
	//		right--;
	//		for(int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i-1];
	//				array[i-1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while(left < right)
	//	{
	//		for (int i = 0; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i + 1];
	//				array[i + 1] = buffer;
	//			}
	//		}
	//		right--;
	//		for(int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i - 1];
	//				array[i-1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	//private static void CocktailSort(int[] array)
	//{
	//	int left = 0;
	//	int right = array.Length - 1;
	//	while(left < right)
	//	{
	//		for(int i = 0; i < right; i++)
	//		{
	//			if (array[i] > array[i + 1])
	//			{
	//				int buffer = array[i];
	//				array[i] = array[i + 1];
	//				array[i + 1] = buffer;
	//			}
	//		}
	//		right--;
	//		for(int i = right; i > left; i--)
	//		{
	//			if (array[i-1] > array[i])
	//			{
	//				int buffer = array[i-1];
	//				array[i-1] = array[i];
	//				array[i] = buffer;
	//			}
	//		}
	//		left++;
	//	}
	//}
	private static void CocktailSort(int[] array)
	{
		int left = 0;
		int right = array.Length - 1;
		while (left < right)
		{
			for(int i = 0; i < right; i++)
			{
				if (array[i]> array[i + 1])
				{
					int buffer = array[i];
					array[i] = array[i + 1];
					array[i + 1] = buffer;
				}
			}
			right--;
			for(int i = right; i > left; i--)
			{
				if (array[i-1] > array[i])
				{
					int buffer = array[i-1];
					array[i-1] = array[i];
					array[i] = buffer;
				}
			}
			left++;
		}
	}
}
#endif
#if Arrays_4_6_InsertionSort
class Arrays_4_6_InsertionSort
{
	static void Main()
	{
		int[] nums = new int[10];
		Random rnd = new Random();
		for (int i = 0; i < nums.Length; i++)
		{
			nums[i] = rnd.Next(8, 129);
			Console.Write(nums[i] + "\t");
		}
		Console.WriteLine();
		int buffer,j;
		for(int i = 1;i< nums.Length; i++)
		{
			buffer = nums[i];
			j = i;
			while (j > 0 && nums[j - 1] > buffer)
			{
				Swap(nums, j, j-1);
				j -= 1;
			}
			nums[j] = buffer;
		}
		foreach(int i in nums)
		{
			Console.Write($"{i}\t");
		}
		Console.WriteLine();
	}
	static void Swap(int[] nums, int i, int j)
	{
		int buf = nums[i];
		nums[i] = nums[j];
		nums[j] = buf;
	}
}
#endif
#if Arrays_4_6_InsertionSort_2
class Arrays_4_6_InsertionSort_2
{
	static void Main()
	{
		Random rnd = new Random();
		int size = 10;
		int[] array = new int[size];
		for (int i = 0; i < size; i++)
		{
			array[i] = rnd.Next(0, 256);
		}
		foreach (int i in array)
		{
			Console.Write(i + "\t");
		}
		Console.WriteLine();
		InsertionSort(array);
		foreach (int i in array)
		{
			Console.Write(i + "\t");
		}
		Console.WriteLine();
	}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer) 
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1;  i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}	
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while(j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}	
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1]=array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j]>buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;	
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1;  i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j]>buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1;  i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1;i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while(j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j]>buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1;i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while(j>=0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1;i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1;i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1;i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while(j >= 0 && array[j]>buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j]>buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j]>buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j]>buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1;i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j]>buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1;i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j]>buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1;i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j]>buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1]=buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1;i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j]>buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1;i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j]>buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j]>buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1]=buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j]>buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j+1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while ( j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer )
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while ( j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--; 
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while(j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for (int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j + 1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	//private static void InsertionSort(int[] array)
	//{
	//	for(int i = 1; i < array.Length; i++)
	//	{
	//		int buffer = array[i];
	//		int j = i - 1;
	//		while (j >= 0 && array[j] > buffer)
	//		{
	//			array[j + 1] = array[j];
	//			j--;
	//		}
	//		array[j+1] = buffer;
	//	}
	//}
	private static void InsertionSort(int[] array)
	{
		for(int i = 1; i < array.Length; i++)
		{
			int buffer = array[i];
			int j = i - 1;
			while(j >= 0 && array[j] > buffer)
			{
				array[j + 1] = array[j];
				j--;
			}
			array[j+1] = buffer;
		}
	}
}
#endif
#if Arrays_4_6_SelectionSort
class Arrays_4_6_SelectionSort
{
	static void Main()
	{
		Random rnd = new Random();
		int[] array = new int[10];
		for (int i = 0; i < 10; i++)
		{
			array[i] = rnd.Next(0, 256);
		}
		foreach (int i in array)
		{
			Console.Write(i + "\t");
		}
		Console.WriteLine();
		SelectionSort(array);
		foreach (int i in array)
		{
			Console.Write(i + "\t");
		}
		Console.WriteLine();
	}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length - 1; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i+1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for (int j = i+1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length - 1; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i+1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for (int j = i+1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i+1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i+1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i+1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i+1; j < array.Length; j++)
	//		{
	//			if(array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i+1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min]; 
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0; i < array.Length - 1; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if(array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0; i < array.Length - 1; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i+1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i+1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length-1; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i+1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i+1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min=j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i]= array[min];
	//		array[min]= buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length;i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length;j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j =  i + 1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//   private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min]; 
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length;i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1;j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer  = array[i];
	//		array[i] = array[min]; 
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length;i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length;j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			while (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			while (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void  SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			while (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1;  j < array.Length; j++)
	//		{
	//			while (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			while (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			while (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i +1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length;j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		int min = i;
	//		for (int j = i + 1; j < array.Length; j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for (int i = 0;i < array.Length;i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1; j < array.Length;j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	//private static void SelectionSort(int[] array)
	//{
	//	for(int i = 0;i < array.Length;i++)
	//	{
	//		int min = i;
	//		for(int j = i + 1;j < array.Length;j++)
	//		{
	//			if (array[min] > array[j])
	//			{
	//				min = j;
	//			}
	//		}
	//		int buffer = array[i];
	//		array[i] = array[min];
	//		array[min] = buffer;
	//	}
	//}
	private static void SelectionSort(int[] array)
	{
		for(int i = 0;i < array.Length;i++)
		{
			int min = i;
			for(int j = i + 1;j < array.Length;j++)
			{
				if (array[min] > array[j])
				{
					min = j;
				}
			}
			int buffer = array[i];
			array[i] = array[min];
			array[min] = buffer;
		}
	}
}
#endif
#if Arrays_4_6_Merge_Sort
class Arrays_4_6_Merge_Sort
{
	static void Main()
	{
		Console.Write("Welcome to MergeSort!\n" + "Введите размер массива: ");
		int size = Int32.Parse(Console.ReadLine());
		int[] array = new int[size];
		Random random = new Random();
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = random.Next(0, 257);
			Console.Write(array[i] + "\t");
		}
		Console.WriteLine();
		MergeSort(array);
		foreach (int i in array)
		{
			Console.Write(i + "\t");
		}
		Console.WriteLine();
	}

	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if(length <= 1) return; //base case

	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];

	//	int i = 0; //left array
	//	int j = 0; //right array

	//	for(; i < length; i++)
	//	{
	//		if(i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0; //indexes

	//	//check the conditions for merging 
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];
	//			i++;
	//			l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];
	//			i++;
	//			r++;
	//		}
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l];
	//		i++;
	//		l++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r];
	//		i++;
	//		r++;
	//	}
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return; //base case

	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];

	//	int i = 0; //left array
	//	int j = 0; //right array

	//	for (; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int i = 0;
	//	int j = 0;
	//	for(; i < length; i++)
	//	{ 
	//		if(i <  middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if ( i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	if (array.Length <= 1) return;
	//	int[] leftArray = new int[array.Length / 2];
	//	int[] rightArray = new int[array.Length - array.Length / 2];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < array.Length / 2)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for(int i = 0; i < length; i++)
	//	{
	//		if(i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for(int i = 0; i < length; i++)
	//	{
	//		if( i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if ( length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if ( i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1)return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if ( i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for ( int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <=1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rigthArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if(i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rigthArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rigthArray);
	//	Merge(leftArray, rigthArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if(i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for(int i = 0; i < array.Length; i++)
	//	{
	//		if( i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if ( i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if(i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if ( i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for ( int i = 0; i < array.Length; i++)
	//	{
	//		if ( i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if ( i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1)return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] =array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for(int i = 0; i < array.Length; i++)
	//	{
	//		if ( i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for(int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l];l++;i++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if ( i < middle )
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for(int i = 0; i < length; i++)
	//	{
	//		if(i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for(int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray =new int[middle];
	//	int[] rightArray =new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle )
	//		{
	//			leftArray[i] = array[i];
	//		}
	//           else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//           }
	//       }
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0;i < length;i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++) 
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1)return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = array.Length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if(i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = array.Length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = array.Length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1)return;
	//	int middle = array.Length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if(i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = array.Length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if(i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = array.Length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if(i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = array.Length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = array.Length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < array.Length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = array.Length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = array.Length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = array.Length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray =new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = array.Length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void MergeSort(int[] array)
	//{
	//	int length = array.Length;
	//	if (length <= 1) return;
	//	int middle = array.Length / 2;
	//	int[] leftArray = new int[middle];
	//	int[] rightArray = new int[length - middle];
	//	int j = 0;
	//	for (int i = 0; i < length; i++)
	//	{
	//		if (i < middle)
	//		{
	//			leftArray[i] = array[i];
	//		}
	//		else
	//		{
	//			rightArray[j] = array[i];
	//			j++;
	//		}
	//	}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	private static void MergeSort(int[] array)
	{
		int length = array.Length;
		if (length <= 1) return;
		int middle = array.Length / 2;
		int[] leftArray = new int[middle];
		int[] rightArray = new int[length - middle];
		int j = 0;
		for (int i = 0; i < length; i++)
		{
			if (i < middle)
			{
				leftArray[i] = array[i];
			}
			else
			{
				rightArray[j] = array[i];
				j++;
			}
		}
		MergeSort(leftArray);
		MergeSort(rightArray);
		Merge(leftArray, rightArray, array);
	}
	private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	{
		int leftSize = array.Length / 2;
		int rightSize = array.Length - leftSize;
		int i = 0, l = 0, r = 0;
		while(l < leftSize && r < rightSize)
		{
			if (leftArray[l] < rightArray[r])
			{
				array[i] = leftArray[l];l++;i++;
			}
			else
			{
				array[i] = rightArray[r];r++;i++;
			}
		}
		while(l < leftSize)
		{
			array[i] = leftArray[l];l++;i++;
		}
		while (r < rightSize)
		{
			array[i] = rightArray[r];r++;i++;
		}
	}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++;i++;
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++; 
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++;i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while(l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++; 
	//		}
	//		i++;
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++;i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r];r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while(l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++;i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while(l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++;i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r];r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;	
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while(l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++;i++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++;i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l];l++;i++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r];r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l];l++;i++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r];r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while ( l < leftSize && r < rightSize)
	//	{
	//		if(leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r <  rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[]leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//           else
	//           {
	//			array[i] = rightArray[r]; r++;
	//           }
	//		i++;
	//       }
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//           else
	//		{
	//			array[i] = rightArray[r]; r++;
	//           }
	//		i++;
	//       }
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l];l++;i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r];r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l];l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//	MergeSort(leftArray);
	//	MergeSort(rightArray);
	//	Merge(leftArray, rightArray, array);
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while(l< leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize  && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l];l++;i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++;i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0; //indexes
	//							 //check the conditions for merging
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];
	//			l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];
	//			r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l];
	//		i++;
	//		l++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r];
	//		i++;
	//		r++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];
	//			l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];
	//			r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l];
	//		i++;
	//		l++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r];
	//		i++;
	//		r++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r]) { array[i] = leftArray[l]; l++; }
	//		else { array[i] = rightArray[r]; r++; }
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l];
	//		i++;
	//		l++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r];
	//		i++;
	//		r++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r]) 
	//		{ array[i] = leftArray[l]; l++; }
	//		else 
	//		{ array[i] = rightArray[r]; r++; }
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++;i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{ array[i] = leftArray[l]; l++; }
	//		else { array[i] = rightArray[r]; r++; }
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++;i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++;i++; 
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while ( l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{ 
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while ( l < leftSize)
	//	{
	//		array[i] = leftArray[l];l++; i++;
	//	}
	//	while ( r < rightSize)
	//	{
	//		array[i] = rightArray[r];r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while(l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++;i++;
	//	}
	//	while( r < rightSize)
	//	{
	//		array[i] = rightArray[r];r++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else { array[i] = rightArray[r];r++; }
	//		i++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r];r++;i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++;i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++; 
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while ( l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while ( l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while( r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while( l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//           else
	//		{
	//			array[i] = rightArray[r]; r++;
	//           }
	//		i++;
	//       }
	//	while ( l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while ( r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while ( l < leftSize )
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while ( r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while ( l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r];  r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while(l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while ( l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while(r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}

	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l];l++;i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r <  rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while ( l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l];l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r];r++;
	//		}
	//		i++;
	//	}
	//	while(l< leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}
	//private static void Merge(int[] leftArray, int[] rightArray, int[] array)
	//{
	//	int leftSize = array.Length / 2;
	//	int rightSize = array.Length - leftSize;
	//	int i = 0, l = 0, r = 0;
	//	while (l < leftSize && r < rightSize)
	//	{
	//		if (leftArray[l] < rightArray[r])
	//		{
	//			array[i] = leftArray[l]; l++;
	//		}
	//		else
	//		{
	//			array[i] = rightArray[r]; r++;
	//		}
	//		i++;
	//	}
	//	while (l < leftSize)
	//	{
	//		array[i] = leftArray[l]; l++; i++;
	//	}
	//	while (r < rightSize)
	//	{
	//		array[i] = rightArray[r]; r++; i++;
	//	}
	//}

}
#endif
#if Array_4_6_QuickSort
class Array_4_6_QuickSort
{
	static void Main()
	{
		Console.Write("Welcome to QuickSort!\n" + "Введите размер массива: ");
		int size = Int32.Parse(Console.ReadLine());
		int[] array = new int[size];
		Random random = new Random();
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = random.Next(0, 257);
			Console.Write(array[i] + "\t");
		}
		Console.WriteLine();
		QuickSort(array, 0, size - 1);
		foreach (int i in array)
		{
			Console.Write(i + "\t");
		}
		Console.WriteLine();
	}
	//private static void QuickSort(int[] array, int first, int end)
	//{
	//	if (first <= end) 
	//	{
	//		int left = first;
	//		int right = end;
	//		int middle = array[(left + right) / 2]; 
	//		do
	//		{
	//			while (array[left] < middle) left++; 
	//			while (array[right] > middle) right--;
	//			if (left <= right) 
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);  
	//		QuickSort(array, first, right); 
	//		QuickSort(array, left, end);   
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int end)
	//{
	//	if (first < end)
	//	{
	//		int left = first;
	//		int right = end;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, end);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int end)
	//{
	//	if(first < end)
	//	{
	//		int left = first;
	//		int right = end;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if(left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, end);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int end)
	//{
	//	if(first <= end)
	//	{
	//		int left = first;
	//		int right = end;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, end);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int end)
	//{
	//	if(first < end)
	//	{
	//		int left = first;
	//		int right = end;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if(left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, end);
	//	} 
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if(first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if(left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if(first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + last) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if(left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if(first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if(left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if(left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if(first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if(left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if(left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if(first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if(first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array,int first, int last)
	//{
	//	if(first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if(left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array,int first, int last)
	//{
	//	if(first< last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if(left<= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		}while(left< right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if(first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if(left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if(first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if(left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if(first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if(left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	//private static void QuickSort(int[] array, int first, int last)
	//{
	//	if (first < last)
	//	{
	//		int left = first;
	//		int right = last;
	//		int middle = array[(left + right) / 2];
	//		do
	//		{
	//			while (array[left] < middle) left++;
	//			while (array[right] > middle) right--;
	//			if (left <= right)
	//			{
	//				int buffer = array[left];
	//				array[left] = array[right];
	//				array[right] = buffer;
	//				left++;
	//				right--;
	//			}
	//		} while (left < right);
	//		QuickSort(array, first, right);
	//		QuickSort(array, left, last);
	//	}
	//}
	private static void QuickSort(int[] array, int first, int last)
	{
		if (first < last)
		{
			int left = first;
			int right = last;
			int middle = array[(left + right) / 2];
			do
			{
				while (array[left] < middle) left++;
				while (array[right] > middle) right--;
				if (left <= right)
				{
					int buffer = array[left];
					array[left] = array[right];
					array[right] = buffer;
					left++;
					right--;
				}
			} while (left < right);
			QuickSort(array, first, right);
			QuickSort(array, left, last);
		}
	}
}
#endif