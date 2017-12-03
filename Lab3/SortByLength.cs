using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LR3
{
	/// <summary>
	/// Сортировщик последовательностей элементов по длине их содержимого, включая название типа.
	/// Содержит метод SortByLength, на вход которому передаётся список. Метод выводит элементы 
	/// списка до сортировки, после чего сортирует их, а потом выводит их снова.
	/// </summary>
	class SortByLength
	{
		public SortByLength(List<NumItem> ItemList)
		{
			Console.WriteLine("\nПеред сортировкой:");
		    foreach (var x in ItemList) Console.WriteLine(x); 
		    ItemList.Sort();
		    Console.WriteLine("\nПосле сортировки:");
	    	foreach (var x in ItemList) Console.WriteLine(x);
	    	Console.WriteLine("\n\nНажмите любую кнопку для продолжения.");
	    	Console.ReadKey(true);
	    	Console.Clear();
		}
		
	}
}
