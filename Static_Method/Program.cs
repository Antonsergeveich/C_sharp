//#define StatMethDemo
//#define OverloadMethDemo
//#define ArrayToMethDemo
#define ArrayFromMethDemo

using System;
#if StatMethDemo
class StatMethDemo
{
	//Главный метод программы:
	static void Main()
	{
		//Вызываем статический метод для отображения 
		//сообщения в консольном окне:
		show("Начинаем вычисления:");
		int m = 5;          //Целочисленные переменные
		double z = 3, num; //Действительные переменные
						   //Вычисление факториала числа:
		show(m + "!=" + factorial(m));
		//Число в степени:
		num = power(z, m);
		//Отображение сообщения вызовом статического метода:
		show(z + " в степени " + m + ": " + num);
	}
	//Статический метод для отображения текста,
	//переданного аргументом методу:
	static void show(string txt)
	{
		Console.WriteLine(txt);
	}
	//Статический метод для вычисления факториала числа,
	//переданного аргуметом методу:
	static int factorial(int n)
	{
		//Локальная переменная:
		int s = 1;
		//Вычисления произведения:
		for (int k = 1; k <= n; k++)
		{
			//Умножение произвендения на число:
			s *= k;
		}
		//Результат метода:
		return s;
	}
	//Статический метод для возведения числа в степень.
	//Число и степень передаются аргументами методу:
	static double power(double x, int n)
	{
		//локальная переменная:
		double s = 1;
		//Вычисление результата (число в степени):
		for (int k = 1; k <= n; k++)
		{
			//текущее значение умножается на число:
			s *= x;
		}
		//Результат метода:
		return s;
	}
} 
#endif
#if OverloadMethDemo
class OverloadMethDemo
{
	//Версия статического метода для отображения текста
	//(с одним текстовым аргументом):
	static void show(string txt)
	{
		Console.WriteLine(txt);
	}
	//Версия статического метода для отображения
	//целого числа (аргумент метода):
	static void show(int num)
	{
		Console.WriteLine("Целое число: " + num);
	}
	//Версия статического метода для отображения 
	//действительного числа (аргумент метода):
	static void show(double num)
	{
		Console.WriteLine("Действительное число: " + num);
	}
	//Версия статического метода для отображения символа
	//(аргумент метода):
	static void show(char s)
	{
		Console.WriteLine("Символ: "+s);
	}
	//Версия статического метода для отображения числа
	//(первый аргумент) и символа (второй аргумент):
	static void show(int num, char s)
	{
		Console.WriteLine("Аргументы {0} и {1}", num, s);
	}
	//Главный метода программы:
	static void Main()
	{
		//Целочисленная переменная:
		int num = 5;
		//Действительная числовая переменная:
		double z = 12.5;
		//Символьная переменная:
		char symb = 'W';
		//Вызываем метод с символьным аргументом:
		show(symb);
		//Вызываем метод с текстовым аргументом:
		show("Знакомимся с перегрузкой методов");
		//Вызываем метод с целочисленным аргументом:
		show(num);
		//Вызываем метод с действительным аргументом:
		show(z);
		//Вызываем метод с двумя аргументами:
		show(num, 'Q');
		show('L', 'K');
	}
}
#endif
#if ArrayToMethDemo
class ArrayToMethDemo
{
	//Метод для заполнения массива случайными числами:
	static void fillRand(int[] nums)
	{
		//Объект для генерирования случайных чисел:
		Random rnd = new Random();
		//Заполнения массива случайными числами:
		for(int k = 0; k < nums.Length; k++)
		{
			nums[k] = rnd.Next(1,101);
		}
	}
	//Метод для отображения одномерного 
	//целочисленного массива:
	static void showArray(int[] nums)
	{
		//Перебор элементов массива:
		for(int k = 0; k< nums.Length;k++)
		{
			//Отображения значения элемента:
			Console.Write("| {0}", nums[k]);
		}
		Console.WriteLine("|");
	}
	//Метод для отображения двумерного 
	//целочисленного массива:
	static void showArray(int[,] nums)
	{
		//Перебор строк в массиве:
		for(int i = 0; i < nums.GetLength(0); i++)
		{
			//Перебор элементов в строке:
			for(int j = 0; j < nums.GetLength(1); j++)
			{
				//Отображение значения элемента массива:
				Console.Write("{0,3}", nums[i,j]);
			}
			//Переход к новой строке:
			Console.WriteLine();
		}
	}
	//Метод для вычисления наименьшего элемента в массиве:
	static int findMin(int[] nums)
	{
		//Локальная переменная:
		int s = nums[0];
		//Поиск наименьшего значения:
		for(int k =1; k<nums.Length; k++)
		{
			//Если проверяемый элемент имеет значение,
			//меньшее текущего значения переменной s:
			if (nums[k] < s) s = nums[k];
		}
		//Результат метода:
		return s;
	}
	//Главный метод программы:
	static void Main()
	{
		//Одномерные массивы:
		int[] A = { 1, 2, 3, 5, 7, 9, 11, 13, 15 };
		int[] B = new int[5];
		int[,] C = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
		//Массив B заполняется случайными числами:
		fillRand(B);
		Console.WriteLine("Одномерный массив A:");
		//Отображается массив А:
		showArray(A);
		Console.WriteLine("Одномерный массив B:");
		//Отобрадается массив B:
		showArray(B);
		//Поиск наименьшего элемента:
		int m = findMin(B);
		Console.WriteLine("Наименьшее значение: {0}", m);
		Console.WriteLine("Двумерный массив C:");
		//Отображается массив C:
		showArray(C);
	}
}
#endif
#if ArrayFromMethDemo
class ArrayFromMethDemo
{
	//Метод для создания массива с числами Фибоначчи:
	static int[] fibs(int n)
	{
		//Создаётся массив:
		int[] nums = new int[n];
		//Первый элемент массива:
		nums[0] = 1;
		//Если массив из одного элемента:
		if (nums.Length == 1) return nums;
		//Второй элемент массива:
		nums[1] = 1;
		//Заполнение элементов массива:
		for (int k = 2; k < nums.Length; k++)
		{
			//Значение элементов массива равно сумме значений
			//двух предыдущих элементов:
			nums[k] = nums[k - 1] + nums[k - 2];
		}
		//Результат метода ссылка на массив:
		return nums;
	}
	//Метод для создания массива со случайными символами:
	static char[] rands(int n)
	{
		//Объект для генерирования случайных чисел:
		Random rnd = new Random();
		//Создание массива:
		char[] symbs = new char[n];
		//Заполнение массива:
		for (int k = 0; k < symbs.Length; k++)
		{
			//Значение элемента - случайный символ:
			symbs[k] = (char)('A' + rnd.Next(26));
		}
		//Результат метода - ссылка на массив:
		return symbs;
	}
	//Метод для создания двумерного массива с нечётными числами:
	static int[,] odds(int m, int n)
	{
		//Создание двумерного массива:
		int[,] nums = new int[m, n];
		//Локальная переменная:
		int val = 1;
		//Перебор строк массива:
		for (int i = 0; i < nums.GetLength(0); i++)
		{
			//Перебор элементов в строке:
			for (int j = 0; j < nums.GetLength(1); j++)
			{
				//Значение элемента:
				nums[i, j] = val;
				//Значение для следующего элемента:
				val += 2;
			}
		}
		//Результат метода ссылка на массив:
		return nums;
	}
	static int[,] even_numbers(int m, int n)
	{
		int[,] nums = new int[m, n];
		int val = 0;
		for (int i = 0; i < nums.GetLength(0); i++)
		{
			for (int j = 0; j < nums.GetLength(1); j++)
			{
				nums[i, j] = val;
				val = +2;
			}
		}
		return nums;
	}
	//Главный метод программы:
	static void Main()
	{
		//Переменная для целочисленного массива:
		int[] A;
		//Переменная для символьного массива:
		char[] B;
		//Переменная для двумерного массива:
		int[,] C;
		int[,] D;
		//Создаётся массив с числами Фибоначчи:
		A = fibs(10);
		Console.WriteLine("Числа Фибоначчи:");
		//Отображение содержимого массива:
		foreach (int s in A)
		{
			Console.Write("| {0}", s);
		}
		Console.WriteLine("|");
		//Создаётся массив со случайными символами:
		B = rands(8);
		Console.WriteLine("Случайные символы:");
		//Отображение содержимого массива:
		foreach (char s in B)
		{
			Console.Write("| {0}", s);
		}
		Console.WriteLine("|");
		//Создаётся двумерный массив с нечётными числами:
		C = odds(4, 6);
		Console.WriteLine("Двумерный массив:");
		//Отображение содержимого двумерного массива:
		for (int i = 0; i < C.GetLength(0); i++)
		{
			for (int j = 0; j < C.GetLength(1); j++)
			{
				Console.Write("{0,4}", C[i, j]);
			}
			Console.WriteLine();
		}

		Console.WriteLine("Двумерный чётный массив:");
		D = even_numbers(4, 6);
		for (int i = 0; i < D.GetLength(0); i++)
		{
			for (int j = 0; j < D.GetLength(1); j++)
			{
				Console.Write("{0,4}", D[i, j]);
			}
			Console.WriteLine();
		}
	}
}

#endif