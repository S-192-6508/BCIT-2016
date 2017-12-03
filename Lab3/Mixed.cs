using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LR3
{
	/// <summary>
	/// Дочерний класс Mixed,
	/// является элементом последовательности типа "Mixed",
	/// Содержит:
	/// 	numer - номер элемента в последовательности
	/// 	Метод Name - заполнение наследуемого свойства Name и номера numer
	/// 	Вывод информации через интерфейс IPrint.	
	/// </summary>

	class Mixed : NumItem
	{
	    public Mixed(int n,string C)  
	    {
	    	this.num = n;
	    	this.Name =" Mixed: "+ C;
	    }
	    public void Print()  
	    {  
	        Console.WriteLine(this.ToString());  
	    }  
	}
}