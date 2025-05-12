﻿using System;//Для вывода в консоль
using Microsoft.VisualBasic;//Для отображения окна с полем ввода
using System.Windows.Forms;
class DialogDemo
{
    static void Main()
    {
        //При работе с окнами нужно в Properties проекта выставить Windows Application
        //Project -> name Proparties -> Application -> Windows Aplication
        //MessageBox.Show("Продолжаем изучать C#");
        //MessageBox.Show("Всем привет", "Окно с названием", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        /*string name = Interaction.InputBox("Как Вас зовут?", "Давайте познакомимся");
        string txt = "Очень приятно, " + name + "!";
        MessageBox.Show(txt, "Знакомство состоялось",MessageBoxButtons.OK,MessageBoxIcon.Information);*/

        // При работе с консолью нужно в Properties проекта выставить Console Application
        string name_txt;
        Console.Title = "Давайте познакомимся";
        Console.Write("Как Вас зовут?");
        name_txt = Console.ReadLine();
        string txt_console = "Очень приятно, " + name_txt + "!";
        Console.Title = "Знакомство состоялось";
        Console.WriteLine(txt_console);


    }
}