//#define TryCatchDemo
//#define Chapter_3_1
//#define Chapter_3_2
//#define Chapter_3_3_1
//#define Chapter_3_3_2
//#define Chapter_3_4_1
//#define Chapter_3_4_2
//#define Chapter_3_5_1
//#define Chapter_3_5_2
//#define Chapter_3_6_1
//#define Chapter_3_6_2
//#define Chapter_3_6_3
//#define Chapter_3_7_1
//#define Chapter_3_7_2
//#define Chapter_3_7_3
//#define Chapter_3_7_4
#define Chapter_3_7_5_recursion

using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace TryCatch
{

#if TryCatchDemo
class TryCatchDemo
{
	static void Main()
	{
		MessageBox.Show("Выполняется программа!", "Начало");
		try
		{
			Double.Parse(Interaction.InputBox("Введите действительное число: ", "Число"));
			MessageBox.Show("Да, это было число!", "Число");
		}
		catch
		{
			MessageBox.Show("Надо было ввести число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		MessageBox.Show("Программа завершена!", "Завершение");
	}
} 
#endif
#if Chapter_3_1
class Chapter_3_1
{
	static void Main() //Это число 21
	{
		try
		{
			int number = Int32.Parse(Interaction.InputBox("Введите целое число которое делится на три и семь без остатка.\nHint: This is a number - 21", "Input"));
			if(number % 3 == 0 && number % 7 == 0)
			{
				MessageBox.Show($"Число {number} делится на три и семь без остатка","Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show($"Число {number} не делится на три и семь без остатка","Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
		catch
		{
			MessageBox.Show("Вы ввели не целое число","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}

	}
}

#endif
#if Chapter_3_2
	class Chapter_3_2
	{
		static void Main()
		{
			try
			{
				double num1 = Double.Parse(Interaction.InputBox("Введите первое число: ", "Ввод первого числа"));
				double num2 = Double.Parse(Interaction.InputBox("Введите второе число: ", "Ввод второго числа"));
				if (num1 > num2) MessageBox.Show($"Первое число {num1} больше второго {num2}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else if (num1 < num2) MessageBox.Show($"Второе число {num2} больше чем первое число {num1}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else if (num1 == num2) MessageBox.Show($"Числа {num1} и {num2} равны", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				MessageBox.Show("Вы ввели не число", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
#endif
#if Chapter_3_3_1
	class Chapter_3_3
	{
		static void Main()
		{
			double sum = 0;
			try
			{
				double one_number = Double.Parse(Interaction.InputBox("Введите первое число: ", "Entering a number"));
				double two_number = Double.Parse(Interaction.InputBox("Введите второе число: ", "Entering a number"));
				sum = one_number + two_number;
				do
				{
					MessageBox.Show($"Сумма введённых Вами чисел равна: {sum}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
					two_number = Double.Parse(Interaction.InputBox("Введите число: ", "Entering a number"));
					sum += two_number;
				} while (two_number != 0);
				throw new Exception();
			}
			catch 
			{
				MessageBox.Show("Вы не ввели число, программа закончила работу\n" +
					$"Сумма введённых Вами чисел равна: {sum}", "End", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
//Оператор throw в C# позволяет генерировать исключения вручную.
//То есть с его помощью можно создать исключение и вызвать его в процессе выполнения.
//После оператора throw указывается объект исключения, через конструктор которого можно передать сообщение об ошибке.
//Затем в блоке catch сгенерированное исключение будет обработано.
//Существует и другая форма использования оператора throw, когда после него не указывается объект исключения.
//В подобном виде оператор throw может использоваться только в блоке catch.
//Например, в программе, где происходит ввод имени пользователя, и нужно, чтобы, если длина имени меньше 2 символов, то возникало исключение.
//try
//{
//	Console.Write("Введите имя: ");
//	string? name = Console.ReadLine();
//	if (name == null || name.Length < 2)
//	{
//		throw new Exception("Длина имени меньше 2 символов");
//	}
//	else
//	{
//		Console.WriteLine($"Ваше имя: {name}");
//	}
//}
//catch (Exception e)
//{
//	Console.WriteLine($"Ошибка: {e.Message}");
//}
#endif
#if Chapter_3_3_2
	class Chapter_3_3_2
	{
		static void Main()
		{
			var sum = 0;
			var number = 0;
			do
			{
				number = int.Parse(Interaction.InputBox("Введите число: ", "Entering a number"));
				while (!int.TryParse(Convert.ToString(number), out number));
				sum += number;
			} while (number != 0);
			MessageBox.Show($"{sum}");
		}
	}
#endif
#if Chapter_3_4_1
	class Chapter_3_4_1
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Введите число от 1 до 7");
				int number = int.Parse(Console.ReadLine());
				switch (number)
				{
					case 1: Console.WriteLine("MONDAY - понедельник"); break;
					case 2: Console.WriteLine("TUESDAY - вторник"); break;
					case 3: Console.WriteLine("WEDNESDAY - среда"); break;
					case 4: Console.WriteLine("THURSDAY - четверг"); break;
					case 5: Console.WriteLine("FRIDAY - пятница"); break;
					case 6: Console.WriteLine("SATURDAY - суббота"); break;
					case 7: Console.WriteLine("SUNDAY - воскресенье"); break;
					default: Console.WriteLine("There is no such day - Такого дня нет"); break;
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Error");
			}
		}
	}
#endif
#if Chapter_3_4_2
	class Chapter_3_4_2
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Введите число от 1 до 7");
				int number = int.Parse(Console.ReadLine());
				switch (number)
				{
					case 1: Console.WriteLine("MONDAY - понедельник"); break;
					case 2: Console.WriteLine("TUESDAY - вторник"); break;
					case 3: Console.WriteLine("WEDNESDAY - среда"); break;
					case 4: Console.WriteLine("THURSDAY - четверг"); break;
					case 5: Console.WriteLine("FRIDAY - пятница"); break;
					case 6: Console.WriteLine("SATURDAY - суббота"); break;
					case 7: Console.WriteLine("SUNDAY - воскресенье"); break;
					default:
						Console.WriteLine("There is no such day - Такого дня нет"); break;
						throw new Exception();
				}
			}
			catch (Exception e)
			{
				Console.WriteLine($"Ошибка: {e.Message}");
			}
		}
	}
#endif
#if Chapter_3_5_1
	class Chapter_3_5_1
	{
		static void Main()
		{
			Console.WriteLine("Enter the day of the week: ");
			string day_of_the_week = Console.ReadLine();
			day_of_the_week = day_of_the_week.ToUpper(); // Все символы в верхний регистр
			int number = 0;
			if (day_of_the_week == "MONDAY") number = 1;
			else if (day_of_the_week == "TUESDAY") number = 2;
			else if (day_of_the_week == "WEDNESDAY") number = 3;
			else if (day_of_the_week == "THURSDAY") number = 4;
			else if (day_of_the_week == "FRIDAY") number = 5;
			else if (day_of_the_week == "SATURDAY") number = 6;
			else if (day_of_the_week == "SUNDAY") number = 7;
			else Console.WriteLine("Такого дня нет");
			if (number != 0) Console.WriteLine(number);
		}
	}
#endif
#if Chapter_3_5_2
	class Chapter_3_5_1
	{
		static void Main()
		{
			Console.WriteLine("Enter the day of the week: ");
			string weekday = Console.ReadLine();
			weekday = weekday.ToUpper();
			string dw = " день недели";
			switch (weekday)
			{
				case "MONDAY": Console.WriteLine(1 + dw); break;
				case "TUESDAY": Console.WriteLine(2 + dw); break;
				case "WEDNESDAY": Console.WriteLine(3 + dw); break;
				case "THURSDAY": Console.WriteLine(4 + dw); break;
				case "FRIDAY": Console.WriteLine(5 + dw); break;
				case "SATURDAY": Console.WriteLine(6 + dw); break;
				case "SUNDAY": Console.WriteLine(7 + dw); break;
				default: Console.WriteLine("Такого дня нет"); break;
			}
		}
	}
#endif
#if Chapter_3_6_1
	class Chapter_3_6_1
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Напишите количество слагаемых\n" +
						"\"1+3+5+7+9+11+...+2n-1\" для вычисления суммы нечётных чисел:");
				int quantity = Int32.Parse(Console.ReadLine());
				int n = quantity;
				int sum = 0;
				while (n > 0)
				{
					sum += 2 * n - 1;
					n--;
				}
				Console.WriteLine($"Количество цифр: {quantity}\nСумма нечётных чисел: {sum}");
			}
			catch 
			{
				Console.WriteLine("Error: The figure was not found!");
			}
		}
	}
#endif
#if Chapter_3_6_2
	class Chapter_3_6_2
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Напишите количество слагаемых\n" +
						"\"1+3+5+7+9...2n-1\n\" для вычисления суммы нечётных чисел");
				int quantity = Int32.Parse(Console.ReadLine());
				int n = quantity;
				int sum = 0;
				do
				{
					sum += 2 * n - 1;
					n--;
				} while (n > 0);
				Console.WriteLine($"Колличество нечётных чисел:{quantity}\n" +
					$"Сумма нечётных чисел: {sum}");
			}
			catch 
			{
				Console.WriteLine("Error: The figure was not found!");
			}
		}
	}
#endif
#if Chapter_3_6_3
	class Chapter_3_6_3
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Напишите количество слагаемых\n" +
								"\"1+3+5+7+9...2n-1\n\" для вычисления суммы нечётных чисел");
				int quantity = Int32.Parse(Console.ReadLine());
				int n = quantity;
				int sum = 0;
				for (; n > 0; n--)
				{
					sum += 2 * n - 1;
				}
				Console.WriteLine($"Колличество нечётных чисел:{quantity}\n" +
						$"Сумма нечётных чисел: {sum}");
			}
			catch
			{
				Console.WriteLine("Error: The figure was not found!");
			}
		}
	}
#endif
#if Chapter_3_7_1
	class Chapter_3_7_1
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Calculate the sum of the squares of the natural numbers");
				Console.WriteLine("Enter the first natural number: ");
				int one = Int32.Parse(Console.ReadLine());
				Console.WriteLine("Enter the second natural number: ");
				int two = Int32.Parse(Console.ReadLine());
				if (one > two)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Error. The first number is greater than the second");
					return;
				}
				int sum = 0;
				while (one <= two)
				{
					sum += one * one;
					one++;
				}
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"The sum of the squares of the natural numbers is: {sum}");
			}
			catch 
			{
				Console.ForegroundColor= ConsoleColor.Red;
				Console.WriteLine("You didn't enter a number!!!");
			}
		}
	}
