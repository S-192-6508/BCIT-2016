/*Часть 2. Разработать программу, реализующую работу с рефлексией.

	2. Создайте класс, содержащий конструкторы, свойства, методы.\/
	3. С использованием рефлексии выведите информацию о конструкторах, свойствах, методах.
	4. Создайте класс атрибута (унаследован от класса System.Attribute).
	5. Назначьте атрибут некоторым свойствам классам. Выведите только те свойства, которым назначен атрибут.
	6. Вызовите один из методов класса с использованием рефлексии.*/
using System;
using System.Reflection;

namespace LR6_2
{
	class Program
	{
		
		public static void Main(string[] args)
		{
			DataForCoding[] DFC = new DataForCoding[5];
			for(int i=0;i<5;i++)
			{
				DFC[i]=new DataForCoding();
			}
			Coder C = new Coder(DFC,5);
			C.CodedDataReturn(5);

			Type t = C.GetType();
			Console.WriteLine("\nИнформация о типе:");
			Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName); 
			Console.WriteLine("Пространство имен " + t.Namespace);
			Console.WriteLine("Находится в сборке " + t.AssemblyQualifiedName);
			Console.WriteLine("\nКонструкторы:");
			foreach (var x in t.GetConstructors()) 
			{ 
				Console.WriteLine(x); 
			}
			Console.WriteLine("\nМетоды:");
			foreach (var x in t.GetMethods()) 
			{ 
				Console.WriteLine(x);
			}
			Console.WriteLine("\nСвойства:");
			foreach (var x in t.GetProperties()) 
			{ 
				Console.WriteLine(x); 
			}
			Console.WriteLine("\nПоля данных (public):");
			foreach (var x in t.GetFields())
			{ 
				Console.WriteLine(x);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}