//#define OddEven
//#define Hundreds
//#define Cheking_for_three1
//#define Cheking_three
//#define Checking2
//#define Checking3
//#define Checking4
//#define Checking5
//#define Checking6
//#define Checking7
#define Checking8


using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Linq;




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
#if Cheking_three
class Checking_three
{
	static void Main()
	{
		string number = Interaction.InputBox("Введите число", "Проверка делится ли число на три");
		int[] arr_number = new int[number.Length];
		int sum = 0;
		for (int i = 0; i < arr_number.Length; i++)
		{
			sum += int.Parse(number[i].ToString());
		}
		if (sum % 3 == 0)
			MessageBox.Show($"Число: {number} делится на три без остатка", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
		else MessageBox.Show($"Число: {number} не делится на три без остатка", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
	}
	//number.ToCharArray().Select(c => int.Parse(c.ToString())).ToArray();
	//number.Select(q=>int.Parse(new string(q,1))).ToArray();
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
	#region 1
	//static void Main()
	//{
	//	int num = Int32.Parse(Interaction.InputBox("Введите положительное целое число", "Checking octal number system"));
	//	string res = Convert.ToString(num,8);//перевод десятичного числа в восьмеричную систему счисления
	//	int res_int = Convert.ToInt32(res);
	//	int num_two = res_int / 10 % 10;
	//	MessageBox.Show($"Число в восьмеричной системе счисления: {res}\nВторая справа цифра числа: {num_two}");
	//} 
	#endregion
	#region 2
	//static void Main()
	//{
	//	string num = Interaction.InputBox("Введите положительное целое число", "Checking octal number system");
	//	int length = num.Length;
	//	string res = "";

	//	while (length >= 0)
	//	{
	//		res += Convert.ToString(Int32.Parse(num) % 8);
	//		num = Convert.ToString(Convert.ToInt32(num) / 8);
	//		length--;
	//	}
	//	char[] resArray = res.ToCharArray();
	//	Array.Reverse(resArray);
	//	string reversed_res = new string(resArray);
	//	char n = reversed_res[reversed_res.Length-2];
	//	MessageBox.Show($"Число в восьмеричной системе счисления: {reversed_res}\nВторая справа цифра числа: {n}");
	//} 
	#endregion
	#region 3
	//static void Main()
	//{
	//	int number = Int32.Parse(Interaction.InputBox("Введите десятичное положительное число: ", "Input number"));
	//	string octal = Convert.ToString(number, 8);
	//	string result = Convert.ToString((number & 56) >> 3);
	//	MessageBox.Show($"Вы ввели число: {number}\nЧисло в восьмеричном представлении: {octal}\nВторая цифра восьмеричного представления числа справа: {result}", "Результат", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
	//} 
	#endregion
	#region 4
	//static void Main()
	//{
	//	int number = Int32.Parse(Interaction.InputBox("Введите положительное десятичное число: ","Ввод числа"));
	//	string octal = Convert.ToString(number,8);
	//	int result = (number / 8) % 8;
	//	MessageBox.Show($"Вы ввели число: {number}\nЧисло в восьмеричном представлении: {octal}\nВторая цифра восьмеричного представления числа справа: {result}");
	//} 
	#endregion
}
#endif
#if Checking7
class Checking7
{
	static void Main()
	{
		int number = Int32.Parse(Interaction.InputBox("Введите число", "Input"));
		string result = Convert.ToString(number, 2);
		string bit = Convert.ToString((number >> 2) & 1);
		MessageBox.Show($"Вы ввели десятичное число: {number}\n" +
		$"Число в двоичном представлении: {result}\n" +
		$"Третий бит справа: {bit}", "Result");
	}
} 
#endif
#if Checking8
class Checking8
{
	static void Main()
	{
		int number = Int32.Parse(Interaction.InputBox("Введите число", "Input"));
		int num = number | (1 << 2);
		MessageBox.Show($"Введённое число: {number}\n" +
			$"Число в двоичном представлении: {Convert.ToString(number,2)}\n" +
			$"Третий бит устанавливаем единицей: {Convert.ToString(num,2)}","Result");
	}
}
#endif