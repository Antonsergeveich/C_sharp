//#define StringDemo
//#define IndexingStringDemo
#define CompStringDemo

using System;

#if StringDemo
class StringDemo
{
	static void Main()
	{
		//Символьный массив:
		char[] symbs = { 'Я', 'з', 'ы', 'к', ' ', 'C', '#' };
		Console.WriteLine("Символьный массив:");
		//Отображение содержимого символьного массива:
		Console.WriteLine(symbs);
		//Текстовый объект создаётся
		//на основе символьного массива:
		String A = new string(symbs);
		//Проверка значения текстового объекта:
		Console.WriteLine("A: \"{0}\"", A);
		//Текстовый объект создаётся на основе нескольких элементов из символьного массива:
		String B = new String(symbs, 1, 5);
		//Проверка значения текстового объекта:
		Console.WriteLine("B: \"{0}\"", B);
		//Текстовый объект создаётся как последовательность одинаковых символов:
		String C = new string('ы', 7);
		//Проверка значения текстового объекта:
		Console.WriteLine("C: \"{0}\"", C);
		//Создание текстового объекта путём вызова статического метода с двумя символьными аргументами:
		A = getText('A', 'H');
		//Провверка значения текстового объекта:
		Console.WriteLine("A: \"{0}\"", A);
		//Создание текстового объекта путём вызова статического метода с двумя символьными аргументами:
		B = getText('H', 'A');
		//Проверка значения текстового объекта:
		Console.WriteLine("B: \"{0}\"", B);
		//Создание текстового объекта путем вызова статического метода с аргументом - символьным массивом:
		C = getText(symbs);
		//Проверка значения текстового объекта:
		Console.WriteLine("C: \"{0}\"", C);
	}
	//Статический метод для создания текстового объекта на основе символьного массива:
	static String getText(char[] symbs)
	{
		//Локальная текстовая переменная:
		String txt = "";
		//Перебор элементов в массиве:
		for (int k = 0; k < symbs.Length; k++)
		{
			//Дописывание символа к текстовой строке:
			txt += symbs[k];
		}
		//Результат метода:
		return txt;
	}
	//Статический метод для создания текстового объекта на основе двух символьных значений:
	static String getText(char a, char b)
	{
		//Локальная текстовая переменная:
		String txt = "";
		//Локальная символьная переменная:
		char s = a;
		//Формирование текстовой строки:
		while (s <= b)
		{
			//Дописывание символа к текстовой строке:
			txt += s;
			//Следующий символ для строки:
			s++;
		}
		//Результат метода:
		return txt;
	}
} 
#endif
#if IndexingStringDemo
class IndexingStringDemo
{
	static void Main()
	{
		//Отображение текстового литерала с помощью оператора цикла по коллекции:
		foreach (char s in "Текст")
		{
			Console.Write(s + " ");
		}
		//Переход к новой строке:
		Console.WriteLine();
		//Отображение текстового литерала с помощью оператора цикла:
		for (int k = 0; k < "Текст".Length; k++)
		{
			Console.Write("Текст"[k] + "_");
		}
		//Переход к новой строке:
		Console.WriteLine();
		//Текстовая переменная:
		String A = "Изучаем C#";
		//Отображение текстового значения:
		for (int k = 0; k < A.Length; k++)
		{
			Console.Write(A[k]);
		}
		//Переход к новой строке:
		Console.WriteLine();
		//Отображение текста в обратном порядке:
		showReversed(A);
		//Проверка значения текстового объекта:
		Console.WriteLine(A);
		//Новый текстовый объект(текст в обратном порядке):
		String B = getReversed(A);
		//Отображение текстового значения:
		Console.WriteLine(B);
	}
	//Статический метод для создания текстового объекта, в котором текст записан в обратном порядке:
	//static String getReversed(String txt)
	//{
	//	//Локальная текстовая переменная:
	//	String str = "";
	//	//Формирование текстовой строки:
	//	foreach(char s in txt)
	//	{
	//		//Добавление символа в начало строки:
	//		str = s + str;
	//	}
	//	//Результат метода:
	//	return str;
	//}
	//static String getReversed(String txt)
	//{
	//	String str = "";
	//	foreach (char s in txt)
	//	{
	//		str = s + str;
	//	}
	//	return str;
	//}
	//static String getReversed(String txt)
	//{
	//	String str = "";
	//	foreach(char s in txt)
	//	{
	//		str = s + str;
	//	}
	//	return str;
	//}
	//static String getReversed(String txt)
	//{
	//	String str = "";
	//	foreach(char s in txt)
	//	{
	//		str = s + str;
	//	}
	//	return str;
	//}
	//static String getReversed(String txt)
	//{
	//	String str = "";
	//	foreach (char s in txt)
	//	{
	//		str = s + str;
	//	}
	//	return str;
	//}
	//static  String getReversed(String txt)
	//{
	//	String str = "";
	//	foreach (char s in txt)
	//	{
	//		str = s + str;
	//	}
	//	return str;
	//}
	static String getReversed(String txt)
	{
		String str = "";
		foreach(char s in txt)
		{
			str = s + str;
		}
		return str;
	}
	//Статический метод для отображения текста в обратном порядке:
	static void showReversed(String txt)
	{
		//Перебор символов в тексте в обратном порядке:
		for(int k = txt.Length - 1; k >= 0; k--)
		{
			//Отображение в консоли символа:
			Console.Write(txt[k]);
		}
		//Переход к новой строке:
		Console.WriteLine();
	}
}
#endif
#if CompStringDemo
class CompStringDemo
{
	//Статический метод для сравнения текстовых строк:
	//static bool StrCmp(String X, String Y)
	//{
	//	//Если строки разной длины:
	//	if (X.Length != Y.Length) return false;
	//	//Если строки одинаковой длины:
	//	for (int k = 0; k < X.Length; k++)
	//	{
	//		//Если символы в текстовых строках разные:
	//		if (X[k] != Y[k]) return false;
	//	}
	//	//Результат метода, если строки одинаковой длины и все символы в текстовых строках совпадают:
	//	return true;
	//}
	//static bool StrCmp(String X, String Y)
	//{
	//	if (X.Length != Y.Length) return false;
	//	for(int k = 0; k < X.Length; k++)
	//	{
	//		if (X[k] != Y[k]) return false;
	//	}
	//	return true;
	//}
	//static bool StrCmp(String X, String Y)
	//{
	//	if (X.Length != Y.Length) return false;
	//	for(int k = 0; k < X.Length; k++)
	//	{
	//		if (X[k] != Y[k]) return false;
	//	}
	//	return true;
	//}
	//static bool StrCmp(String X, String Y)
	//{
	//	if (X.Length != Y.Length) return false;
	//	for(int i = 0; i < X.Length; i++)
	//	{
	//		if (X[i] != Y[i]) return false;
	//	}
	//	return true;
	//}
	static bool StrCmp(String X, String Y)
	{
		if (X.Length != Y.Length) return false;
		for(int i = 0; i < X.Length; i++)
		{
			if (X[i] != Y[i]) return false;
		}
		return true;
	}
	//Главный метод:
	static void Main()
	{
		//Символьный массив:
		char[] smb = { 'Я', 'з', 'ы', 'к', ' ', 'C', '#' };
		//Текстовый объект:
		String A = "Язык C#";
		//Отображение текстовой строки:
		Console.WriteLine("A: \"{0}\"", A);
		//Создание нового текстового объекта:
		String B = new String(smb);
		//Отображение текстовой строки:
		Console.WriteLine("B: \"{0}\"", B);
		//Ещё один текстовый объект:
		String C = "ЯЗЫК C#";
		//Отображение текстовой строки:
		Console.WriteLine("C: \"{0}\"", C);
		Console.WriteLine("Сравнение строк");
		//Сравнение текстовых строк:
		Console.WriteLine("A==B: {0}", A == B);
		Console.WriteLine("StrCmp(A,B): {0}", StrCmp(A, B));
		Console.WriteLine("A==C: {0}", A == C);
		Console.WriteLine("StrCmp(A,C): {0}", StrCmp(A, C));
		Console.WriteLine("B!=C: {0}", B != C);
		Console.WriteLine("StrCmp(A, \"C#\"): {0}", StrCmp(A, "C#"));
	}
}
#endif