//#define StringDemo
//#define IndexingStringDemo
//#define CompStringDemo
//#define SearchStringDemo
//#define ReplaceStringDemo
//#define SplittingStringDemo
//#define ToStringDemo
//#define DZ_1
//#define DZ_2
//#define DZ_3
#define DZ_4
//#define DZ_5
//#define DZ_6
//#define DZ_7
//#define DZ_8
//#define DZ_9
//#define DZ_10

using System;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;

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
#if SearchStringDemo
class SearchStringDemo
{
	static void Main()
	{
		//Текст в котором выполняется поиск:
		String txt = "Итак, два плюс два и умножить на два равно шести";
		Console.WriteLine("Исходный текст:");
		Console.WriteLine("\"{0}\"", txt);
		//Текстовая строка для поиска:
		String str = "два";
		//Отображение текстового значения:
		Console.WriteLine("Строка для поиска:");
		Console.WriteLine("\"{0}\"", str);
		//Переменая для записи значения индекса:
		int index;
		//Индекс первого вхождения строки в текст:
		index = txt.IndexOf(str);
		Console.WriteLine("Первое совпадение: {0}", index);
		//Индекс второго вхождения строки в текст:
		index = txt.IndexOf(str, index + 1);
		Console.WriteLine("Второе совпадение: {0}", index);
		//Индекс последнего вхождения строки в текст:
		index = txt.LastIndexOf(str);
		Console.WriteLine("Посленее совпадение: {0}", index);
		//Индекс для начала поиска и количество символов:
		int a = 7, b = 9;
		Console.WriteLine("Поиск с {0}-го индекса по {1} символам:", a, b);
		//Индекс первого вхождения строки на интервале:
		index = txt.IndexOf(str, a, b);
		Console.WriteLine("Совпадение на индексе: {0}", index);
		//Изменяем количество символов для поиска:
		b += 3;
		Console.WriteLine("Поиск с {0} - го индекса по {1} символам:", a, b);
		index = txt.IndexOf(str, a, b);
		Console.WriteLine("Совпадение на индексе: {0}", index);
		//Символ для поиска:
		char symb = 'а';
		Console.WriteLine("Теперь ищем букву \'{0}\'", symb);
		//Поиск первого совпадения:
		index = txt.IndexOf(symb);
		Console.WriteLine("Первое совпадение: {0}", index);
		//Поиск второго совпадения:
		index = txt.IndexOf(symb, index + 1);
		Console.WriteLine("Второе совпадение: {0}", index);
		//Последнее совпадение:
		index = txt.LastIndexOf(symb);
		Console.WriteLine("Последнее совпадение: {0}", index);
		//Предпоследнее совпадение:
		index = txt.LastIndexOf(symb, index - 1);
		Console.WriteLine("Предпоследнее совпадение: {0}", index);
		//Поиск на интервале:
		index = txt.IndexOf(symb, a, b);
		Console.WriteLine("Поиск на интервале индексов от {0} до {1}", a, a + b - 1);
		Console.WriteLine("Первое совпадение на интервале: {0}", index);
		//Последнее совпадение на интервале:
		index = txt.LastIndexOf(symb, b, b + 1);
		Console.WriteLine("Поиск до индекса {0}", b);
		Console.WriteLine("Последнее совпадение на интервале: {0}", index);
		//Новый символ для поиска:
		symb = 'ы';
		Console.WriteLine("Ищем букву \'{0}\'", symb);
		//Поиск первого совпадения:
		index = txt.IndexOf(symb);
		Console.WriteLine("Первое совпадение: {0}", index);
		//Массив с буквами для поиска:
		char[] s = { 'ы', 'а', 'д' };
		//Отображение символов для поиска:
		Console.Write("Ищем букву \'{0}\'", s[0]);
		for (int k = 1; k < s.Length - 1; k++)
		{
			Console.Write(", \'" + s[k] + "\'");
		}
		Console.WriteLine(" или \'" + s[s.Length - 1] + "\':");
		//Первое совпадение:
		index = txt.IndexOfAny(s);
		Console.WriteLine("Первое совпадение: {0}", index);
		//Второе совпадение:
		index = txt.IndexOfAny(s, index + 1);
		Console.WriteLine("Второе совпадение: {0}", index);
		//Последнее совпадение:
		index = txt.LastIndexOfAny(s);
		Console.WriteLine("Последнее совпадение: {0}", index);
		Console.WriteLine("Поиск на интервале индексов от {0} до {1}", a, a + b - 1);
		//Первое совпадение на интервале:
		index = txt.IndexOfAny(s, a, b);
		Console.WriteLine("Первое совпадение на интервале: {0}", index);
		//Последнее совпадение на интервале:
		index = txt.LastIndexOfAny(s, a + b - 1, b);
		Console.WriteLine("Последнее совпадение на интервале: {0}", index);
	}
}
#endif
#if ReplaceStringDemo
class ReplaceStringDemo
{
	static void Main()
	{
		//Исходный текст:
		String txt = "Мы изучаем C#";
		//Проверка исходного текста:
		Console.WriteLine(txt);
		//Текстовая переменная:
		String str;
		//Вставка слова в текст:
		str = txt.Insert(11, "язык ");
		//Проверка текста:
		Console.WriteLine(str);
		//Вставка в текст слова с последующим замещением другого текстового блока:
		str = str.Insert(3, "не ").Replace("C#", "Java");
		//Проверка текста:
		Console.WriteLine(str);
		//Замена пробелов на подчёркивания:
		str = str.Replace(" ", "_");
		//Проверка текста:
		Console.WriteLine(str);
		//Извлечение подстроки:
		str = str.Substring(2, 12);
		//Проверка текста:
		Console.WriteLine(str);
		//Извлечение подстроки:
		str = txt.Substring(3);
		//Проверка текста:
		Console.WriteLine(str);
		//Проверка исходного текста:
		Console.WriteLine(txt);
	}
}
#endif
#if SplittingStringDemo
class SplittingStringDemo
{
	static void Main()
	{
		//Исходная текстовая строка:
		String txt = "Дорогу осилит идущий";
		//Отображение исходного текста:
		Console.WriteLine(txt);
		//Текстовая строка:
		String str;
		//Текст с символами в верхнем регистре:
		str = txt.ToUpper();
		//Проверка текстового значения:
		Console.WriteLine(str);
		//Текст с символами в нижнем регистре:
		str = txt.ToLower();
		//Проверка текстового значения:
		Console.WriteLine(str);
		//Пременная для текстового массива:
		//String[] words;
		////Разбивка текста на подстроки:
		//words = txt.Split();
		////Отображение подстрок:
		//for (int k = 0; k < words.Length; k++)
		//{
		//	Console.WriteLine((k + 1) + ": " + words[k]);
		//}
		//Console.WriteLine();
		////Разбивка текста на подстроки:
		//words = txt.Split('у', 'и');
		////Отображение подстрок:
		//for (int k = 0; k < words.Length; k++)
		//{
		//	Console.WriteLine((k + 1) + ": " + words[k]);
		//}
		//Console.WriteLine();
		////Разбивка текста на подстроки:
		//words = txt.Split(new char[] { 'у', 'и' }, 3);
		////Отображение подстрок:
		//for (int k = 0; k < words.Length; k++)
		//{
		//	Console.WriteLine((k + 1) + ": " + words[k]);
		//}
		////Переменная для символьного массива:
		//char[] symbs;
		////Массив из символов, формирующих текст:
		//symbs = txt.ToCharArray();
		////Отображение символов из массива:
		//for (int k = 0; k < symbs.Length; k++)
		//{
		//	Console.Write(symbs[k] + " ");
		//}
		String[] words;
		words = txt.Split();
		for (int i = 0; i < words.Length; i++)
		{
			Console.WriteLine((i + 1) + ": " + words[i]);
		}
		Console.WriteLine();
		words = txt.Split('у', 'и');
		for (int i = 0; i < words.Length; i++)
		{
			Console.WriteLine((i + 1) + ": " + words[i]);
		}
		Console.WriteLine();
		words = txt.Split(new char[] { 'у', 'и' }, 3);
		for(int i = 0; i < words.Length; i++)
		{
			Console.WriteLine((i+1) + ": " + words[i]);	
		}
		char[] symbs;
		symbs = txt.ToCharArray();
		for (int i = 0; i < symbs.Length; i++)
		{
			Console.Write(symbs[i] + " ");
		}
		Console.WriteLine();
	}
}
#endif
#if ToStringDemo
//Класс с переопределённым методом ToString():
class MyClass
{
	//Целочисленное поле:
	public int num;
	//Символьное поле:
	public char symb;
	//Конструктор:
	public MyClass(int n, char s)
	{
		//Присваивание значение полям:
		num = n;
		symb = s;
		//Отображение сообщения о создании объекта.
		//Неявно вызывается метод ToString():
		Console.WriteLine("Создан новый объект\n" + this);
	}
	//Переопределение метода  ToString():
	public override String ToString()
	{
		//Локальная текстовая переменная:
		String txt = "Числовое поле: " + num;
		txt += "\nСимвольное поле: " + symb;
		//Результат метода:
		return txt;
	}
}
//Класс с главным методм программы:
class ToStringDemo
{
	//Главный метод:
	static void Main()
	{
		//Создание нового объекта:
		MyClass obj = new MyClass(100, 'A');
		//Новые значения полей объекта:
		obj.num = 200;
		obj.symb = 'B';
		Console.WriteLine("Новые значения полей объекта");
		//Отображение значений полей объекта.
		//Неявно вызывается метод  ToString():
		Console.WriteLine(obj);
		//Разбивка текста с описанием объекта на подстроки.
		//Метод ToString() вызывается в явном виде:
		String[] str = obj.ToString().Split('\n');
		Console.WriteLine("Явный вызов метода ToString()");
		//Отображение подстрок, содержащих значения полей объекта:
		for (int k = 0; k < str.Length; k++)
		{
			Console.WriteLine("[* " + str[k] + " *]");
		}
	}
}
#endif
#if DZ_1
/*Написать программу, в которой есть статический метод. 
 Аргументом методу передаётся текстовое значение.
 Результатом метод возвращает текст, в котором, по сравенению с текстом - аргументом,
 между символами вставлены пробелы.*/
