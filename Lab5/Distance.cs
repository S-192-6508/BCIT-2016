using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace LR4
{	
	public class Distance
	{
		public List<string> Rezult = new List<string>();
		public List<string> LDistance(List<string>[] TWord,int MaxD,string CWord, int NOfTr)
		{
			Data[] DataInput = new Data[NOfTr];					// Создание массива классов-хранидища информации
			Thread[] Sercher = new Thread[NOfTr];				// Запуск потоков параллельного поиска + заполнение хранилищ данных
			for(int i=0; i<NOfTr; i++)
			{
				DataInput[i] = new Data();
				DataInput[i].Dist = MaxD;
				DataInput[i].Word = CWord;
				DataInput[i].Words = TWord[i];
				DataInput[i].RezultOfTr = new List<string>();
				DataInput[i].Num = i;
				Sercher[i]=new Thread(new ParameterizedThreadStart(TreadSearch));
				Sercher[i].Start(DataInput[i]);
			}
			bool IsCompleted=false;
			while(IsCompleted==false)							// Ожидание завершения работы всех потоков.
			{
				IsCompleted = true;
				for(int i=1; i<NOfTr; i++)
					if(Sercher[i].IsAlive==true)IsCompleted=false;
			}
			for(int i=0; i<NOfTr; i++)
			{
				Rezult.AddRange(DataInput[i].RezultOfTr);
			}
			return Rezult;
		}

		public void TreadSearch(object DIn)
		{
			Data Dat1 = (Data)DIn;

			string S = null;
			foreach(string str in Dat1.Words)
			{
				int D  = LDistance(str,Dat1.Word);
				if (D<=Dat1.Dist)
				{
					S = S+"Tread № "+(Dat1.Num+1) + "Distance between" + Dat1.Word + " and " + str + " equals " + D + ";\n";
					Dat1.RezultOfTr.Add(S);
				}
				S="";
			}
		}
		public static int LDistance(string str1Param, string str2Param)
		{ 
			if ((str1Param == null) || (str2Param == null)) return -1;
			int str1Len = str1Param.Length;
			int str2Len = str2Param.Length;
			if ((str1Len == 0) && (str2Len == 0)) return 0;
			if (str1Len == 0) return str2Len;
			if (str2Len == 0) return str1Len;
			string str1 = str1Param.ToUpper();
			string str2 = str2Param.ToUpper();
			int[,] matrix = new int[str1Len + 1, str2Len + 1];
			for (int i = 0; i <= str1Len; i++)
				matrix[i, 0] = i;
			for (int j = 0; j <= str2Len; j++) 
				matrix[0, j] = j;
			for (int i = 1; i <= str1Len; i++) 
			{ 
				for (int j = 1; j <= str2Len; j++)
				{ 
					int symbEqual = ( (str1.Substring(i - 1, 1) == str2.Substring(j - 1, 1)) ? 0 : 1);
					int ins = matrix[i, j - 1] + 1; 
					int del = matrix[i - 1, j] + 1; 
					int subst = matrix[i - 1, j - 1] + symbEqual;
					matrix[i, j] = Math.Min(Math.Min(ins, del), subst);
					if ((i > 1) && (j > 1) && (str1.Substring(i - 1, 1) == str2.Substring(j - 2, 1)) && (str1.Substring(i - 2, 1) == str2.Substring(j - 1, 1)))
					{
						matrix[i, j] = Math.Min(matrix[i, j], matrix[i - 2, j - 2] + symbEqual);
					}
				} 
			}
			return matrix[str1Len, str2Len]; 
		}
	}
}


