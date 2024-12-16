//#define MESSAGEBOX
//#define CONSOLE
using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class YearOfBirth
{
    static void Main()
    {

#if MESSAGEBOX
        string year = Interaction.InputBox("Введите сегодняшний год", "Ввод года");
        string year_of_birth = Interaction.InputBox("Введите год Вашего рождения", "Ввод количества лет");
        int years_number = Int32.Parse(year);
        int year_of_birth_number = Int32.Parse(year_of_birth);
        int number_of_years = years_number - year_of_birth_number;
        string noy = number_of_years.ToString();
        string txt = "Вам " + noy;
        MessageBox.Show(txt, "Количество лет", MessageBoxButtons.OK, MessageBoxIcon.Information); 
#endif

#if CONSOLE
        int year = DateTime.Now.Year;
        Console.Title = "Ввод года рождения";
        Console.WriteLine("Введите год рождения");
        string year_of_birth = Console.ReadLine();
        int yob = Int32.Parse(year_of_birth);
        int age = year - yob;
        string txt = "Вам " + age + " лет";
        Console.WriteLine(txt); 
#endif

    }
}