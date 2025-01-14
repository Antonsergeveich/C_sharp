//#define TryCatchDemo
#define Chapter_3_1

using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
			int number = Int32.Parse(Interaction.InputBox("Введите целое число", "Input"));
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
