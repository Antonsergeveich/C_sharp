//#define MESSAGEBOX
//#define CONSOLE

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

        string name = Interaction.InputBox("Как Ваше имя?","Ввод данных");
        string year = Interaction.InputBox("Сколько Вам лет?","Ввод данных");

        //string year = string.Concat(name_and_year.Where(char.IsNumber));
        //string name = " "+name_and_year.Split()[0];
        //string name = new String(name_and_year.Where(Char.IsLetter).ToArray());
        string txt = "Ваше имя: "+name+"\n"+"Ваш возраст: "+year+"\n";
        MessageBox.Show(txt,"Ваши данные");

    }
}

