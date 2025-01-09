//#define UsingIfDemo
//#define AnotherIfDemo
//#define NestedIfDemo

using System;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;


#if UsingIfDemo
class UsingIfDemo
{
	static void Main()
	{
		MessageBoxIcon icon;
		string msg, title, name;
		name = Interaction.InputBox("Как Вас зовут?", "Знакомимся");
		if (name == "")
		{
			icon = MessageBoxIcon.Error;
			msg = "Очень жаль, что мы не познакомились!";
			title = "Знакомство не состоялось";
		}
		else
		{
			icon = MessageBoxIcon.Information;
			msg = "Очень приятно, " + name + "!";
			title = "Знакомство состоялось";
		}
		MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
	}
} 
#endif

#if AnotherIfDemo
class AnotherIfDemo
{
	static void Main()
	{
		MessageBoxIcon icon = MessageBoxIcon.Error;
		string msg = "Очень жаль, что мы не познакомились!",
			title = "Знакомство не состоялось",
			name;
		name = Interaction.InputBox("Как Вас зовут?", "Знакомимся");
		if (name != "")
		{
			icon = MessageBoxIcon.Information;
			msg = "Очень приятно, " + name + "!";
			title = "Знакомство состоялось";
		}
		MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
	}
} 
#endif
#if NestedIfDemo
class NestedIfDemo
{
	static void Main()
	{
		string txt;
		Console.Write("Введите текст: ");
		txt = Console.ReadLine();
		if (txt != "")
		{
			Console.WriteLine("Спасибо, что ввели текст!");
			if (txt.Length > 10) Console.WriteLine("Ого, как много букв!");
			else Console.WriteLine("Ого, как мало букв!");
		}
		else Console.WriteLine("Жаль, что не ввели текст!");
	}
} 
#endif
class AnotherNestedIfDemo
{
	static void Main()
	{
		int number;
		Console.WriteLine("Введите целое число: ");
		number = Int32.Parse(Console.ReadLine());
		if (number == 1) Console.WriteLine("Единица");
		else if (number == 2) Console.WriteLine("Двойка");
		else if (number == 3) Console.WriteLine("Тройка");
		else if (number == 4) Console.WriteLine("Четвёрка");
		else Console.WriteLine("Неизвестное число");
	}
}