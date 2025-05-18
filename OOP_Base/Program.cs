//#define UsingObjsDemo
//#define AnotherObjsDemo
//#define MethodsDemo
//#define ConstructorsDemo
#define DestructorDemo

using System;

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