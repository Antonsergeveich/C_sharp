//#define MESSAGEBOX_8
//#define CONSOLE_8
//#define MESSAGEBOX_9
//#define CONSOLE_9
//#define MESSAGEBOX_10
//#define CONSOLE_10

using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Reflection;

class Sum
{
	static void Main()
	{
#if MESSAGEBOX_8
		string number_1 = Interaction.InputBox("Введите первое число: ", "Ввод первого числа для вычисления суммы");
		string number_2 = Interaction.InputBox("Введите второе число: ", "Ввод второго числа для вычисления суммы");
		int num_1 = Int32.Parse(number_1);
		int num_2 = Int32.Parse(number_2);
		int sum = num_1 + num_2;
		MessageBox.Show("Сумма двух чисел = " + sum, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information); 
#endif

#if CONSOLE_8
		Console.Title = "Ввод чисел";
		Console.Write("Введите первое число: \n");
		int number_1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Введите второе число: \n");
		int number_2 = int.Parse(Console.ReadLine());
		int sum = number_1 + number_2;
		Console.WriteLine($"Сумма двух чисел = {sum}"); 
#endif

#if MESSAGEBOX_9
		int number = Int32.Parse(Interaction.InputBox("Введите число: ", "Ввод числа"));
		int number_minus = number - 1;
		int number_plus = number + 1;
		MessageBox.Show
			(
			$"Введённое число на единицу меньше: {number_minus}\n" +
			$"Введённое число: {number}\n" +
			$"Введённое число на единицу больше: {number_plus}",
			"Результат",
			MessageBoxButtons.OK, MessageBoxIcon.Stop
			); 
#endif

#if CONSOLE_9
		Console.Title = "Число";
		Console.Write("Введите число: ");
		int num = int.Parse(Console.ReadLine());
		int num_minus = num - 1;
		int num_plus = num + 1;
		Console.Title = "Результат";
		Console.WriteLine
			(
			"Число на единицу меньше: " + num_minus + "\n" +
			"Введённое число: " + num + "\n" +
			"Число на единицу больше: " + num_plus
			); 
#endif

#if MESSAGEBOX_10
		int number_1 = Int32.Parse(Interaction.InputBox("Введите первое число: ", "Ввод первого числа"));
		int number_2 = Int32.Parse(Interaction.InputBox("Введите второе число: ", "Ввод второго числа"));
		int sum = number_1 + number_2;
		int difference = number_1 - number_2;
		MessageBox.Show
			(
			$"Cумма двух чисел = {sum}\n" +
			$"Разность двух чисел = {difference}",
			"Result", MessageBoxButtons.OKCancel,
			MessageBoxIcon.Information
			); 
#endif

#if CONSOLE_10
		Console.Title = "Ввод числа";
		Console.Write("Введите первое число: ");
		int number_1 = int.Parse(Console.ReadLine());
		Console.Write("Введите второе число: ");
		int number_2 = int.Parse(Console.ReadLine());
		int num_minus = number_1 - number_2;
		int num_plus = number_2 + number_1;
		Console.Title = "Result";
		Console.WriteLine
			(
			$"Сумма двух чисел = {num_plus}\n" +
			$"Разность двух чисел = {num_minus}"
			); 
#endif
		int A = 'A';
		Console.WriteLine("char 'A' = "+ A);
		Console.WriteLine();
		//int sum_int = 'A' + 'B';
		//Console.WriteLine(sum_int);
		//char sum_char = (char)('A' + 2);
		//Console.WriteLine(sum_char);
		//char res = (char)(4);
		//Console.WriteLine(res);
		for (int i = 65; i < 91; i++)
			Console.WriteLine($"char {(char)i} = {i}");
		
	}
}