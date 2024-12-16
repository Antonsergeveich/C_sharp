//#define MESSAGEBOX
//#define CONSOLE
//#define MESSAGEBOX_1
//#define CONSOLE_1
//#define MESSAGEBOX_2
//#define CONSOLE_2
//#define MESSAGEBOX_3
//#define CONSOLE_3



using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Linq;

class DialogName
{
    static void Main()
    {
#if MESSAGEBOX
        string name = Interaction.InputBox("Как Ваше имя?", "Ввод имени");
        string surname = Interaction.InputBox("Как Ваше фамилия", "Ввод фамилии");
        string txt = "Ваше имя: " + name + "\nВаше фамилия: " + surname + "\n";
        MessageBox.Show(txt, "Ваши данные", MessageBoxButtons.OK, MessageBoxIcon.Information); 
#endif

#if CONSOLE
        Console.Title = "Вавод имени и фамилии";
        Console.Write("Как Ваше имя?");
        string name = Console.ReadLine();
        Console.Write("Как Ваше фамилия?");
        string surname = Console.ReadLine();
        Console.Title = "Ваши данные";
        Console.Write("Сколько Вам лет?");
        string year = Console.ReadLine();
        Console.WriteLine("Ваше имя: " + name + "\n" + "Ваше фамилия: " + surname+"\n"+"Ваш возраст: "+year);
#endif

#if MESSAGEBOX_1
        string name = Interaction.InputBox("Как Ваше имя?", "Ввод данных");
        string year = Interaction.InputBox("Сколько Вам лет?", "Ввод данных");

        //string year = string.Concat(name_and_year.Where(char.IsNumber));
        //string name = " "+name_and_year.Split()[0];
        //string name = " "+name_and_year.Substring(0,15-0);
        //string name = new String(name_and_year.Where(Char.IsLetter).ToArray());
        string txt = "Ваше имя: " + name + "\n" + "Ваш возраст: " + year + "\n";
        MessageBox.Show(txt, "Ваши данные"); 
#endif

#if CONSOLE_1
        Console.Title = "Ввод имени";
        Console.Write("Как Ваше имя?");
        string name = Console.ReadLine();
        Console.Title = "Ввод количества лет";
        Console.Write("Сколько Вам лет?");
        string year = Console.ReadLine();
        Console.WriteLine("Ваше имя: " + name + "\n" + "Ваш возраст: " + year); 
#endif

#if MESSAGEBOX_2
        string day_of_the_week, month, the_number_of_the_day_in_the_month;
        day_of_the_week = Interaction.InputBox("Введите текущий день недели словом: ", "Ввод дня недели");
        month = Interaction.InputBox("Введите месяц: ", "Ввод месяца");
        the_number_of_the_day_in_the_month = Interaction.InputBox("Введите номер дня в месяце: ", "Ввод дня");
        string txt = "Сегодня " + day_of_the_week + " " + the_number_of_the_day_in_the_month + " " + month;
        MessageBox.Show(txt, "Дата", MessageBoxButtons.OK, MessageBoxIcon.Information); 
#endif

#if CONSOLE_2
        string day_of_the_week, month, the_number_of_the_day_in_the_month;
        Console.Title = "Ввод дня недели";
        Console.WriteLine("Введите день недели");
        day_of_the_week = Console.ReadLine();
        Console.Title = "Ввод числа";
        Console.WriteLine("Введите число");
        the_number_of_the_day_in_the_month = Console.ReadLine();
        Console.Title = "Ввод месяца";
        Console.WriteLine("Введите месяц");
        month = Console.ReadLine();
        Console.WriteLine("Сегодня: {0} ёпрст  {1} {2}", day_of_the_week, the_number_of_the_day_in_the_month, month); 
#endif

#if MESSAGEBOX_3
        string month_and_days = Interaction.InputBox("Введите месяц словом и количество дней в этом месяце цифрой", "INPUT");
        string month = " " + month_and_days.Split()[0];
        string days = " " + month_and_days.Split()[1];
        int days_number = Int32.Parse(days);
        string txt;
        if (days_number % 2 == 0)
        {
            txt = $"В {month} {days} дней";
        }
        else
        {
            txt = $"В {month} {days} день";
        }
        MessageBox.Show(txt, "Сколько дней в месяце", MessageBoxButtons.OK, MessageBoxIcon.Information); 
#endif

#if CONSOLE_3
        Console.Title = "Ввод месяца и количества дней в нём";
        Console.WriteLine("Введите месяц и количество дней в нём через пробел");
        string month_and_days = Console.ReadLine();
        string month = " " + month_and_days.Split()[0];
        string days = " " + month_and_days.Split()[1];
        int days_number = Int32.Parse(days);
        string txt;
        if (days_number % 2 == 0)
        {
            txt = $"В {month} {days} дней";
        }
        else
        {
            txt = $"В {month} {days} день";
        }
        Console.Title = "Результат";
        Console.WriteLine(txt); 
#endif





    }
}

