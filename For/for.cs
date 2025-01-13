//#define ForDemo
//#define ForDemoTwo
#define ForDemoThree

using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

#if ForDemo
class ForDemo
{
	static void Main()
	{
		int n = 10, k, s = 0;
		Console.Write("Сумма 1+3+5+...+{0} = ", 2 * n - 1);
		for (k = 1; k <= n; k++)
		{
			s += 2 * k - 1;
		}
		Console.WriteLine(s);
	}
} 
#endif
#if ForDemoTwo
class ForDemoTwo
{
	static void Main()
	{
		int n = 10, s = 0;
		Console.Write("Сумма 1+3+5+...+ {0} = ", 2 * n - 1);
		for (int k = 1; k <= n; k++)
		{
			s += 2 * k - 1;
		}
		Console.WriteLine(s);
	}
} 
#endif
#if ForDemoThree
class ForDemoThree
{
	static void Main()
	{
		int n = 10, k, s;
		Console.Write("Сумма 1+3+5+..+{0} = ", 2 * n - 1);
		for (k = 1, s = 0; k <= n; s += 2 * k - 1, k++) ;
		Console.WriteLine(s);
	}
}
#endif