using System;
using System.Collections.Generic;
using System.Linq;

namespace LR4
{
	class ASearch
	{
		List<string> Rezult = new List<string>();
		public List<string> ASearcher(List<string> Words, int NumberOfTreads, int MaxDistance, string ComWord)
		{
			int[] TreadWords = new int[10];
			List<string> Words2 = new List<string>();
			List<string>[] TWord = new List<string>[10];						// Обьявление массива списков для обработки
			for(int i=0;i<NumberOfTreads;i++)
			{
				TWord[i]=new List<string>();
			}
			char[] Valid=new char[ComWord.Length];
			Valid[0]=ComWord[0];
			for(int i=0;i<ComWord.Length;i++)
				if(Array.IndexOf(Valid,ComWord[i])<0)Valid[i]=ComWord[i];
			foreach(string str in Words)										// Создание нового списка слов, подходящих для поиска по длине ип совпадению символов.
			{
				bool Length = false;
				bool Match = false;
				if(Math.Abs(str.Length-ComWord.Length)<MaxDistance+1) Match=true;
				char[] ValidCh=new char[str.Length];
				ValidCh[0]=str[0];
				int DDist=0;
				for(int i=0;i<str.Length;i++)
					if(Array.IndexOf(ValidCh,str[i])<0)ValidCh[i]=str[i];
				for(int i=0; i<ComWord.Length;i++)
				{
					bool NotMatch=true;
					for(int k=0; k<str.Length;k++)
					{
						if(Valid[i]==ValidCh[k]) NotMatch=false;								
					}
					if(NotMatch==true)DDist=DDist+1;
				}
				if(DDist<=MaxDistance)Match = true;
				if((Length==true)||(Match==true)) Words2.Add(str);
				
			}
			
			int Ost = Words2.Count()%NumberOfTreads;							// Деление списка на части
			for(int i=0;i<NumberOfTreads;i++)
			{
				TreadWords[i]= Words2.Count()/NumberOfTreads;
				if(Ost!=0) {TreadWords[i]=TreadWords[i]+1;Ost=Ost-1;}
			}

			int j = 1;
			foreach(string str in Words2)
			{
				if(j<=TreadWords[0]) TWord[0].Add(str);
				else
					if(j<=TreadWords[0]+TreadWords[1]) TWord[1].Add(str);
					else
						if(j<=TreadWords[0]+TreadWords[1]+TreadWords[2]) TWord[2].Add(str);
						else
							if(j<=TreadWords[0]+TreadWords[1]+TreadWords[2]+TreadWords[3]) TWord[3].Add(str);
							else
								if(j<=TreadWords[0]+TreadWords[1]+TreadWords[2]+TreadWords[3]+TreadWords[4]) TWord[4].Add(str);
								else
									if(j<=TreadWords[0]+TreadWords[1]+TreadWords[2]+TreadWords[3]+TreadWords[4]+TreadWords[5]) TWord[5].Add(str);
									else
										if(j<=TreadWords[0]+TreadWords[1]+TreadWords[2]+TreadWords[3]+TreadWords[4]+TreadWords[5]+TreadWords[6]) TWord[6].Add(str);
										else
											if(j<=TreadWords[0]+TreadWords[1]+TreadWords[2]+TreadWords[3]+TreadWords[4]+TreadWords[5]+TreadWords[6]+TreadWords[7]) TWord[7].Add(str);
											else
												if(j<=TreadWords[0]+TreadWords[1]+TreadWords[2]+TreadWords[3]+TreadWords[4]+TreadWords[5]+TreadWords[6]+TreadWords[7]+TreadWords[8]) TWord[8].Add(str);
												else
													if(j<=TreadWords[0]+TreadWords[1]+TreadWords[2]+TreadWords[3]+TreadWords[4]+TreadWords[5]+TreadWords[6]+TreadWords[7]+TreadWords[8]+TreadWords[9]) TWord[9].Add(str);
				j=j+1;
			}
			Distance Dist = new Distance();
			Rezult = Dist.LDistance(TWord,MaxDistance,ComWord,NumberOfTreads);
			return Rezult;
		}

	}
}
		