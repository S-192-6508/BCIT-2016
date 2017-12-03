using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR3
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	class ItemMatrixCheckEmpty : IMatrixCheckEmpty<NumItem> 
	{ 
		public NumItem getEmptyElement() 
		{ 
			return null;
		}
		public bool checkEmptyElement(NumItem element)
		{
			bool Result = false;
			if (element == null) 
			{ 
				Result = true;
			} 
			return Result; 
		} 
	}
}
