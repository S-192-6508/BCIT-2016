using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LR3
{
	/// <summary>
	/// Description of Sparse_Matrix_Filler.
	/// </summary>
	class SparseMatrixFiller
	{
		public SparseMatrixFiller(List<NumItem> ItemList,int[] FixedModes)
		{
			Matrix<NumItem> matrix = new Matrix<NumItem>(6, 6, new ItemMatrixCheckEmpty());
			int i=0;
			Console.WriteLine("\nМатрица");
			foreach (var v in ItemList)
			{
				matrix[v._num, FixedModes[i]] = v;
				i=i+1;
			}
			Console.WriteLine(matrix.ToString());
		}
	}
}
