//#define OddEven



using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

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

class Hundreds
{
	static void Main()
	{
		int number, hundreds;
		number = Int32.Parse(Interaction.InputBox("Введите целое число: ","Количество сотен"));
		hundreds = number / 100 % 10;
		string txt = "Число: "+number+"  \n"+ "Количество сотен в числе: " + hundreds;
		MessageBox.Show(txt, "Сотни",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
	}
}

