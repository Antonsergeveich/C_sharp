//#define IntArraysDemo
//#define CharArrayDemo
//#define InitArrayDemo
//#define CopyArrayDemo
//#define MaxElementDemo
#define SortArrayDemo

using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;


#if IntArraysDemo
class IntArraysDemo
{
	static void Main()
	{
		Console.WriteLine("Массив чисел которые при делении на три дают в остатке единицу: ");
		//Создание массива из двенадцати чисел
		int[] nums = new int[12];
		//Перебор элементов массива
		for (int k = 0; k < nums.Length; k++)
		{
			//Присваивание значения элементу массива
			nums[k] = 3 * k + 1;
			//Отображение значения элементов массива
			Console.Write("| " + nums[k] + " ");
		}
		Console.WriteLine("|");
	}
} 
#endif
#if CharArrayDemo
class CharArrayDemo
{
	static void Main()
	{
		//Объект для генерирования случайных чисел:
		Random rnd = new Random();
		//Размер массива и индексная переменная:
		int size = 10, k;
		//Создание символьного массива:
		char[] symbs = new char[size];
		//Отображение сообщения:
		Console.WriteLine("Массив случайных символов: ");
		//Заполнение массива случайными символами:
		for (k = 0; k < symbs.Length; k++)
		{
			symbs[k] = (char)('A' + rnd.Next(26));
			//Отображение значения элементов массива:
			Console.Write("| " + symbs[k] + " ");
		}
		Console.WriteLine("|");
		//Отображение сообщения:
		Console.WriteLine("Массив в обратном порядке: ");
		for (k = symbs.Length - 1; k >= 0; k--)
		{
			Console.Write("| " + symbs[k] + " ");
		}
		Console.WriteLine("|");
	}
} 
#endif
#if InitArrayDemo
class InitArrayDemo
{
	static void Main()
	{
		//Создание и инициализация массива
		int[] nums = { 1, 3, 5, 7, 6, 5, 4 };
		char[] symbs = new char[] { 'A', 'Z', 'B', 'Y' };
		string[] txts = new string[3] { "один", "два", "три" };
		//Отображение содержимого массивов
		Console.WriteLine("Массив nums: ");
		for (int k = 0; k < nums.Length; k++)
		{
			Console.Write(nums[k]+" ");
		}
		Console.WriteLine("\nМассив symbs: ");
		for(int k = 0;k < symbs.Length; k++)
		{
			Console.Write(symbs[k]+" ");
		}
		Console.WriteLine("\nМассив txts: ");
		for(int k =0;k < txts.Length; k++)
		{
			Console.Write(txts[k]+" ");
		}
		Console.WriteLine();
	}
}
#endif
#if CopyArrayDemo
class CopyArrayDemo
{
	static void Main()
	{
		//Целочисленный массив
		int[] A = { 1, 3, 5, 7, 9 };
		//Переменные массива
		int[] B, C;
		//Присваивание массивов
		B = A;
		//Создание нового массива
		C = new int[A.Length];
		//Поэлементное копирование массива
		for(int k = 0; k<A.Length; k++)
		{
			C[k] = A[k];
		}
		//Изменение значения первого элемента в массива A
		A[0] = 0;
		//Изменение значения последнего элемента в массиве B
		B[B.Length - 1] = 0;
		//Сообщение в консольном окне
		Console.WriteLine("A:\tB:\tC");
		//Отображение содержимого массивов
		for(int k = 0;k<B.Length; k++)
		{
			//Отображение значений элементов массивов
			Console.WriteLine("{0}\t{1}\t{2}", A[k], B[k], C[k]);
		}
	}
}
#endif
#if MaxElementDemo
class MaxElementDemo
{
	static void Main()
	{
		Console.WriteLine("Поиск наибольшего значения в массиве: ");
		//Переменные для записи значения элемента и индекса:
		int value, index;
		//Размер массива
		int size = 15;
		//Объект для генерирования случайных чисел
		Random rnd = new Random();
		//Создание массива
		int[] nums = new int[size];
		//Заполнение и отображение массива
		for(int k = 0; k<nums.Length; k++)
		{
			//Значение элемента массива
			nums[k] = rnd.Next(1, 101);
			//Отображение значения элемента
			Console.Write(nums[k]+" ");
		}
		Console.WriteLine();
		//Поиск наибольшего элемента
		index = 0;				//Начальное значение для индекса
		value = nums[index];	//Значение элемента с иедексом
		//Перебор элементов
		for(int k = 1;  k<nums.Length; k++)
		{
			//Если значение проверяемого элемента больше текущего наибольшего значения
			if (nums[k] > value)
			{
				value = nums[k]; //Новое наибольшее значение
				index = k; //Новое значение для индекса
			}
		}
		// Отображение результата
		Console.WriteLine("Наибольшее значение: "+ value);
		Console.WriteLine("Индекс элемента: "+ index);
	}
}
#endif
#if SortArrayDemo
class SortArrayDemo
{
	static void Main()
	{
		Console.WriteLine("Сортировка массива методом пузырька: ");
		//Символьная переменная: 
		char s;
		//Исходный символьный массив:
		char[] symbs = { 'Q', 'Ы', 'a', 'B', 'R', 'A', 'r', 'q', 'b' };
		//Отображение содержимого массива:
		Console.WriteLine("Массив до сортировки: ");
		for(int k = 0; k < symbs.Length; k++)
		{
			Console.Write(symbs[k] + " ");
		}
		Console.WriteLine();
		//Сортировка элементов в массиве:
		for(int i = 1; i < symbs.Length; i++) 
		{
			//Перебор элементов:
			for(int j = 0; j < symbs.Length - i; j++)
			{
				//Если значение элемента слева больше значения элемента справа:
				if (symbs[j] > symbs[j + 1])
				{
					s = symbs[j+1];
					symbs[j+1] = symbs[j];
					symbs[j] = s;
				}
			}
		}
		//Отображение содержимого массива:
		Console.WriteLine("Массив после сортировки: ");
		for(int k=0; k < symbs.Length; k++)
		{
			Console.Write(symbs[k] + " ");
		}
		Console.WriteLine();
	}
}
#endif