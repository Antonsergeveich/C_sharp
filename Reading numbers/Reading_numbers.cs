using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class EnteringInteger
{
    static void Main()
    {
        //Текстовые переменные
        string res, txt;
        //Целочисленные переменные
        int year = 2024, age, born;
        //Отображение окна с полем ввода
        res = Interaction.InputBox("В каком году Вы родились?","Год рождения");
        //Преобразование текста в число
        born = Int32.Parse(res);
        //Вычисление возраста
        age = year-born;
        txt = "Тогда Вам " + age + " лет";
        //Окно с сообщением
        MessageBox.Show(txt,"Возраст");
    }
}