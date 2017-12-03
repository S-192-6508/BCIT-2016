using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LR3
	
{
	/// <summary>
	/// Дочерний класс Word,
	/// является элементом последовательности типа "Код",
	/// Содержит:
	/// 	numer - номер элемента в последовательности
	/// 	Метод Code - заполнение наследуемого свойства Name и номера numer
	/// 	Вывод информации через интерфейс IPrint.	
	/// </summary>

	class Code : NumItem
	{
	    public Code(int n,string C)  
	    {
	    	this.num = n;
	    	this.Name =" Код: "+ C;
	    }
	    public void Print()  
	    {  
	        Console.WriteLine(this.ToString());  
	    }  
	}
}