#endif
#if Chapter_3_7_2
	class Chapter_3_7_2
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Calculate the sum of the squares of the natural numbers");
				Console.WriteLine("Enter the first natural number: ");
				int one = Int32.Parse(Console.ReadLine());
				Console.WriteLine("Enter the second natural number: ");
				int two = Int32.Parse(Console.ReadLine());
				if (one > two)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Error. The first number is greater than the second");
					return;
				}
				int sum = 0;
				do
				{
					sum += one * one;
					one++;
				} while (one <= two);
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"The sum of the squares of the natural numbers is: {sum}");
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("You didn't enter a number!!!");
			}
		}
	}
#endif
#if Chapter_3_7_3
	class Chapter_3_7_3
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Calculate the sum of the squares of the natural numbers");
				Console.WriteLine("Enter the first natural number: ");
				int one = Int32.Parse(Console.ReadLine());
				Console.WriteLine("Enter the second natural number: ");
				int two = Int32.Parse(Console.ReadLine());
				if (one > two)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Error. The first number is greater than the second");
					return;
				}
				int sum = 0;
				for (int i = one; i <= two; i++)
				{
					sum += i * i;
				}
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"The sum of the squares of the natural numbers is: {sum}");
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("You didn't enter a number!!!");
			}
		}
	}
