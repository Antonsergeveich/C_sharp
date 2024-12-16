//#define MESSAGEBOX_5
//#define CONSOLE_5
//#define MESSAGEBOX_6
//#define CONSOLE_6
//#define MESSAGEBOX_7
//#define CONSOLE_7


using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Linq;

class YearOfBirth
{
    static void Main()
    {

#if MESSAGEBOX_5
        string year = Interaction.InputBox("Введите сегодняшний год", "Ввод года");
        string year_of_birth = Interaction.InputBox("Введите год Вашего рождения", "Ввод количества лет");
        int years_number = Int32.Parse(year);
        int year_of_birth_number = Int32.Parse(year_of_birth);
        int number_of_years = years_number - year_of_birth_number;
        string noy = number_of_years.ToString();
        string txt = "Вам " + noy;
        MessageBox.Show(txt, "Количество лет", MessageBoxButtons.OK, MessageBoxIcon.Information); 
#endif

#if CONSOLE_5
        int year = DateTime.Now.Year;
        Console.Title = "Ввод года рождения";
        Console.WriteLine("Введите год рождения");
        string year_of_birth = Console.ReadLine();
        int yob = Int32.Parse(year_of_birth);
        int age = year - yob;
        string txt = "Вам " + age + " лет";
        Console.WriteLine(txt); 
#endif

#if MESSAGEBOX_6
        string name_year = Interaction.InputBox("Введите Ваше имя и год рождения", "Ввод данных");
        string year = string.Concat(name_year.Where(char.IsNumber));//System.Linq Из строки только цифры
        string name = new String(name_year.Where(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)).ToArray()); //Строка с пробелами
        int year_now = DateTime.Now.Year; // Возвращает текущий год в int
        int year_age = Int32.Parse(year);
        int age = year_now - year_age;
        MessageBox.Show("Ваше имя: " + name + "\n" + "Ваш возраст: " + age); 
#endif
#if CONSOLE_6
        Console.Title = "Ввод имени и года рождения";
        Console.Write("Введите имя и год рождения: ");
        string name_year = Console.ReadLine();
        string year = string.Concat(name_year.Where(char.IsNumber));
        string name = new String(name_year.Where(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)).ToArray());
        int year_now = DateTime.Now.Year;
        int year_age = Int32.Parse(year);
        int age = year_now - year_age;
        Console.WriteLine("Ваше имя: " + name + "\n" + "Ваш возраст: " + age); 
#endif

#if MESSAGEBOX_7
        string age = Interaction.InputBox("Введите Ваш возраст", "Ввод данных");
        int year_now = DateTime.Now.Year;
        int age_now = Int32.Parse(age);
        int year_of_birth = year_now - age_now;
        MessageBox.Show("Ваш год рождения: " + year_of_birth, "Год рождения", MessageBoxButtons.OK, MessageBoxIcon.Information); 
#endif

#if CONSOLE_7
        Console.Title = "Ввод возраста";
        Console.WriteLine("Введите Ваш возраст: ");
        string age = Console.ReadLine();
        int age_now = int.Parse(age);
        int year_now = DateTime.Now.Year;
        int year_of_birth = year_now - age_now;
        Console.Title = "Год рождения";
        Console.WriteLine("Ваш год рождения " + year_of_birth); 
#endif


    }
}