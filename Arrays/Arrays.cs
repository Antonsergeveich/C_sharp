//#define IntArraysDemo
//#define CharArrayDemo
//#define InitArrayDemo
//#define CopyArrayDemo
//#define MaxElementDemo
//#define SortArrayDemo
//#define ForeachDemo
//#define TwoDimArrayDemo
//#define InitTwoDimArrayDemo
//#define MultiDimArrayDemo
#define AnotherTwoDimArrayDemo

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
#if ForeachDemo
class ForeachDemo
{
	static void Main()
	{
		//Целочисленный массив:
		int[] nums = { 1, 3, 4, 8, 9 };
		//Символьный массив:
		char[] symbs = { 'a', 'b', 'A', 'B', 'Ы' };
		//Текстовый массив:
		String[] txts = { "красный", "жёлтый", "синий" };
		Console.WriteLine("Целочисленный массив");
		//Циклы по целочисленному массиву:
		foreach(int s in nums)
		{
			Console.WriteLine("Число {0} - {1}", s, s%2==0?"чётное":"нечётное");
		}
		Console.WriteLine("Символьный массив");
		//Цикл по символьному массиву:
		foreach(char s in symbs)
		{
			Console.WriteLine("Код символа {0} - {1}", s, (int)s);
		}
		Console.WriteLine("Текстовый массив");
		//Цикл по текстовому массиву:
		foreach(string s in txts)
		{
			Console.WriteLine("В слове \"{0}\" \t{1} букв", s, s.Length);
		}
	}
}
#endif
#if TwoDimArrayDemo
class TwoDimArrayDemo
{
	static void Main()
	{
		//Количество строк и столбцов в массиве:
		int rows = 3, cols = 5;
		//Создание двумерного массива:
		int[,] nums = new int[rows, cols];
		//Значение первого элемента в массиве:
		int value = 1;
		//Заполнение и отображение массива.
		//Перебор строк в массиве:
		for (int i = 0; i < nums.GetLength(0); i++) 
			//метод GetLength() показывает что мы перебираем в цикле for,
			//если GetLength(0)=>строки 'i', если GetLength(1)=>столбцы 'j'
			//так как nums [i,j], массив состоит из трёх строк и пяти столбцов,
			//то значением выражения nums.GetLength(0) будет число 3 (размер по первому индексу - количество строк)
			//значением выражения nums.GetLength(1) будет число 5 (размер по второму индексу - количество столбцов)
		{
			//Перебор столбцов в строке:
			for (int j = 0; j < nums.GetLength(1); j++)
			{
				//Присваивание значений элементу массива:
				nums[i,j]=value;
				//Это будет значение следующего элемента:
				value++;
				//Отображение элемента в строке:
				Console.Write(nums[i,j]+"\t");
			}
			//Переход к новой строке:
			Console.WriteLine();
		}
	}
}
#endif
#if InitTwoDimArrayDemo
class InitTwoDimArrayDemo
{
	static void Main()
	{
		Console.WriteLine("Добавление строки и столбца в массив.");
		//Создание и инициализация двумерного массива:
		char[,] symbs = { { 'A', 'B', 'C' }, { 'D', 'E', 'F' } };
		Console.WriteLine("Исходный массив:");
		//Отображение массива:
		for (int i = 0; i < symbs.GetLength(0); i++)
		{
			for (int j = 0; j < symbs.GetLength(1); j++)
			{
				//Отображение значения элмента:
				Console.Write(symbs[i, j] + " ");
			}
			//Переход к новой строке:
			Console.WriteLine();
		}
		//Объект для генерации случайных чисел:
		Random rnd = new Random();
		//Строка и столбец:
		int row = rnd.Next(symbs.GetLength(0)+1);
		int col = rnd.Next(symbs.GetLength(1)+1);
		Console.WriteLine("Добавляется {0}-я строка и {1}-й столбец", row, col);
		//Создание нового массива:
		char[,] tmp = new char[symbs.GetLength(0)+1, symbs.GetLength(1)+1];
		//Целочисленные переменные:
		int a, b;
		//Символьная переменная:
		char s = 'a';
		//Заполнение массива. Копирование значений из исходного массива:
		for (int i = 0; i<symbs.GetLength(0); i++)
		{
			//Первый индекс для элемента нового массива:
			if (i < row) a = i;
			else a = i + 1;
			for (int j = 0;j < symbs.GetLength(1); j++)
			{
				//Второй индекс для элемента нового массива:
				if(j < col) b = j;
				else b = j + 1;
				//Присваивание значения элементу массива:
				tmp[a, b] = symbs[i,j];
			}
		}
		//Заполнение добавленной строки в новом массиве:
		for (int j = 0; j < tmp.GetLength(1); j++)
		{
			//Значение элемента в строке:
			tmp[row, j] = s;
			//Новое значение для следующего элемента:
			s++;
		}
		for(int i = 0;  i < tmp.GetLength(0); i++)
		{
			//Если элемент не в добавленной строке:
			if(i!=row)
			{
				//Значение элементов в столбце:
				tmp[i, col] = s;
				//Новое значение для следующего элемента:
				s++;
			}
		}
		//Присваивание массивов:
		symbs = tmp; 
		//переменная symbs теперь ссылается на тот же адрес нового массива что и переменная tmp,
		//а массив, на который ссылалась переменная symbs ранее, будет удалён сборщиком мусора
		//так как он уже нигде не используется;
		Console.WriteLine("Новый массив:");
		//Отображение массива:
		for(int i = 0;i < symbs.GetLength(0); i++)
		{
			for(int j = 0; j < symbs.GetLength(1); j++)
			{
				//Отображение значения элемента:
				Console.Write(symbs[i,j]+" ");
			}
			//Переход к новой строке:
			Console.WriteLine();
		}
	}
}
#endif
#if MultiDimArrayDemo
class MultiDimArrayDemo
{
	static void Main()
	{
		//Трёхмерный символьный массив:
		char[,,] symbs = new char[4, 3, 5];
		//Одномерный символьный массив:
		char[] s = { 'б', 'Б', 'b', 'B' };
		//Заполнение трёхмерного символьного массива и отображение
		//значений его элементов.
		//Цикл по первому индексу:
		for(int i = 0; i < symbs.GetLength(0); i++) 
		{
			//Отображение сообщения:
			Console.WriteLine(" Слой № {0}:", i+1);
			//Цикл по второму индексу:
			for(int j = 0; j < symbs.GetLength(1); j++)
			{
				//Цикл по третьему индексу:
				for(int k = 0; k < symbs.GetLength(2); k++)
				{
					//Присваивание значения элементу массива:
					symbs[i, j, k] = s[i];
					//Изменение элемента в одномерном массиве:
					s[i]++;
					//Отображение значения элемента массива:
					Console.Write(symbs[i, j, k]+" ");
				}
				//Переход к новой строке:
				Console.WriteLine();
			}
			//Отображение "линии":
			Console.WriteLine("-------------------------");
		}
	}
}
#endif
#if AnotherTwoDimArrayDemo
class AnotherTwoDimArrayDemo
{
	static void Main()
	{
		Console.WriteLine("Массив со строками разной длины.");
		//Есть переменная массива, которая ссылается на массив,
		//и этот массив состоит из переменных массива, ссылающихся на массивы.
		//Символьный  массив из переменных массива:
		char[][] symbs = new char[5][];
		//Целочисленный массив из переменных массива:
		int[][] nums = { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8, 9 } };
		//Символьная переменная:
		char s = 'А';
		//Заполнение символьного массива:
		//Перебор элементов во внешнем массиве:
		for(int i = 0; i < symbs.Length; i++)
		{
			//Создание внутреннего массива:
			symbs[i] = new char[i + 3];
			//Перебор элементов во внутреннем массиве:
			for(int j = 0; j < symbs[i].Length; j++)
			{
				//Значение элемента внутреннего массива:
				symbs[i][j] = s;
				//Значение для следующего элемента:
				s++;
			}
		}
		Console.WriteLine("Целочисленный массив:");
		//Отображение целочисленного массива:
		for(int i = 0;i < nums.Length; i++)
		{
			for(int j = 0;j < nums[i].Length; j++)
			{
				//Отображение элемента массива:
				Console.Write("{0,3}", nums[i][j]);
			}
			Console.WriteLine();
		}
		Console.WriteLine("Символьный массив:");
		//Отображение символьного массива:
		//Перебор элементов внешнего массива:
		foreach (char[] q in symbs)
		{
			//Перебор элементов во внутреннем массиве:
			foreach(char p in q)
			{
				//Отображение элемента массива:
				Console.Write("{0,2}", p);
				//{0,2} = 0 - значение первого элемента т.е.
				//'p'- это элемент в массиве на который ссылается элемент массива symbs,
				//2 - для отображения значения выделяется не менее двух позиций;
			}
			Console.WriteLine();
		}
	}
}
#endif