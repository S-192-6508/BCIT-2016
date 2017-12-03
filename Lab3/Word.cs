using System;

namespace LR3
{
	/// <summary>
	/// Дочерний класс Word,
	/// является элементом последовательности типа "Слово",
	/// Содержит:
	/// 	numer - номер элемента в последовательности
	/// 	Метод Word - заполнение наследуемого свойства Name и номера numer
	/// 	Вывод информации через интерфейс IPrint.	
	/// </summary>
	
	class Word : NumItem
	{
	    public Word(int n,string C)  
	    {
	        this.num = n;
	    	this.Name =" Слово: "+ C;
	    }
	    public void Print()  
	    {  
	        Console.WriteLine(this.ToString());  
	    }  
	}
}