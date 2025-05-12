//#define StatMethDemo
//#define OverloadMethDemo
//#define ArrayToMethDemo
//#define ArrayFromMethDemo
//#define ArgsDemo
//#define RefArgsDemo
//#define UsingOutDemo
//#define RecursionDemo
//#define ParamsDemo
//#define MainMethDemo
//#define StaticDZ_1
//#define StaticDZ_2
//#define StaticDZ_3
//#define StaticDZ_4
//#define StaticDZ_5
//#define StaticDZ_6
//#define StaticDZ_7
#define StaticDZ_8

using System;
using System.Runtime.Serialization.Formatters;
using System.Security.Authentication;
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
				val += 2;
			}
		}
		return nums;
	}
	static int[,] multiples_of_5(int m, int n)
	{
		int[,] nums = new int[m, n];
		int val = 0;
		for(int i = 0; i < nums.GetLength(0); i++)
		{
			for(int j = 0;j < nums.GetLength(1); j++)
			{
				nums[i, j] = val;
				if (nums[i, j] % 5 == 0)
				val = val + 5; 
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
		int[,] E;
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
		Console.WriteLine("Двумерный массив из чисел кратных пяти:");
		E = multiples_of_5(4, 6);
		for(int i = 0;i < E.GetLength(0); i++)
		{
			for(int j = 0;j < E.GetLength(1); j++)
			{
				Console.Write("{0,4}", E[i, j]);
			}
			Console.WriteLine();
		}
	}
}

#endif
#if ArgsDemo
class ArgsDemo
{
	//Первый метод. Аргумент - целое число:
	static void alpha(int n)
	{
		//Проверка значения аргумента:
		Console.WriteLine("В методе alpha(). На входе: " + n);
		//Попытка изменить значения аргумента:
		n++;
		//Проверка значения аргумента:
		Console.WriteLine("В методе alpha(). На выходе: " + n);
	}
	//Второй метод. Аргумент - ссылка на массив:
	static void bravo(int[] n)
	/* когда массив передаётся в качестве аргумента, передаётся его адрес,
	а не копия всего массива. Это связано с тем, что массивы являются ссылочным типом данных:
	их значения хранятся в куче, а имя переменной массива — это ссылка на соответствующую область памяти.*/
	{
		//Проверка содержимого массива:
		Console.WriteLine("В методе bravo(). На входе: " + ArrayToText(n));
		//Перебор элементов массива:
		for (int k = 0; k < n.Length; k++)
		{
			//Попытка изменить значение элемента массива:
			n[k]++;
		}
		//Проверка содержимого массива:
		Console.WriteLine("В методе bravo(). На выходе: " + ArrayToText(n));
	}
	//Третий метод. Аргумент - ссылка на массив:
	static void charlie(int[] n)
	{
		//Проверка содержимого массива:
		Console.WriteLine("В методе charlie(). На входе: " + ArrayToText(n));
		//Создаётся новый массив:
		int[] m = new int[n.Length];
		//Перебор элементов в массиве:
		for (int k = 0; k < n.Length; k++)
		{
			//Значение элемента массива:
			m[k] = n[k] + 1;
		}
		//Попытка присвоить новое значение аргументу:
		n = m;
		//Проверка содержимого массива:
		Console.WriteLine("В методе charlie(). На выходе: " + ArrayToText(n));
	}
	//Метод для преобразования массива в текст:
	static string ArrayToText(int[] n)
	{
		//Текстовая переменная:
		string res = "[" + n[0];
		//Перебор элементов массива (кроме начального):
		for (int k = 1; k < n.Length; k++)
		{
			//Дописывание текста в текстовую переменную:
			res += "," + n[k];
		}
		//Дописывание текста в текстовую переменную:
		res += "]";
		//Результат метода - текстовая строка:
		return res;
	}
	//Главный метод программы:
	static void Main()
	{
		//Переменная для передачи аргументом методу:
		int A = 100;
		//Проверка значения переменной:
		Console.WriteLine("До вызова метода alpha(): A = " + A);
		//Вызов метода:
		alpha(A);
		//Проверка значения переменной:
		Console.WriteLine("После вызова метода alpha(): A = " + A);
		//Массив для передачи аргументом методу:
		Console.WriteLine();
		int[] B = { 1, 3, 5 };
		//Проверка содержимого массива:
		Console.WriteLine("До вызова метода bravo(): B = " + ArrayToText(B));
		//Вызов метода:
		bravo(B);
		//Проверка содержимого массива:
		Console.WriteLine("После вызова метода bravo(): B = " + ArrayToText(B));
		Console.WriteLine();
		//Массив для передачи аргументом методу:
		int[] C = { 2, 4, 6 };
		//Проверка содержимого массива:
		Console.WriteLine("До вызова метода charlie(): C = " + ArrayToText(C));
		//Вызов метода:
		charlie(C);
		//Проверка содержимого массива:
		Console.WriteLine("После вызова метода charlie(): C = " + ArrayToText(C));
	}
}
#endif
#if RefArgsDemo
class RefArgsDemo
{
	static void alpha(ref int n)
	{
		Console.WriteLine("В методе alpha(). На входе: " + n);
		n++;
		Console.WriteLine("В методе alpha(). На выходе: " + n);
	}
	static void bravo(ref int[] n)
	{
		Console.WriteLine("В методе bravo(). На входе: " + ArrayToText(n));
		for (int k = 0; k < n.Length; k++)
		{
			n[k]++;
		}
		Console.WriteLine("В методе bravo(). На выходе: " + ArrayToText(n));
	}
	static void charlie(ref int[] n)
	{
		Console.WriteLine("В методе charlie(). На входе: " + ArrayToText(n));
		int[] m = new int[n.Length];
		for (int k = 0; k < n.Length; k++)
		{
			m[k] = n[k] + 1;
		}
		n = m;
		Console.WriteLine("В методе charlie(). На выходе: " + ArrayToText(n));
	}
	static string ArrayToText(int[] n)
	{
		string res = "[" + n[0];
		for (int k = 1; k < n.Length; k++)
		{
			res += "," + n[k];
		}
		res += "]";
		return res;
	}
	static void Main()
	{
		int A = 100;
		Console.WriteLine("До вызова метода alpha(): A = " + A);
		alpha(ref A);
		Console.WriteLine("После вызова метода alpha(): A = " + A);
		int[] B = [1, 3, 5];
		Console.WriteLine("До вызова метода bravo(): B = " + ArrayToText(B));
		bravo(ref B);
		Console.WriteLine("После вызова метода bravo(): B = " + ArrayToText(B));
		int[] C = [2, 4, 6];
		Console.WriteLine("До вызова метода charlie(): C = " + ArrayToText(C));
		charlie(ref C);
		Console.WriteLine("После вызова метода charlie(): C = " + ArrayToText(C));
	}
}
#endif
#if UsingOutDemo
class UsingOutDemo
{
	//Метод для вычисления значения наименьшего элемента в массиве и его индекса:
	//static int getMin(int[] nums, out int index)
	//{
	//	//Начальное значение для индекса:
	//	index = 0;
	//	//Перебор элементов массива:
	//	for (int k = 1; k < nums.Length; k++)
	//	{
	//		//Если значение элемента меньше текущего минимального значения:
	//		if (nums[k] < nums[index])
	//		{
	//			//Новое значение для индекса:
	//			index = k;
	//		}
	//	}
	//	//Результат метода:
	//	return nums[index];
	//}
	//static int getMin(int[] nums, out int index)
	//{
	//	index = 0;
	//	for(int k = 1; k < nums.Length; k++)
	//	{
	//		if (nums[k] < nums[index])
	//		{
	//			index = k;
	//		}
	//	}
	//	return nums[index];
	//}
	//static int getMin(int[] nums, out int index)
	//{
	//	index = 0;
	//	for(int k = 0; k < nums.Length; k++)
	//	{
	//		if (nums[k] < nums[index])
	//		{
	//			index = k;
	//		}
	//	}
	//	return nums[index];
	//}
	static int getMin(int[] nums, out int index)
	{
		index = 0;
		for(int i = 0; i < nums.Length; i++)
		{
			if (nums[i] < nums[index])
			{
				index = i;
			}
		}
		return nums[index];
	}

	/*Ключевое слово out в C# используется для передачи аргументов по ссылке.
    Оно применяется, когда из функции или метода необходимо вернуть несколько значений. 
	При этом вызываемый метод обязан присвоить
	или инициализировать значение параметра перед возвратом в вызывающий метод.*/

	// Главный метод программы:
	static void Main()
	{
		//Целочисленный массив:
		int[] A = { 12, 7, 8, 3, 8, 4, 1, 3, 4, 1, 7, 15 };
		//Отображение содержимого массива:
		foreach (int v in A)
		{
			Console.Write("| {0}", v);
		}
		Console.WriteLine("|");
		//Объявление переменных:
		int val, k;
		//Вычисление элемента с наименьшим значением:
		val = getMin(A, out k); //Второй аргумент при вызове метода передаётся с out-инструкцией!
		//Отображение результатов:
		Console.WriteLine("Наименьшее значение: " + val);
		Console.WriteLine("Индекс элемента: " + k);
		Console.WriteLine("Проверка: A[{0}] = {1}", k, A[k]);
	}
}
#endif
#if RecursionDemo
class RecursionDemo
{
	//Метод для вычисления факториала числа:
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial (int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial (int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial (int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	//static int factorial(int n)
	//{
	//	if (n == 1) return 1;
	//	else return n * factorial(n - 1);
	//}
	static int factorial(int n)
	{
		if (n == 1) return 1;
		else return n * factorial(n - 1);
	}
	//Метод для вычисления чисел Фибоначчи:
	//static int fibs(int n)
	//{
	//	if (n == 1 || n == 2) return 1;
	//	else return fibs(n - 1) + fibs(n - 2);
	//}
	//static int fibonacci(int n)
	//{
	//	if (n == 1 || n == 2) return 1;
	//	else return fibonacci(n - 1) + fibonacci(n - 2);
	//}
	//static int fibonacci(int n)
	//{
	//	if (n == 1 || n == 2) return 1;
	//	else return fibonacci(n - 1) + fibonacci(n - 2);
	//}
	//static int fibonacci(int n)
	//{
	//	if (n == 1 || n == 2) return 1;
	//	else return fibonacci(n - 1) + fibonacci(n - 2);
	//}
	//static int fibonacci(int n)
	//{
	//	if (n == 1 || n == 2) return 1;
	//	else return fibonacci(n - 1) + (n - 2);
	//}
	//static int fibonacci(int n)
	//{
	//	if (n == 1 || n == 2) return 1;
	//	else return fibonacci(n - 1) + fibonacci(n - 2);
	//}
	//static int fibonacci(int n)
	//{
	//	if (n == 1 || n == 2) return 1;
	//	else return fibonacci(n - 1) + fibonacci(n - 2);
	//}
	//static int fibonacci(int n)
	//{
	//	if (n == 1 || n == 2) return 1;
	//	else return fibonacci(n - 1) + fibonacci(n - 2);
	//}
	//static int fibonacci(int n)
	//{
	//	if (n == 1 || n == 2) return 1;
	//	else return fibonacci(n - 1) + fibonacci(n - 2);
	//}
	//static int fibonacci(int n)
	//{
	//	if (n == 1 || n == 2) return 1;
	//	else return fibonacci(n - 1) + fibonacci(n - 2);
	//}
	static int fibonacci(int n)
	{
		if (n == 1 || n == 2) return 1;
		else return fibonacci(n - 1) + fibonacci(n - 2);
	}
	//Метод для вычисления суммы чисел:
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	//static int sum(int n)
	//{
	//	if (n == 0) return 0;
	//	else return n + sum(n - 1);
	//}
	static int sum(int n)
	{
		if (n == 0) return 0;
		else return n + sum(n - 1);
	}
	//Метод для отображения содержимого массива:
	//static void show(int[] a, int k)
	//{
	//	//Отображения значения элемента массива:
	//	Console.Write(a[k] + " ");
	//	//Если элемент в массиве последний:
	//	if (k == a.Length - 1)
	//	{
	//		Console.WriteLine();
	//	}
	//	//Если элемент в массиве не последний:
	//	else
	//	{
	//		//Рекурсивный вызов метода:
	//		show(a, k + 1);
	//	}
	//}
	////Перегрузка метода для отображения содержимого массива:
	//static void show(int[] a)
	//{
	//	//Вызов версии метода с двумя аргументами:
	//	show(a, 0);
	//}
	//static void show(int[] a,int k)
	//{
	//	Console.Write(a[k] + " ");
	//	if (k == a.Length - 1)
	//	{
	//		Console.WriteLine();
	//	}
	//	else
	//	{
	//		show(a, k + 1);
	//	}
	//}
	//static void show(int[] a)
	//{
	//	show(a, 0);
	//}
	//static void show(int[] a, int k)
	//{
	//	Console.Write(a[k] + " ");
	//	if(k == a.Length -1) Console.WriteLine();
	//	else { show(a, k + 1); }
	//}
	//static void show(int[] a)
	//{
	//	show(a, 0);
	//}
	//static void show(int[] a, int k)
	//{
	//	Console.Write(a[k] + " ");
	//	if (k == a.Length - 1) Console.WriteLine();
	//	else show(a, k + 1);
	//}
	//static void show(int[] a) { show(a, 0); }
	//static void show(int[] a, int k)
	//{
	//	Console.Write(a[k] + " ");
	//	if (k == a.Length - 1) Console.WriteLine();
	//	else { show(a, k + 1); }
	//}
	//static void show(int[] a) { show(a, 0); }
	//static void show(int[] a, int k)
	//{
	//	Console.Write(a[k] + " ");
	//	if (k == a.Length - 1) Console.WriteLine();
	//	else
	//	{
	//		show(a, k + 1);
	//	}
	//}
	//static void show(int[] a)
	//{
	//	show(a, 0);
	//}
	static void show(int[] a, int k)
	{
		Console.Write(a[k] + " ");
		if (k == a.Length - 1) Console.WriteLine();
		else { show(a, k + 1); }
	}
	static void show(int[] a)
	{
		show(a, 0);
	}
		//Главный метод программы:
		static void Main()
		{
			Console.WriteLine("Факториал числа:");
			for (int k = 1; k <= 10; k++)
			{
				//Вычисления факториала числа:
				Console.WriteLine(k + "!=" + factorial(k));
			}
			Console.WriteLine("Числа Фибоначчи: ");
			for (int k = 1; k <= 10; k++)
			{
				//Вычисление чисел Фибоначчи:
				Console.Write(fibonacci(k) + " ");
			}
			Console.WriteLine();
			Console.Write("Сумма чисел от 1 до 100: ");
			Console.WriteLine(sum(100));
			//Числовой массив:
			int[] A = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
			Console.WriteLine("Числовой массив: ");
			//Отображение всех элементов массива:
			show(A);
			Console.WriteLine("Элементы, начиная с третьего:");
			//Отображение элементов начиная с третьего:
			show(A, 2);
		}
	}
#endif
#if ParamsDemo
/* Params в C# — это ключевое слово,
 * которое позволяет передавать методу переменное количество аргументов одного типа 
 * в виде единственного логического параметра.*/
class ParamsDemo
{
	//Метод для вычисления суммы чисел:
	//static int sum(params int[] a)
	//{
	//	//Локальная переменная (значение суммы):
	//	int res = 0;
	//	//Перебор аргументов метода:
	//	for (int k = 0; k < a.Length; k++)
	//	{
	//		//Прибавление слагаемого к сумме:
	//		res += a[k];
	//	}
	//	//Результат метода:
	//	return res;
	//}
	//static int sum(params int[] a)
	//{
	//	int res = 0;
	//	for(int k = 0; k < a.Length; k++)
	//	{
	//		res += a[k];
	//	}
	//	return res;
	//}
	//static int sum(params int[] a)
	//{
	//	int res = 0;
	//	for(int k = 0; k < a.Length; k++)
	//	{
	//		res += a[k];
	//	}
	//	return res;
	//}
	//static int sum(params int[] a)
	//{
	//	int res = 0;
	//	for(int k =0; k< a.Length; k++)
	//	{
	//		res += a[k];
	//	}
	//	return res;
	//}
	static int sum(params int[] a)
	{
		int res = 0;
		for (int k = 0; k < a.Length; k++)
		{
			res += a[k];
		}
		return res;
	}
	//Метод для извлечения символа из текста:
	//static string getText(string t, params int[] a)
	//{
	//	//Начальное значение формируемой текстовой строки:
	//	string res = "";
	//	//Перебор аргументов метода:
	//	for (int k = 0; k < a.Length; k++)
	//	{
	//		//Добавления символа в текст:
	//		res += t[a[k]];
	//	}
	//	//Результат метода:
	//	return res;
	//}
	//static string getText(string t, params int[] a)
	//{
	//	string res = "";
	//	for(int k = 0; k < a.Length; k++)
	//	{
	//		res += t[a[k]];
	//	}
	//	return res;
	//}
	//static string getText(string t, params int[] a)
	//{
	//	string res = "";
	//	for(int k = 0; k < a.Length; k++)
	//	{
	//		res += t[a[k]];
	//	}
	//	return res;
	//}
	//static string getText(string t, params int[] a)
	//{
	//	string res = "";
	//	for(int k = 0; k < a.Length; k++)
	//	{
	//		res += t[a[k]];
	//	}
	//	return res;
	//}
	//static string getText(string t, params int[] a)
	//{
	//	string res = "";
	//	for (int k = 0; k < a.Length; k++)
	//	{
	//		res += t[a[k]];
	//	}
	//	return res;
	//}
	//static string getText(string t, params int[] a)
	//{
	//	string res = "";
	//	for(int k = 0; k < a.Length; k++)
	//	{
	//		res += t[a[k]];
	//	}
	//	return res;
	//}
	//static string getText(string t, params int[] a)
	//{
	//	string res = "";
	//	for (int i = 0; i < a.Length; i++)
	//	{
	//		res += t[a[i]];
	//	}
	//	return res;
	//}
	//static string getText(string t, params int[] a)
	//{
	//	string res = "";
	//	for(int j = 0; j < a.Length; j++)
	//	{
	//		res += t[a[j]];
	//	}
	//	return res;
	//}
	//static string getText(string q, params int[] b)
	//{
	//	string text = "";
	//	for(int i = 0; i < b.Length; i++)
	//	{
	//		text += q[b[i]];
	//	}
	//	return text;
	//}
	//static string getText(string t, params int[] a)
	//{
	//	string res = "";
	//	for(int k = 0; k < a.Length; k++)
	//	{
	//		res += t[a[k]];
	//	}
	//	return res;
	//}
	//static string getText(string t, params int[] a)
	//{
	//	string res = "";
	//	for(int k = 0; k < a.Length; k++)
	//	{
	//		res += t[a[k]];
	//	}
	//	return res;
	//}
	//static string getText(string t, params int[] a)
	//{
	//	string res = "";
	//	for(int i = 0; i < a.Length; i++)
	//	{
	//		res += t[a[i]];
	//	}
	//	return res;
	//}
	static string getText(string t, params int[] a)
	{
		string res = "";
		for (int k = 0; k < a.Length; k++)
		{
			res += t[a[k]];
		}
		return res;
	}
	//Метод отображения значения аргументов:
	//static void show(int[] a, params char[] b)
	//{
	//	//Количество элементов в числовом массиве:
	//	Console.Write("Чисел " + a.Length + ": ");
	//	//Значение элементов в числовом массиве:
	//	for (int k = 0; k < a.Length - 1; k++)
	//	{
	//		Console.Write(a[k] + " ");
	//	}
	//	Console.WriteLine("и " + a[a.Length - 1]);
	//	//Количество символьных аргументов:
	//	Console.Write("Символов " + b.Length + ": ");
	//	//Значение символьных аргументов:
	//	for (int k = 0; k < b.Length - 1; k++)
	//	{
	//		Console.Write(b[k] + " ");
	//	}
	//	Console.WriteLine("и " + b[b.Length - 1]);
	//}
	//static void show(int[] a, params char[] b)
	//{
	//	Console.Write("Чисел " + a.Length + ": ");
	//	for (int k = 0; k < a.Length - 1; k++)
	//	{
	//		Console.Write(a[k] + " ");
	//	}
	//	Console.WriteLine("и " + a[a.Length - 1]);
	//	Console.Write("Символов "+b.Length + ": ");
	//	for(int k = 0; k < b.Length - 1; k++)
	//	{
	//		Console.Write(b[k] + " ");
	//	}
	//	Console.WriteLine("и " + b[b.Length - 1]);
	//}
	//static void show(int[] a, params char[] b)
	//{
	//	Console.Write("Чисел " + a.Length + ": ");
	//	for(int k = 0; k < a.Length - 1; k++)
	//	{
	//		Console.Write(a[k]+" ");
	//	}
	//	Console.WriteLine("и " + a[a.Length-1]);
	//	Console.Write("Символов " + b.Length + ": ");
	//	for(int k = 0; k < b.Length - 1; k++)
	//	{
	//		Console.Write(b[k]+" ");
	//	}
	//	Console.WriteLine("и " + b[b.Length-1]);
	//}
	//static void show(int[] a, params char[] b)
	//{
	//	Console.Write("Чисел " + a.Length + ": ");
	//	for (int i = 0; i < a.Length - 1; i++)
	//	{
	//		Console.Write(a[i] + " ");
	//	}
	//	Console.WriteLine("и " + a[a.Length - 1]);
	//	Console.Write("Символов " + b.Length + ": ");
	//	for (int i = 0; i < b.Length - 1; i++)
	//	{
	//		Console.Write(b[i] + " ");
	//	}
	//	Console.WriteLine("и " + b[b.Length - 1]);
	//}
	//static void show(int[] a, params char[] b)
	//{
	//	Console.Write("Чисел " + a.Length + ": ");
	//	for (int i = 0; i < a.Length - 1; i++)
	//	{
	//		Console.Write(a[i] + " ");
	//	}
	//	Console.WriteLine("и " + a[a.Length - 1]);
	//	Console.Write("Символов " + b.Length + ": ");
	//	for (int i = 0; i < b.Length - 1; i++)
	//	{
	//		Console.Write(b[i] + " ");
	//	}
	//	Console.WriteLine("и " + b[b.Length - 1]);
	//}
	static void show(int[] a, params char[] b)
	{
		Console.Write("Чисел " + a.Length + ": ");
		for(int i = 0; i < a.Length - 1; i++)
		{
			Console.Write(a[i] + " ");
		}
		Console.WriteLine("и " + a[a.Length - 1]);
		Console.Write("Символов " + b.Length + ": ");
		for(int i = 0; i < b.Length - 1; i++)
		{
			Console.Write(b[i] + " ");
		}
		Console.WriteLine("и " + b[b.Length - 1]);
	}
	//Главный метод программы:
	static void Main()
	{
		//Пример вызова методов.
		//Вычисление суммы чисел:
		Console.WriteLine("Сумма чисел: " + sum(1, 6, 9, 2, 4));
		Console.WriteLine("Сумма чисел: " + sum(5, 1, 2));
		//Формируется текст:
		Console.WriteLine(getText("Раз два три", 0, 10, 8, 1));
		Console.WriteLine(getText("Бревно", 3, 5, 1, 5, 4));
		//Отображаются аргументы:
		show(new int[] { 1, 3, 5 }, 'A', 'B', 'C', 'D', 'E');
		show(new int[] { 1, 3, 5, 7, 9 }, 'A', 'B', 'C', 'D');
	}
}
#endif
#if MainMethDemo
class MainMethDemo
{
	//Главный метод возвращает результат:
	static int Main()
	{
		Console.WriteLine("Главный метод возвращает результат!");
		//Результат главного метода:
		return 0;
	}
}
#endif
#if StaticDZ_1
class StaticDZ_1
{
	static void Main()
	{
		/*Написать прогарамму, в которой описан статический метод для вычисления двойного факториала числа,
		переданного аргументом методу.
		По определению, двойной факториал числа n (обозначается как n!!) - 
		это произведение через одно всех чисел, не больших числа n. То есть 
		n!! = n * (n-2) *(n-4)*...(последний множитель равен 1 для нечетного n 
		и равен 2 для чётного n). Например, 6!! = 6 * 4 * 2 = 48 и 5!! = 5 * 3 * 1 = 15.
		Предложите версию метода без рекурсии и с рекурсией. */
		Console.Write("Введите число для вычисления двойного факториала: ");
		int value = Int32.Parse(Console.ReadLine());
		Console.WriteLine($"Двойной факториал числа {value} равен: ");
		//Console.WriteLine(factorial_double(value));
		//Console.WriteLine(factorial_double_2(value));
		Console.WriteLine(factorial_double_3(value));
	}
	static int factorial_double(int value)
	{
		if (value <= 2)
		{
			Console.WriteLine("Вы ввели число меньше трёх!");
			return value;
		}
		int fact = value;
		if (value % 2 == 0)
		{
			for (int i = value - 2; i >= 2; i--)
			{
				if (i % 2 == 0) fact = fact * i;
			}
		}
		else
		{
			for (int i = value - 2; i >= 1; i--)
			{
				if (i % 2 != 0) fact = fact * i;
			}
		}
		return fact;
	}
	static int factorial_double_2(int value)
	{
		if (value == 0 || value == 1) return value == 0 ? 0 : 1;
		int fact = value;
		for (int i = value - 2; i >= 2; i -= 2)
		{
			int j = i % 2 == 0 ? fact = fact * i : fact = fact * i;
		}
		return fact;
	}
	//static int factorial_double_3(int value)
	//{
	//	if (value == 0 || value == 1) return 1;
	//	return value * factorial_double_3(value - 2);
	//}
	//static int factorial_double_3(int value)
	//{
	//	if (value == 0 || value == 1) return 1;
	//	return value * factorial_double_3(value - 2);
	//}
	//static int factorial_double_3(int value)
	//{
	//	if (value == 0 || value == 1) return 1;
	//	return value * factorial_double_3(value - 2);
	//}
	//static int factorial_double_3(int value)
	//{
	//	if (value == 0 || value == 1) return 1;
	//	return value * factorial_double_3(value - 2);
	//}
	//static int factorial_double_3(int value)
	//{
	//	if (value == 0 || value == 1) return 1;
	//	return value * factorial_double_3(value - 2);
	//}
	//static int factorial_double_3(int value)
	//{
	//	if (value == 0 || value == 1) return 1;
	//	return value * factorial_double_3(value - 2);
	//}
	//static double factorial_double_3(int value)
	//{
	//	if (value == 0 || value == 1) return 1;
	//	return value * factorial_double_3(value - 2);
	//}
	//static double factorial_double_3(int value)
	//{
	//	if (value == 0 || value == 1) return 1;
	//	return value * factorial_double_3(value - 2);
	//}
	static double factorial_double_3(int value)
	{
		if (value == 0 || value == 1) return 1;
		return value * factorial_double_3(value - 2);
	}
}
#endif
#if StaticDZ_2
class StaticDZ_2
{
	/*Написать программу со статическим методом, которым вычисляется сумма квадратов натуральных чисел 1^2+2^2+3^2+...n^2.
	Число n передаётся аргументом методу. Предложите версию метода с рекурсией и без рекурсии. Для проверки результата 
	можно использовать формулу 1^2 + 2^2 + 3^2 + ... + n^2 = (n(n+1) * (2n+1))/6 . */
	static void Main()
	{
		Console.WriteLine("Введите число для вычисления суммы квадратов: ");
		int number = Int32.Parse(Console.ReadLine());
		Console.WriteLine("Сумма квадратов с рекурсией числа {0} = {1}", number, sum_of_squares(number));
		Console.WriteLine("Сумма квадратов без рекурсии числа {0} = {1}", number, sum_of_squares_1(number));
	}
	static int sum_of_squares(int number)
	{
		if (number == 0 || number == 1) return 1;
		return (number * number) + sum_of_squares(number - 1);	
	}
	static int sum_of_squares_1(int number)
	{
		int sum = 1;
		while(number > 1)
		{
			sum += number * number;
			number--;
		}
		return sum;
	}
}
#endif
#if StaticDZ_3
class StaticDZ_3
{
	/* Написать программу со статическим методом, которому аргументом передаётся целочисленный массив и целое число.
	Результатом метод возвращает ссылку на новый массив,
	который получается из исходного массива (переданного первым аргументом методу), 
	если в нём взять несколько начальных элементов. Количество элементов, которые нужно взять из исходного массива,
	определяются вторым аргументом метода.
	Если второй аргумент метода больше длины массива, переданного первым аргументом, то методом создаётся копия исходного
	массива и возвращается ссылка на эту копию. */

	static void Main()
	{
		int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
		foreach (int i in array)
		{
			Console.Write(i + "\t");
		}
		Console.WriteLine();
		Console.Write("Введите количество элементов которое нужно взять из исходного массива: ");
		int number = Int32.Parse(Console.ReadLine());
		int[] array_2 = Count_minus(array, number);
		foreach (int i in array_2)
		{
			Console.Write(i + "\t");
		}
		Console.WriteLine();

	}
	static int[] Count_minus(int[] array, int number)
	{
		int[] new_array = new int[number >= array.Length ? array.Length : number];
		if (number >= array.Length) new_array = array;
		else
		{
			for (int i = 0; i < number; i++)
			{
				new_array[i] = array[i];
			}
		}
		return new_array;
	}
}
#endif
#if StaticDZ_4
class StaticDZ_4
{
	/*Написать программу со статическим методом, аргументом которому передаётся символьный массив,
	а результатом возвращается ссылка на целочисленный массив, состоящий из кодов символов из массива-аргумента.*/
	static void Main()
	{
		Console.Write("Введите текст: ");
		string s = Console.ReadLine();
		Console.WriteLine($"Строковый массив : {s}");
		char[] array_chars = s.ToCharArray();
		Console.Write("Символьный массив: ");
		foreach (char c in array_chars)
		{
			Console.Write(c + " ");
		}
		Console.WriteLine();
		int[] arr = array_int(array_chars);
		Console.Write("Результат: ");
		foreach (int i in arr)
		{
			Console.Write(i + " ");
		}
		Console.WriteLine();
	}
	static int[] array_int(char[] array_chars)
	{
		int[] arr = new int[array_chars.Length];
		for(int i = 0; i < array_chars.Length; i++)
		{
			arr[i] = array_chars[i];
		}
		return arr;
	}
}
#endif
#if StaticDZ_5
class StaticDZ_5
{
	/* Написать программу со статическим методом, аргументом которому передаётся целочисленный массив,
	а результатом возвращается среднее значение для элементов массива
	(сумма значений элементов, делённая на количество элементов в массиве). */
	static void Main()
	{
		int[] array = { 11, 28, 3, 47, 511, 6, 72, 8 };
		foreach (int i in array)
		{
			Console.Write(i + "\t");
		}
		Console.WriteLine();
		double value = the_average_value(array);
		Console.WriteLine($"Среднее значение для элементов массива: {value}");
	}
	static double the_average_value(int[] array)
	{
		int sum = 0;
		for (int i = 0; i < array.Length; i++)
		{
			sum += array[i];
		}
		return (double)sum / array.Length;
	}
}
#endif
#if StaticDZ_6
class StaticDZ_6
{
	/* Написать программу со статическим методом, аргументом которому передаётся двумерный целочисленный массив.
	У метода, кроме аргумента-массива, есть два неинециализированных аргумента.
	Результатом метод возвращает значение наибольшего элемента в массиве. Неинециаллизированным аргументам
	присваиваются значения индексов этого элемента. */
	static void Main()
	{
		int[,] array = new int[5, 5];
		int row, col;
		Random rnd = new Random();
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				array[i, j] = rnd.Next(0, 32);
			}
		}
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				Console.Write(array[i, j] + "\t");
			}
			Console.WriteLine();
		}
		int max_element = element_max(array, out row, out col);
		Console.WriteLine($"Значение наибольшего элемента в массива: {max_element}");
		Console.WriteLine($"Индекс строки наибольшего элемента: {row}");
		Console.WriteLine($"Индекс столбца наибольшего элемента: {col}");
		int min_element = element_min(array, out row, out col);
		Console.WriteLine($"Значение наименьшего элемента в массива: {min_element}");
		Console.WriteLine($"Индекс строки наименьшего элемента: {row}");
		Console.WriteLine($"Индекс столбца наименьшего элемента: {col}");
	}
	static int element_max(int[,] array, out int row, out int col)
	{
		int element = 0;
		//Прежде чем присваивать новые значения элементов с ключевым словом out нужно их инициализировать
		row = 0;
		col = 0;
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if (array[i, j] >= element)
				{
					element = array[i, j];
					row = i;
					col = j;
				}
			}
		}
		return array[row, col];
	}
	static int element_min(int[,] array, out int row, out int col)
	{
		int element = 0;
		row = 0;
		col = 0;
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				if (array[i, j] <= element)
				{
					element = array[i, j];
					row = i;
					col = j;
				}
			}
		}
		return array[row, col];
	}
}
#endif
#if StaticDZ_7
class StaticDZ_7
{
	/*Написать программу со статическим методом, аргументом которому передаётся одномерный символьный массив.
	В результате вызова метода элементы массива попарно меняются местами: первый с последним, 
	второй с предпоследним и так далее.*/
	static void Main()
	{
		char[] array = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
		foreach (char c in array)
		{
			Console.Write(c + " ");
		}
		Console.WriteLine();
		Revers(array);
		foreach (char c in array)
		{
			Console.Write(c + " ");
		}
		Console.WriteLine();
	}
	static char[] Revers(char[] array)
	{
		int i = 0;
		int j = array.Length - 1;
		while (i < j)
		{
			char buffer = array[i];
			array[i] = array[j];
			array[j] = buffer;
			i++;
			j--;
		}
		return array;
	}
}
#endif
#if StaticDZ_8
class StaticDZ_8
{
	/* Написать программу с перегруженным статическим методом.
	Если аргументом методу предаются два целых числа, то результом возвращается ссылка на целочисленный массив,
	состоящий из натуральных чисел, а перевое и последнее число в массиве определяется аргументами метода.
	Например, если передать аргументами числа 2 и 4, то результатом будет массив из чисел 2, 3 и 4. Если аргументами методу
	передаются два символьных значения, то результатом возвращается ссылка на массив, состоящий из последовательности
	символов, а первый и последний символы определяются аргументами метода. 
	Например, если передать аргументами методу символы 'B' и 'D', то в результате получим массив из символов 'B','C'и'D'.*/
	static void Main()
	{

	}
}
#endif