using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR3
{
/// <summary>
    /// Родительский класс NumName, включает в себя:
	///     свойство Namе(данные элемента)
	/// 	параметр num(номер эл-та последовательности)
	/// 	метод ToString(), выводящий информацию об элементе в консоль.
	///		метод CompareTo() обеспечивает возможность сортировки по длине их полного имени. 	
    /// </summary>
    class NumItem:IComparable
	{
		  public string Name
		  {
        		get{return this._Name;}
        		set{this._Name=value;}
  		  }
		  public int num
		  {
        		get{return this._num;}
        		set{this._num=value;}
  		  }
  		  string _Name;
  		  public int _num;
 		  public override string ToString()
 		  {	
 		  		return  "ID:" + this._num.ToString()+"   Содержание:" +  this._Name;
		  }	
 		  public int CompareTo(object obj)
 		  {
	 		  NumItem NP = (NumItem)obj; 
	 		  if (this._Name.Length < NP._Name.Length) return (-1);
	 		  else if (this._Name.Length == NP._Name.Length) {return 0;}
	 		  else return 1;
 		  }
	}
};