#endif
#if Chapter_3_7_4
	class Chapter_3_7_4
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Calculate the sum of the squares of the natural numbers");
				Console.WriteLine("Enter the first natural number: ");
				int one = Int32.Parse(Console.ReadLine());
				Console.WriteLine("Enter the second natural number: ");
				int two = Int32.Parse(Console.ReadLine());
				if (one > two)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Error. The first number is greater than the second");
					return;
				}
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"The sum of the squares of the natural numbers is: {snt(one, two)}");
			}
			catch 
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("You didn't enter a number!!!");
			}
		}
		static int snt(int one, int two)
		{
			int sum = 0;
			for (int i = one; i <= two; i++)
			{
				sum += Convert.ToInt32(Math.Pow(i, 2));
			}
			return sum;
		}
	}
#endif
#if Chapter_3_7_5_recursion
	class Chapter_3_7_5_recursion
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Calculate the sum of the squares of the natural numbers");
				Console.WriteLine("Enter the first natural number: ");
				int one = Int32.Parse(Console.ReadLine());
				Console.WriteLine("Enter the second natural number: ");
				int two = Int32.Parse(Console.ReadLine());
				if (one > two)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Error. The first number is greater than the second");
					return;
				}
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"The sum of the squares of the natural numbers is: {Snt(one, two)}");
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("You didn't enter a number!!!");
			}
		}
		static int Snt(int one, int two)
		{
			if(one >= two)return two;
			return Snt(one, two-1) + two * two;
		}
	}
#endif
}