class Text_value
{
	static string Text(string text)
	{
		string txt = "";
		for (int i = 0; i < text.Length; i++)
		{
			txt += (text[i] + " ");
		}
		return txt;
	}
	static void Main()
	{
		string txt = "Programming in the Visual Studio development environment in C#.";
		Console.WriteLine(txt);
		Console.WriteLine(Text(txt));
	}
}
#endif
#if DZ_2
/*Напишите программу, в которой есть статический метод,
 возвращающий результат текстовое значение и получающий аргументом текст.
 Результат метода - это переданный аргументом текст, в котором слова следуют в обратном подядке.
 Словами считать блоки текста, разделённые пробелами.*/
class Text_value
{
	static string Reverse(string text)
	{
		string[] array = text.Split(' ');//метод String.Split() позволяет разделить строку на массив подстрок по указанному разделителю. 
		text = "";
		for (int i = array.Length - 1; i >= 0; i--)
		{
			text += (array[i] + " ");
		}
		text.Remove(text.Length - 1);//Удаляет все символы, начиная с указанной позиции и до конца строки.
		return text;
	}
	static void Main()
	{
		string txt = "Hello World, my name is Anton !";
		Console.WriteLine(txt);
		Console.WriteLine(Reverse(txt));
	}
}
#endif
#if DZ_3
/*Напишите программу со статическим методом для сравнения текстовых строк.
 Строки на предмет совпадения сравниваются посимвольно.
 Правило сравнения символов такое: два символа считаются одинаковыми,
 если их коды отличаются не больше, чем на единицу.
 Текстовые строки совпадают, если у них совпадают символы(в указанном выше смысле).*/
