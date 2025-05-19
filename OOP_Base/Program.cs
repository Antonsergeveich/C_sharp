//#define UsingObjsDemo
//#define AnotherObjsDemo
//#define MethodsDemo
//#define ConstructorsDemo
//#define DestructorDemo
//#define StaticDemo
//#define StaticDemo_2
//#define This
//#define This_2
//#define DZ_1
//#define DZ_2
#define DZ_3

using System;
using System.Runtime.CompilerServices;

#if UsingObjsDemo
//Описание класса:
class MyClass
{
	//Целочисленное поле:
	public int number;
	//Символьное поле:
	public char symbol;
	//Метод:
	public void show()
	{
		//Отображение значения целочисленного поля:
		Console.WriteLine("Целочисленное поле: " + number);
		//Отображение значения символьного поля: 
		Console.WriteLine("Символьное поле: " + symbol);
	}
}
//Класс с главным методом:
class UsingObjsDemo
{
	//Главный метод:
	static void Main()
	{
		//Первый объект:
		MyClass A = new MyClass();
		//Объектная переменная:
		MyClass B;
		//Второй объект:
		B = new MyClass();
		//Присваивание значения полям первого объекта:
		A.number = 123;
		A.symbol = 'A';
		//Присваивание значения полям второго объекта:
		B.number = 321;
		B.symbol = 'B';
		//Вызов методов:
		Console.WriteLine("Первый объект");
		A.show();
		Console.WriteLine("Второй объект");
		B.show();
	}
} 
#endif
#if AnotherObjsDemo
//Описание класса:
class MyClass
{
	//Целочисленное поле:
	public int number;
	//Метод для обображения целочисленного поля:
	public void show()
	{
		Console.WriteLine("Значение поля: " + number);
	}
}
//Класс с главным методом:
class AnotherObjsDemo
{
	//Главный метод:
	static void Main()
	{
		//Объектные переменные:
		MyClass A, B;
		//Создание объекта:
		A = new MyClass();
		//Присваивание объектных переменных:
		B = A;
		/*Так как значением переменой 'A' является ССЫЛКА на объект,
		то в переменную 'B' записывается адрес который записан в переменную 'A'*/
		//Присваивание значения полю через первую объектную переменную:
		A.number = 123;
		//Вызов метода через вторую объектную переменную:
		B.show();
		//Присваивание значения полю через вторую объектную переменную:
		B.number = 321;
		//Вызов метода через первую объектную переменную:
		A.show();
	}
}
#endif
#if MethodsDemo
class MyClass
{
	//Закрытое целочисленное поле:
	private int number;
	//Закрытое символьное поле:
	private char symbol;
	//Открытый метод для отображения значения полей:
	public void show()
	{
		Console.WriteLine("Поля объекта: " + number + " и " + symbol);
	}
	//Открытый метод для присваивания значений полям.
	//Версия с двумя аргументами:
	public void set(int n, char s)
	{
		number = n; //Значение целочисленного поля
		symbol = s; //Значение символьного поля
	}
	//Открытый метод для присваивания значения полям.
	//Версия с одним целочисленным аргументом:
	public void set(int n)
	{
		number = n;   //Значение целочисленного поля
		symbol = 'B'; //Значение символьного поля
	}
	//Открытый метод для присваивания значений полям.
	//Версия без аргументов:
	public void set()
	{
		//Вызов версии метода с двумя аргументами:
		set(100, 'A');
	}
}
//Главный класс:
class MethodsDemo
{
	//Главный метод:
static void Main()
	{
		//Создание объекта:
		MyClass obj = new MyClass();
		//Присваивание значений полям:
		obj.set();
		//Отображение значений полей:
		obj.show();
		//Присваивание значений полям:
		obj.set(200);
		//Отображение значений полей:
		obj.show();
		//Присваивание значений полям:
		obj.set(300, 'C');
		//Отображение значений полей:
		obj.show();
	}
}
#endif
#if ConstructorsDemo
//Описание класса с конструктором:
class MyClass
{
	//Закрытые поля:
	public int num;    //Целочисленное поле
	public char symb;  //Сивольное поле
	public string txt; //Текстовое поле
	//Открытый метод для отображения значений полей:
	public void show()
	{
		Console.WriteLine("Поля: {0}, \'{1}\', и \"{2}\"", num, symb, txt);
	}
	//Конструктор без аргументов:
	public MyClass()
	{
		//Значения полей:
		num = 100;
		symb = 'A';
		txt = "Красный";
	}
	//Конструктор с одним целочисленным аргументом:
	public MyClass(int n)
	{
		//Значения полей:
		num = n;
		symb = 'B';
		txt = "Жёлтый";
	}
	//Конструктор с двумя аргументами:
	public MyClass(int n, char s)
	{
		//Значения полей:
		num = n;
		symb = s;
		txt = "Зелёный";
	}
	//Конструктор с тремя аргументами:
	public MyClass(int n, char s, string t)
	{
		//Значения полей:
		num = n;
		symb = s; 
		txt = t;
	}
	//Конструктор с одним текстовым аргументом:
	public MyClass(string t)
	{
		//Значения полей:
		num = 0;
		symb = 'Z';
		txt = t;
	}
}
//Класс с главным методом:
class ConstructorDemo
{
	//Главный метод:
	static void Main()
	{
		//Создание объектов.
		//Вызывается конструктор без аргументов:
		MyClass A = new MyClass();
		//Проверяем значения полей объекта:
		A.show();
		//Вызываем конструктор с целочисленным аргументом:
		MyClass B = new MyClass(200);
		//Проверяем значения полей объекта:
		B.show();
		//Вызываем конструктор с двумя аргументами:
		MyClass C = new MyClass(300, 'C');
		//Проверяем значения полей объекта:
		C.show();
		//Вызываем конструктор с тремя аргументами:
		MyClass D = new MyClass(400, 'D', "Синий");
		//Проверяем значения полей объекта:
		D.show();
		//Вызываем конструктор с символьным аргументом:
		MyClass F = new MyClass('A');
		//Проверяем значения полей объекта:
		F.show();
		//Вызывается конструктор с текстовым аргументом;
		MyClass G = new MyClass("Серый");
		//Проверяем значения полей объекта:
		G.show();
	}
}
#endif
#if DestructorDemo
//Класс с конструктором и деструктором:
//class MyClass
//{
//	//Закрытое текстовое поле:
//	private string name;
//	//Конструктор:
//	public MyClass(string txt)
//	{
//		//Присваивание значения полю:
//		name = txt;
//		//Отображение сообщения:
//		Console.WriteLine("Создан объект \"{0}\"", name);
//	}
//	//Деструктор:
//	~MyClass()
//	{
//		//Отображение сообщения:
//		Console.WriteLine("Удалён объект \"{0}\"", name);
//	}
//}
////Класс с главным методом:
//class DestructorDemo
//{
//	//Статический метод:
//	static void maker(string txt)
//	{
//		//Создание анонимного объекта:
//		new MyClass(txt);
//	}
//	//Главный метод:
//	static void Main()
//	{
//		//Создание объекта:
//		MyClass A = new MyClass("Первый");
//		//Создание анонимного объекта:
//		new MyClass("Второй");
//		//Новый объект:
//		A = new MyClass("Третий");
//		//Вызов статического метода:
//		maker("Четвёртый");
//		//Новый объект:
//		A = new MyClass("Пятый");
//		Console.ReadKey();
//	}
//}
//class MyClass
//{
//	private string name;
//	public MyClass(string txt)
//	{
//		name = txt;
//		Console.WriteLine("Создан объект \"{0}\"", name);
//	}
//	~MyClass()
//	{
//		Console.WriteLine("Удалён объект \"{0}\"", name);
//	}
//}
//class DestructorDemo
//{
//	static void maker(string txt)
//	{
//		new MyClass(txt);
//	}
//	static void Main()
//	{
//		MyClass A = new MyClass("One");
//		new MyClass("Two");
//		A = new MyClass("Three");
//		maker("Four");
//		A = new MyClass("Five");
//		Console.ReadKey();
//	}
//}
//class MyClass
//{
//	private string name;
//	public MyClass(string txt)
//	{
//		name = txt;
//		Console.WriteLine("Создан объект \"{0}\"", name);
//	}
//	~MyClass()
//	{
//		Console.WriteLine("Удалён объект \"{0}\"", name);
//	}
//}
//class DestructorDemo
//{
//	static void maker(string txt)
//	{
//		new MyClass(txt);
//	}
//	static void Main()
//	{
//		MyClass A = new MyClass("One");
//		new MyClass("Two");
//		A = new MyClass("Three");
//		maker("Four");
//		A = new MyClass("Five");
//		Console.ReadKey();
//	}
//}
//class MyClass
//{
//	private string name;
//	public MyClass(string txt)
//	{
//		name = txt;
//		Console.WriteLine("Создан объект \"{0}\"", name);
//	}
//	~MyClass()
//	{
//		Console.WriteLine("Удалён объект \"{0}\"", name);
//	}
//}
//class DestructorDemo
//{
//	static void maker(string txt)
//	{
//		new MyClass(txt);
//	}
//	static void Main()
//	{
//		MyClass A = new MyClass("One");
//		A = new MyClass("Two");
//		new MyClass("Three");
//		maker("Four");
//		A = new MyClass("Five");
//		maker("Six");
//		maker("Seven");
//		maker("Eight");
//		maker("Nine");
//		maker("Ten");
//		maker("Eleven");
//		maker("Twelve");
//	}
//}
//class MyClass
//{
//	private string name;
//	public MyClass(string txt)
//	{
//		name = txt;
//		Console.WriteLine("Создан объект \"{0}\"", name);
//	}
//	~MyClass()
//	{
//		Console.WriteLine("Удалён объект \"{0}\"", name);
//	}
//}
//class DestructorDemo
//{
//	static void maker(string txt)
//	{
//		new MyClass(txt);
//	}
//	static void Main()
//	{
//		MyClass A = new MyClass("One");
//		A = new MyClass("Two");
//		new MyClass("Three");
//		maker("Four");
//		A = new MyClass("Five");
//		maker("Six");
//		maker("Seven");
//		maker("Eight");
//		new MyClass("Nine");
//		new MyClass("Ten");
//		MyClass B = new MyClass("Eleven");
//		B = new MyClass("Twelve");
//	}
//}
class MyClass
{
	private static string name;
	public MyClass(string txt)
	{
		name = txt;
		Console.WriteLine("Создан объект \"{0}\"", name);
	}
	~MyClass()
	{
		Console.WriteLine("Удалён объект \"{0}\"", name);
	}
}
class DestructorDemo
{
	static void maker(string txt)
	{
		new MyClass(txt);
	}
	static void Main()
	{
		MyClass A = new MyClass("One");
		A = new MyClass("Two");
		new MyClass("Three");
		maker("Four");
		new MyClass("Five");
		MyClass B = new MyClass("Six");
		B = new MyClass("Seven");
		MyClass C = new MyClass("Eight");
		C = new MyClass("Nine");
		maker("Ten");
		MyClass D = new MyClass("Eleven");
		D = new MyClass("Twelve");
	}
}
#endif
#if StaticDemo
////Класс со статическим полем и методом:
//class MyClass
//{
//	//Статическое поле:
//	public static int code = 100;
//	//Статический метод:
//	public static void show()
//	{
//		Console.WriteLine("Статическое поле: " + code);
//	}
//}
////Класс с главным методом:
//class StaticDemo
//{
//	//Главный метод:
//	static void Main()
//	{
//		//Вызов статического метода:
//		MyClass.show();
//		//Обращение к статическому полю:
//		MyClass.code = 200;
//		//Вызов статического метода:
//		MyClass.show();
//	}
//}
//class MyClass
//{
//	public static int code = 100;
//	public static void show()
//	{
//		Console.WriteLine("Статическое поле: " + code);
//	}
//}
//class StaticDemo
//{
//	static void Main()
//	{
//		MyClass.show();
//		MyClass.code = 300;
//		MyClass.show();
//	}
//}
//class MyClass
//{
//	public static int code = 100;
//	public static void show()
//	{
//		Console.WriteLine("Статическое поле: " + code);
//	}
//}
//class StaticDemo
//{
//	static void Main()
//	{
//		MyClass.show();
//		MyClass.code = 200;
//		MyClass.show();
//	}
//}
//class MyClass
//{
//	public static int code = 300;
//	public static void show()
//	{
//		Console.WriteLine("Статическое поле: " + code);
//	}
//}
//class StaticDemo
//{
//	static void Main()
//	{
//		MyClass.show();
//		MyClass.code = 500;
//		MyClass.show();
//	}
//}
//class MyClass
//{
//	public static int code = 100;
//	public static void show()
//	{
//		Console.WriteLine("Статическое поле: " + code);
//	}
//}
//class StaticDemo
//{
//	static void Main()
//	{
//		MyClass.show();
//		MyClass.code = 400;
//		MyClass.show();
//	}
//}
//class MyClass
//{
//	public static int code = 100;
//	public static void show()
//	{
//		Console.WriteLine("Статическое поле: " + code);
//	}
//}
//class StaticDemo
//{
//	static void Main()
//	{
//		MyClass.show();
//		MyClass.code = 300;
//		MyClass.show();
//	}
//}
//class MyClass
//{
//	public static int code = 300;
//	public static void show()
//	{
//		Console.WriteLine("Статическое поле: " + code);
//	}
//}
//class StaticDemo
//{
//	static void Main()
//	{
//		MyClass.show();
//		MyClass.code = 900;
//		MyClass.show();
//	}
//}
//class MyClass
//{
//	public static int code = 100;
//	public static void show()
//	{
//		Console.WriteLine("Статическое поле: " + code);
//	}
//}
//class StaticDemo
//{
//	static void Main()
//	{
//		MyClass.show();
//		MyClass.code = 700;
//		MyClass.show();
//	}
//}
//class MyClass
//{
//	public static int code = 300;
//	public static void show()
//	{
//		Console.WriteLine("Статическое поле: " + code);
//	}
//}
//class StaticDemo
//{
//	static void Main()
//	{
//		MyClass.show();
//		MyClass.code = 500;
//		MyClass.show();	
//	}
//}
//class MyClass
//{
//	public static int code = 100;
//	public static void show()
//	{
//		Console.WriteLine("Статическое поле: "+ code);
//	}
//}
//class StaticDemo
//{
//	static void Main()
//	{
//		MyClass.show();
//		MyClass.code = 200;
//		MyClass.show();
//	}
//}
class MyClass
{
	public static int code = 200;
	public static void show()
	{
		Console.WriteLine("Статическое поле: " + code);
	}
}
class StaticDemo
{
	static void Main()
	{
		MyClass.show();
		MyClass.code = 800;
		MyClass.show();
	}
}
#endif
#if StaticDemo_2
/* Экспонента нужна для математического описания процессов,
в которых скорость изменения некоторого количества в каждый момент пропорциональна самому количеству. 
Области, где используется экспонента:
- Финансы. Моделирование роста капитала, процентных ставок. 
- Физика. Описание процессов распада радиоактивных веществ, заряда и разряда конденсаторов. 
- Биология. Моделирование процессов роста популяций и распространения инфекций. 
- Информационные технологии. Анализ процессов увеличения объёма данных и трафика в сети. 

Синус — это тригонометрическая функция, которая описывает взаимосвязь углов и сторон прямоугольного треугольника. 
Области, в которых используется синус:
- Представление изменений физических величин. Синус применяют для выражения периодического изменения таких величин, 
как смещение при простом гармоническом движении, переменный ток, звуковые волны. 
- Машиностроение. Функции синуса используют для представления вращательных движений валов, шестерён, кулачков и коленчатых валов. 
Также с их помощью моделируют механические колебания, которые в дальнейшем применяют для изготовления виброизоляторов и демпферов. 
- Компьютерная графика. Функции синуса используют для создания анимации высокой чёткости, 
эффектов молнии и моделирования различных природных явлений, таких как рябь, образование облаков. 
- Обработка сигналов. Синус применяют для анализа различных типов сигналов и манипулирования ими.  
- Определение размеров, которые трудно или невозможно измерить напрямую. 
Например, зная расстояние до дома и угол, под которым его видно, можно вычислить высоту.*/

