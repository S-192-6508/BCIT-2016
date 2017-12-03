using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR3
{
	/// <summary>
	/// Класс заполнения элементов последовательности в зависимости от выбранного типа элемента.
	/// Содержит методы:
	/// 	TypeChoser - выбор типа элемента
	/// 	SWCM - заполнение элемента в зависимости от его типа
	/// </summary>
	class SetWordCodeMixed
	{
		public int TypeChoser (int Mode)
		{
			bool Err = false;
			Console.WriteLine("Тип вводимого объекта:\n  1.Имя.   2.Код.   3.Смешанный.   4.Номер.");
			while((Err==false))
			{
				string c = Console.ReadLine();
		        Err=int.TryParse(c,out Mode);
		        if((Err==false)||(Mode<1)||(Mode>4)) {Console.WriteLine("Ошибка!Неверно выбран тип объекта./n");  Console.WriteLine("Тип вводимого объекта:/n  1.Имя.   2.Код./n"); Err=false;}
		        else Err=true;
		    }
		    return Mode;
		}
		
	    public string SWCM(int Mode, string C)
	    {
	    	switch(Mode)
	        {
	            case 1:
	    			{
	                    Console.WriteLine("Задайте Слово (должно состоять только из букв).");
	                   bool Err1 = false;
	                    while((Err1==false))
	                    {
	                    	C=Console.ReadLine();
	                    	Err1=true;
	                    	for (int i = 0; i < C.Length; i++)
	                    	{if(char.IsLetter(C[i])==false) Err1=false;}
	                        if((Err1==false)) {Console.WriteLine("Ошибка!Неверно введено слово.");Console.WriteLine("Задайте Слово (должно состоять только из букв)."); Err1=false;}
	                        else Err1=true;
	                    }
	                    break;
	    			}	                
	            case 2:
	                {
	                    int a;
	                    Console.WriteLine("Задайте Код (должен состоять только из чисел).");
	                    bool Err1 = false;
	                    while((Err1==false))
	                    {
	                    	C=Console.ReadLine();
	                        Err1=int.TryParse(C,out a);
	                        if((Err1==false)) {Console.WriteLine("Ошибка!Неверно введён код.");Console.WriteLine("Задайте Код (должен состоять только из чисел)./n"); Err1=false;}
	                        else Err1=true;
	                    }
	                    break;
	                }
	        		case 3:
	                {
	                    Console.WriteLine("Задайте Смешанную последовательность символов и чисел.");
	                    C=Console.ReadLine();
	                    break;
	                }
	            }
	        return C;
	        }
	    }
}