using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR3
{
	/// <summary>
	/// Класс Dictionary,строит словарь из полученного списка, имеет:
	/// 	Конструктор Dictionary- обеспечивает заполнение словаря по списку.
	/// 	Метод DictionaryPrint - обеспечивает вывод солваря с последуюшим удалением данных из консоли.
	/// </summary>
	class Dictionary
	{
		public static Dictionary<int, string> NameNumDictionary = new Dictionary<int, string>();
		public Dictionary(List<NumItem> ItemList)
		{
			foreach (var x in ItemList) NameNumDictionary.Add(x.num,x.Name);
			DictionaryPrint(NameNumDictionary);
			
		}
		public void DictionaryPrint(Dictionary<int, string> NameNumDictionary)
		{
			Console.WriteLine("Словарь:");
			foreach (KeyValuePair<int, string> v in NameNumDictionary)
			{
				Console.WriteLine(v.Key.ToString() + " -" + v.Value);
			}
			Console.WriteLine("\n\nНажмите любую кнопку для продолжения.");
	    	Console.ReadKey(true);
	    	Console.Clear();
		}
	}
}
