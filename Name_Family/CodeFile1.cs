//#define MESSAGEBOX
#define CONSOLE

using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;


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
        Console.WriteLine("Ваше имя: " + name + "\n" + "Ваше фамилия: " + surname); 
#endif
    }
}

