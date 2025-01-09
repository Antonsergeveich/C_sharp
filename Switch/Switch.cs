//#define SwitchDemo

using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

#if SwitchDemo
class SwitchDemo
{
	static void Main()
	{
		int number;
		string name;
		number = Int32.Parse(Interaction.InputBox("Введите число: ", "Число"));
		switch (number)
		{
			case 1: name = "Единица"; break;
			case 2: name = "Двойка"; break;
			case 3: name = "Тройка"; break;
			case 4: name = "Четверка"; break;
			default: name = "Неизвестное число"; break;
		}
		MessageBox.Show(name, "Число");
	}
} 
#endif
class AnotherSwitchDemo
{
	static void Main()
	{
		int number;
		string txt = "";
		number = Int32.Parse(Interaction.InputBox("Введите целое число от 1 до 9: ", "Число"));
		switch (number)
		{
			case 1:
			case 9:
				txt = "Вы ввели нечётное число,\n но не простое число."; break;
			case 2:
			case 3:
			case 5:
			case 7:
				txt = "Вы ввели простое число - это\n" +
					"числа которые не имеют других делителей,\n" +
					"кроме единицы и себя самого."; break;
			case 4:
			case 8:
				txt = "Вы ввели число - степень двойки.\n" +
					"2 во второй степени = 4\n" +
					"2 в третьей степени = 8."; break;
			case 6:
				txt = "Вы ввели совершенное число.\n" +
					"Сумма его делителей(1+2+3=6)\n" +
					"Равна самому этому числу\n" +
					"Следующее совершенное число 28\n" +
					"1+2+4+7+14=28"; break;
		}
		MessageBox.Show(txt,"Число");
	}
}