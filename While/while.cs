//#define WhileDemo

using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

#if WhileDemo
class WhileDemo
{
	static void Main()
	{
		int n = 10, k = 1, s = 0;
		Console.Write("Сумма 1+3+5+...+{0} = ", 2 * n - 1);//Вместо инструкции {0} подставляется результат выражения (2 * n - 1)
		while (k <= n)
		{
			s += 2 * k - 1;
			k++;
		}
		Console.WriteLine(s);
	}
} 
#endif
class AnotherWhileDemo
{
	static void Main()
	{
		int n = 10, s = 0;
		Console.Write("Сумма 1+3+5+...+{0}= ", 2 * n - 1);
		while (n>0)
		{
			s += 2 * n - 1;
			n--;
		}
		Console.WriteLine(s);
	}
}