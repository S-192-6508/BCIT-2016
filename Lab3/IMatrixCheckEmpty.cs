using System;

namespace LR3
{
	/// <summary>
	/// Description of Interface1.
	/// </summary>
	public interface IMatrixCheckEmpty<T>
	{ 
		T getEmptyElement();
		bool checkEmptyElement(T element);
	}
}
