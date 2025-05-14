//#define UsingObjsDemo
#define AnotherObjsDemo

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