class Comparison
{
	static void Equality(params string[] text)
	{
		string txt = "Equals";
		for (int i = 0; i < text.Length - 1; i++)
		{
			if (text[i].Length != text[i + 1].Length)
			{
				txt = "Not Equals";
				break;
			}
			for (int j = 0; j < text[i].Length; j++)
			{
				if (text[i][j] != text[i + 1][j] && text[i][j] + 1 != text[i + 1][j] && text[i][j] - 1 != text[i + 1][j])
				{
					txt = "Not Equals";
					break;
				}
			}
		}
		Console.WriteLine(txt);
	}
	static void Main()
	{
		string Anton, Zhenya, Irina;
		Anton =  "ABCD";
		Zhenya = "BCDE";
		Irina =  "CDEF";
		Equality(Anton, Zhenya, Irina);
		Anton =  "ABCD";
		Zhenya = "BCDEF";
		Irina =  "CDEF";
		Equality(Anton, Zhenya, Irina);
		Anton =  "ABCD";
		Zhenya = "BCDE";
		Irina =  "CDEA";
		Equality(Anton, Zhenya, Irina);

	}
}
#endif
#if DZ_4
/*Напишите программу со статическим методом, который выполняет сравнение текстовых строк.
 Текстовые строки сравниваются следующим образом:
 для каждого текстового значения определяется набор разных букв, 
 входящих в текст(при этом количество вхождений буквы в текст значения не имеет).
 Текстовые строки считаются равными, если они содержат одинаковые наборы букв.*/

