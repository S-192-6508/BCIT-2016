using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR3
{
	/// <summary>
	/// Пример работы стека.
	/// </summary>
	class SimpleStack
	{
		public SimpleStack(List<NumItem> ItemList)
		{
			Stack<NumItem> TypeStack = new Stack<NumItem>();
			Console.WriteLine("Порядок записи в Стек:");		    
			foreach (var x in ItemList){ Console.WriteLine(x); TypeStack.Push(x);}
			Console.WriteLine("Порядок вывода стека:");
			foreach (var t in TypeStack){ Console.WriteLine(t);}
			Console.WriteLine("Пример удалениея через Pop():\n Удалён первый элемент.");
			NumItem NI = TypeStack.Pop();
			Console.WriteLine("Остались:.");
			foreach (var t in TypeStack){ Console.WriteLine(t);}
			Console.WriteLine("\n\nНажмите любую кнопку для продолжения.");
	    	Console.ReadKey(true);
	    	Console.Clear();				
		}
	}
}
