using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LR3
{
	/// <summary>
	/// Данные в матрице записываются в таком прядке:
	/// 	Строки - номер элемента.
	/// 	Столбцы - тип элемента.
	/// </summary>
	public class Matrix<T> 
	{
		Dictionary<string, T> _matrix = new Dictionary<string, T>();
		int maxX;
		int maxY;
		IMatrixCheckEmpty<T> сheckEmpty;
		public Matrix(int px, int py, IMatrixCheckEmpty<T> сheckEmptyParam)
		{
			this.maxX = px;
			this.maxY = py;
			this.сheckEmpty = сheckEmptyParam;
		}
		 public T this[int x, int y] 
		 {
		 	set
		 	{ 
		 		CheckBounds(x, y);
		 		string key = DictKey(x, y);
		 		this._matrix.Add(key, value);
		 	}
		 	get
		 	{ 
		 		CheckBounds(x, y);
		 		string key = DictKey(x, y);
		 		if (this._matrix.ContainsKey(key))
		 		{ 
		 			return this._matrix[key]; 
		 		} 
		 		else 
		 		{ 
		 			return this.сheckEmpty.getEmptyElement();
		 		} 
		 	}
		 }
		 void CheckBounds(int x, int y)
		 {
		 	if (x < 0 || x >= this.maxX) 
		 	{
		 		throw new ArgumentOutOfRangeException("x", "x=" + x + " выходит за границы");
		 	} 
		 	if (y < 0 || y >= this.maxY) 
		 	{
		 		throw new ArgumentOutOfRangeException("y", "y=" + y + " выходит за границы");
		 	} 
		 }
		string DictKey(int x, int y)
		{
			return x.ToString() + "_" + y.ToString();
		}
		public override string ToString() 
		{ 
			StringBuilder b = new StringBuilder();
			for (int j = 0; j < this.maxY; j++)
			{ 
				b.Append("["); for (int i = 0; i < this.maxX; i++)
				{ 
					if (i > 0) 
					{ 
						b.Append("\t");
					} 
					if (!this.сheckEmpty.checkEmptyElement(this[i, j]))
					{ 
						b.Append(this[i, j].ToString());
					} 
					else 
					{
						 b.Append(" _ "); 
					} 
				} 
				b.Append("]\n");
			} 
			return b.ToString(); 
		} 
	}	 
}