////Класс со статическими методами и полями:
//class MyMath
//{
//	//Константное поле (число "Pi"):
//	public const double Pi = 3.141592;
//	//Закрытое статическое поле(граница суммы):
//	private static int N = 100;
//	//Статический метода для вычисления экспоненты:
//	public static double exp(double x)
//	{
//		//Сумма и добавка к сумме:
//		double s = 0, q = 1;
//		//Вычисление суммы:
//		for(int k = 0; k <= N; k++)
//		{
//			s += q; //Прибавление добавки к сумме
//			q*=x/(k+1); //Добавка для следующей итерации
//		}
//		//Результат:
//		return s;
//	}
//	//Статический метода для вычисления синуса:
//	public static double sin(double x)
//	{
//		//Сумма и добавка к сумме:
//		double s = 0, q = x;
//		//Вычисление суммы:
//		for(int k =0;k <= N; k++)
//		{
//			s += q;//Прибавление добавки к сумме
//				   //Добавка для следующей итерации:
//			q *= (-1) * x * x / (2 * k + 2) / (2 * k + 3);
//		}
//		//Результат:
//		return s;
//	}
//}
////Главный класс:
//class StaticDemo
//{
//	//Главный метод:
//	static void Main()
//	{
//		//Аргумент для статических методов:
//		double z = 1;
//		//Вычисление экспоненты:
//		Console.WriteLine("exp({0}) = {1}",z,MyMath.exp(z));
//		//Контрольное значение:
//		Console.WriteLine("Контрольное значение: {0}",Math.Exp(z));
//		//Новое значение аргумента:
//		z = MyMath.Pi / 4;
//		//Вычисление синуса:
//		Console.WriteLine("sin({0})={1}",z, MyMath.sin(z));
//		//Контрольное значение:
//		Console.WriteLine("Контрольное значение: {0}",Math.Sin(z));
//	}
//}
//class MyMath
//{
//	public const double Pi = 3.141592;
//	private static int N = 100;
//	public static double exp(double x)
//	{
//		double s = 0, q = 1;
//		for (int k = 0; k <= N; k++)
//		{
//			s += q;
//			q *= x / (k + 1);
//		}
//		return s;
//	}
//	public static double sin(double x)
//	{
//		double s = 0, q = x;
//		for(int k = 0;k <= N; k++)
//		{
//			s += q;
//			q *= (-1) * x * x / (2 * k + 2) / (2 * k + 3);
//		}
//		return s;
//	}
//}
//class StaticDemo
//{
//	static void Main()
//	{
//		double z = 1;
//		Console.WriteLine("exp({0}) = {1}", z, MyMath.exp(z));
//		Console.WriteLine("Контрольное значение: {0}", Math.Exp(z));
//		z = MyMath.Pi / 4;
//		Console.WriteLine("sin({0}) = {1}", z, MyMath.sin(z));
//		Console.WriteLine("Контрольное значение: {0}",Math.Sin(z));
//	}
//}
//class MyMath
//{
//	public const double Pi = 3.141592;
//	private static int N = 100;
//	public static double exp(double x)
//	{
//		double s = 0, q = 1;
//		for (int k = 0; k <= N; k++)
//		{
//			s += q;
//			q *= x / (k + 1);
//		}
//		return s;
//	}
//	public static double sin(double x)
//	{
//		double s = 0, q = x;
//		for (int k = 0; k <= N; k++)
//		{
//			s += q;
//			q *= (-1) * x * x / (2 * k + 2) / (2 * k + 3);
//		}
//		return s;
//	}
//}
//class StaticDemo
//{
//	static void Main()
//	{
//		double z = 1;
//		Console.WriteLine("exp({0}) = {1}", z, MyMath.exp(z));
//		Console.WriteLine("Контрольное значение: {0}", Math.Exp(z));
//		z = MyMath.Pi / 4;
//		Console.WriteLine("sin({0}) = {1}", z, MyMath.sin(z));
//		Console.WriteLine("Контрольное значение: {0}", Math.Sin(z));
//	}
//}
class MyMath
{
	public const double Pi = 3.141592;
	private static int N = 100;
	public static double exp(double x)
	{
		double s = 0, q = 1;
		for(int k = 0; k <= N; k++)
		{
			s += q;
			q *= x / (k + 1);
		}
		return s;
	}
	public static double sin(double x)
	{
		double s = 0, q = x;
		for(int k = 0; k <= N; k++)
		{
			s += q;
			q *= (-1) * x * x / (2 * k + 2) / (2 * k + 3);
		}
		return s;
	}
}
class StaticDemo
{
	static void Main()
	{
		double z = 1;
		Console.WriteLine("exp({0}) = {1}",z,MyMath.exp(z));
		Console.WriteLine("Контрольное значение: {0}",Math.Exp(z));
		z = MyMath.Pi / 4;
		Console.WriteLine("sin({0}) = {1}",z, MyMath.sin(z));
		Console.WriteLine("Контрольное значение: {0}",Math.Sin(z));
	}
}
#endif
#if This
//Класс:
class MyClass
{
	//Закрытое целочисленное поле:
	private int code;
	//Открытый метод:
	public int get()
	{
		//Использовано ключевое слово this:
		return this.code;
	}
	//Открытый метод:
	public void set(int code)
	{
		//Использовано ключевое слово this:
		this.code = code;
	}
	//Конструктор:
	public MyClass(int code)
	{
		//Использовано ключевое слово this:
		this.code = code;
		//Использовано ключевое слово this:
		Console.WriteLine("Создан объект: " + this.get());
	}
}
//Класс с главным методом:
class UsingThisDemo
{
	//Главный метод:
	static void Main()
	{
		//Создание объекта:
		MyClass obj = new MyClass(100);
		//Присваивание значения полю:
		obj.set(200);
		//Проверка значения поля:
		Console.WriteLine("Новое значение: " + obj.get());
	}
}
#endif
#if This_2
//Класс с перегрузкой конструкторов:
class MyClass
{
	//Целочисленные поля:
	public int alpha;
	public int bravo;
	//Конструктор с одним аргументом:
	public MyClass(int a)
	{
		//Сообщение в консольном окне:
		Console.WriteLine("Конструктор с одним аргументом");
		//Значения полей:
		alpha = a;
		bravo = alpha;
		//Отображения значения полей:
		Console.WriteLine("Оба поля равны " + alpha);
	}
	//Конструктор с двумя аргументами:
	public MyClass(int a, int b)  : this(a)
	{ 
		//Сообщение в консольном окне:
		Console.WriteLine("Конструктор с двумя аргументами");
		//Значение второго поля:
		bravo = b;
		//Отображение значений полей:
		Console.WriteLine("Поля " + alpha + " и " +  bravo);
	}
	//Конструктор без аргументов:
	public MyClass() : this(400, 500)
	{
		//Сообщение в консольном окне:
		Console.WriteLine("Конструктор без аргументов");
		//Отображение значений полей:
		Console.WriteLine("Значения " + alpha + " и " + bravo);
	}
}
//Класс с главным методом:
class ConstrAndThisDemo
{
	//Главный метод:
	static void Main()
	{
		//Вызов конструктора с одним аргументом:
		MyClass A = new MyClass(100);
		Console.WriteLine();
		//Вызов конструктора с двумя аргументами:
		MyClass B = new MyClass(200, 300);
		Console.WriteLine();
		//Вызов конструктора без аргументов:
		MyClass C = new MyClass();
	}
}
#endif
#if DZ_1
//Напишите программу с классом, в котором есть закрытое символьное поле и три открытых метода.
//Один из методов ползволяет присвоить значение полю.
//Ещё один метод при вызове возвращает результатом код символа.
//Третий метод позволяет вывести в консольное окно символ(значение поля) и его код.
class Symbol
{
	private char symbol;
	public void set(char symbol)
	{
		this.symbol = symbol;
	}
	public int get()
	{
		return symbol;
	}
	public void show()
	{
		Console.WriteLine("Символ: {0} и его код {1}", symbol, get());
	}
}
class DZ_1
{
	static void Main()
	{
		Symbol sym = new Symbol();
		sym.set('A');
		sym.show();
	}
}
#endif
#if DZ_2
//Написать программу с классом, у которого есть два символьных поля и метод. Он не возвращает результат, и у него нет аргументов.
//При вызове метод выводит в консольное окно все символы из кодовой таблицы,
//которые находятся "между" символами, являющимися значениями полей объекта(из которого вызывается метод).
//Например, если полям объекта присвоены значения 'А' и 'D', то при вызове метода в консольное окно должны выводиться все 
//символы от 'A' до 'D' включительно.
class Symbol
{
	private char begin;
	private char end;
	public void set(char begin, char end)
	{
		this.begin = begin;
		this.end = end;
	}
	public void show()
	{
		while (begin <= end)
		{
			Console.Write(begin + " ");
			begin++;
		}
		Console.WriteLine();
	}
}
class DZ_2
{
	static void Main()
	{
		Symbol sym = new Symbol();
		sym.set('A','G');
		sym.show();
	}
}
#endif
#if DZ_3
//Написать программу с классом, у которого есть два целочисленных поля. В классе должны быть описаны конструкторы,
//позволяющие создавать объекты без передачи аргументов, с передачей одного аргумента и с передачей двух аргументов.
class Numbers
{
	private static int num_1;
	private static int num_2;
	public Numbers()
	{
		num_1 = 0;
		num_2 = 1;
		Console.WriteLine("Конструктор без аргументов: ");
	}
	public Numbers(int x) 
	{
		num_1 = x;
		num_2 = 1;
		Console.WriteLine("Конструктор с одним аргументом: ");
	}
	public Numbers(int x, int y)
	{
		num_1 = x;
		num_2 = y;
		Console.WriteLine("Конструктор с двумя аргументами: ");
	}
	public void show()
	{
		Console.WriteLine(num_1 + " " + num_2);
	}
	public static void show1()
	{
		Console.WriteLine(num_1 + " " + num_2);
	}
}
class DZ_3
{
	static void Main()
	{
		new Numbers();
		Numbers.show1();
		Numbers num = new Numbers(5);
		num.show();
		new Numbers(4, 6);
		Numbers.show1();
	}
}
#endif