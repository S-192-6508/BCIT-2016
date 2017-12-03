using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LR3
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	class NongenericList
	{
		public NongenericList(List<NumItem> ItemList)
		{
			ArrayList AL = new ArrayList();
			bool AreThereCode = false;
			bool AreThereWord = false;
			bool AreThereNumber = false;
			bool AreThereMixed = false;
			foreach (var x in ItemList) AL.Add(x);
			Console.WriteLine("Сортировка элементов по типу:");
			foreach(object o in AL)
			{
				string type = o.GetType().Name;
				if (type == "Code") AreThereCode = true;
				if (type == "Word") AreThereWord = true;
				if (type == "Mixed") AreThereMixed = true;
				if (type == "Number") AreThereNumber = true;
			}
			if(AreThereWord == true)
			{
				Console.WriteLine("Слова:");
				foreach (object o in AL)
				{
					string type = o.GetType().Name;
					if (type == "Word") Console.WriteLine(o.ToString());
				}
			}
			if(AreThereCode == true)
			{
				Console.WriteLine("Коды:");
				foreach (object o in AL)
				{
					string type = o.GetType().Name;
					if (type == "Code") Console.WriteLine(o.ToString());
				}
			}
			if(AreThereMixed == true)
			{
			Console.WriteLine("Смешанные:");
				foreach (object o in AL)
				{
					string type = o.GetType().Name;
					if (type == "Mixed") Console.WriteLine(o.ToString());
				}
			}
			if(AreThereNumber == true)
			{
				Console.WriteLine("Номера:");
				foreach (object o in AL)
				{
					string type = o.GetType().Name;
					if (type == "Number") Console.WriteLine(o.ToString());
				}
			}
			Console.WriteLine("\n\nНажмите любую кнопку для продолжения.");
	   		Console.ReadKey(true);
	     	Console.Clear();
		}
	}
}
