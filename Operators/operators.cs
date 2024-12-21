//#define OddEven
//#define Hundreds
//#define Cheking_for_three1
//#define Checking2
//#define Checking3
//#define Checking4
//#define Checking5
#define Checking6

using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Reflection;




#if OddEven
class OddEven
{
	static void Main()
	{
		int number, reminder;
		number = Int32.Parse(Interaction.InputBox("Введите целое число", "Проверка"));
		reminder = number % 2;
		string txt = "Вы ввели: ";
		txt += (reminder == 0 ? "чётное" : "не чётное") + " число!";
		MessageBox.Show(txt, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
} 
#endif
#if Hundreds
class Hundreds
{
	static void Main()
	{
		int number, hundreds;
		number = Int32.Parse(Interaction.InputBox("Введите целое число: ", "Количество сотен"));
		hundreds = number / 100 % 10;
		string txt = "Число: " + number + "  \n" + "Количество сотен в числе: " + hundreds;
		MessageBox.Show(txt, "Сотни", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
	}
} 
#endif
#if Cheking_for_three1
class Checking_for_three
{
	static void Main()
	{
		/*int number, remainder;
		number = Int32.Parse(Interaction.InputBox("Введите число: ", "Проверка делится ли число на три"));
		remainder = number % 3;
		string txt = "Число: " + number + "\n";
		txt += (remainder == 0 ? "Делится на три без остатка" : "Не делится на три без остатка");
		MessageBox.Show(txt, "Checking for three");*/
	}
} 
#endif
#if Checking2
class Cheking2
{
	static void Main()
	{
		int number = Int32.Parse(Interaction.InputBox("Введите число " +
			"которое при делении на 5 даёт остаток 2 \n" +
			"а при делении на 7 \nостаток 1", "Checking"));
		int five = number % 5, seven = number % 7;
		if (five == 2 && seven == 1)
			MessageBox.Show("Yes, This is the number 22", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
		else MessageBox.Show("No, this is the number 22", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
} 
#endif
#if Checking3
class Checking3
{
	static void Main()
	{
		int number = Int32.Parse(Interaction.InputBox("Введите число:\nкоторое делится на 4 и не меньше 10", "Cheking"));
		while (number % 4 != 0 || number < 10)
		{
			MessageBox.Show("No, try again", "Checking result");
			number = Int32.Parse(Interaction.InputBox("Введите число:\nкоторое делится на 4 и не меньше 10", "Cheking"));
		}
		MessageBox.Show($"Yes, this is the number {number}", "Cheking result");
	}
} 
#endif
#if Checking4
class Cheking4
{
	static void Main()
	{
		int num = Int32.Parse(Interaction.InputBox("Введите число которое попадает в диапазон от 5 до 10","Cheking"));
		while (num < 5 || num > 10)
		{
			MessageBox.Show("No, try again","Checking result");
			num = Int32.Parse(Interaction.InputBox("Введите число которое попадает в диапазон от 5 до 10", "Checking"));
		}
		MessageBox.Show($"Yes, this is the number {num}", "Checking result");
	}
}
#endif
#if Checking5
class Checking5
{
	static void Main()
	{
		long num = Int64.Parse(Interaction.InputBox("Введите число", "Checking"));
		long thousands = num / 1000 % 1000;
		string txt = $"Число: {num} \nКоличество тысяч: {thousands}";
		MessageBox.Show(txt, "Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
	}
}
#endif
#if Checking6

class Checking6
{
	static void Main()
	{
		int num = Int32.Parse(Interaction.InputBox("Введите положительное целое число", "Checking octal number system"));
		string res = Convert.ToString(num,8);//перевод десятичного числа в восьмеричную систему счисления
		MessageBox.Show(res);
	}
}
#endif