//#define UsingIfDemo
//#define AnotherIfDemo


using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;


#if UsingIfDemo
class UsingIfDemo
{
	static void Main()
	{
		MessageBoxIcon icon;
		string msg, title, name;
		name = Interaction.InputBox("Как Вас зовут?", "Знакомимся");
		if (name == "")
		{
			icon = MessageBoxIcon.Error;
			msg = "Очень жаль, что мы не познакомились!";
			title = "Знакомство не состоялось";
		}
		else
		{
			icon = MessageBoxIcon.Information;
			msg = "Очень приятно, " + name + "!";
			title = "Знакомство состоялось";
		}
		MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
	}
} 
#endif

#if AnotherIfDemo
class AnotherIfDemo
{
	static void Main()
	{
		MessageBoxIcon icon = MessageBoxIcon.Error;
		string msg = "Очень жаль, что мы не познакомились!",
			title = "Знакомство не состоялось",
			name;
		name = Interaction.InputBox("Как Вас зовут?", "Знакомимся");
		if (name != "")
		{
			icon = MessageBoxIcon.Information;
			msg = "Очень приятно, " + name + "!";
			title = "Знакомство состоялось";
		}
		MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
	}
} 
#endif