#endif
#if DZ_5
/*Напишите программу со статическим методом, определяющим позиции, на которых в тексте находится определённый символ.
  Аргументами методу передаются текст и символ. Результатом метод возвращает целочисленный массив,
  значения элементов которого - это индексы позиций, 
  на которых символ(второй аргумент) находится в тексте(первый аргумент).
  Если символ в тексте не встречается, то метод результатом возвращает массив из одного элемента,
  значение которого равно -1.*/
#endif
#if DZ_6
/*Напишите программу со статическим методом, аргументом которому передаётся текст,
 а результатом возвращается символьный массив,
 состоящий из букв(без учета пробелов и знаков препинания), их которых
 состоит тескт. Если буква несколько раз встречается в тексте, в массиве она представлена одним элементом.
 Буквы в массиве результате должны быть отсортированы в алфавитном подрядке.*/
#endif
#if DZ_7
/*Напишите программу со статическим методом, который эмулирует работу метода Substring().
 Аргументами статическому методу передаётся текст и два целочисленных аргумента.
 Результатом метод возвращает текстовую строку, которая состоит из символов текста(первый аргумент),
 начиная с позиции с индексом, определяемым вторым аргументом метода. 
 Третий аргумент статического метода определяет количество символов, которые включаются в подстроку.*/
#endif
#if DZ_8
/*Напишите программу с классом, у которого есть текстовое поле. 
 Значение текстовому полю присваивается при создании объекта класса.
 Также в классе должен быть метод, позволяющий вставить подстроку в текст из текстового поля.
 Аргументами методу передаётся подстрока для вставки в текст, а также индекс позиции, начиная с которого выполняется вставка.
 Переопределить в классе метод ToString() так, чтобы он возвращал текст из текстового поля.*/
#endif
#if DZ_9
/*Напишите программу с классом, в котором есть текстовое поле и символьное поле.
  Значение полям присваивается при создании объекта класса.
  В классе должен быть метод, возвращающий результатом массив из текстовых строк.
  Такие строки получаются разбиением на подстроки значения текстового поля.
  Символ, являющийся индикатором для разбивки на подстроки, определяется занчением символьного поля.
  Переопределить в классе метод ToString() так, чтобы он возвращал текст со значениями полей объекта и подстроки,
  на которые разбивается текст из текстового поля.*/
#endif
#if DZ_10
/*Напишите программу с классом, у которого есть поле, являющееся ссылкой на целочисленный массив.
  При создании объекта массив заполняется случайными числами. Передопределите в классе метод
  ToString() так, чтобы метод возвращал текстовую строку со значениями элементов массива.
  Также строка должна содержать информацию о количесве элементов массива и среднем значении для элементов массива
  (сумма значений элементов, делённая на количество элементов).*/
#endif