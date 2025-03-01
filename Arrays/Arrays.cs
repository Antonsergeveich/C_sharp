//#define IntArraysDemo
//#define CharArrayDemo
#define InitArrayDemo

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