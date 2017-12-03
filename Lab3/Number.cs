using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LR3
{
	/// <summary>
	/// Дочерний класс Number,
	/// является элементом последовательности типа "Номер",
	/// Содержит:
	/// 	numer - номер элемента в последовательности
	/// 	Вывод информации через интерфейс IPrint.	
	/// </summary>

	class Number : NumItem
	{
	    public Number(int n)  
	    {
	    	this.num = n;
	    	this.Name = " Номер: "+this.num.ToString();
	    }
	    public void Print()  
	    {  
	        Console.WriteLine(this.ToString());  
	    }  
	}
}
