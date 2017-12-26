using System;

namespace LR6_2
{
	/// <summary>
	/// Description of ClassExample2.
	/// </summary>
	class Coder:DataCollector
	{
		public double[,] CodedData;
		public Coder(DataForCoding[] DFC,int NumberOfRecords):base(DFC,NumberOfRecords)
		{
			double[,] CD=new double[NumberOfRecords,4];
			for(int i=0;i<NumberOfRecords;i++)
			{
				CD[i,0]=Property1[i].B_num;
				CD[i,1]=Property1[i].R_num;
				if(Property1[i].Name=="Exp")CD[i,2]=1;
				if(Property1[i].Name=="Opt")CD[i,2]=2;
				if(Property1[i].Name=="Reg")CD[i,2]=3;
				CD[i,3]=Property1[i].Time;
			}
			CodedData=CD;
		}
		public void CodedDataReturn(int NumberOfRecords)
		{
			for(int i=0;i<NumberOfRecords;i++)
			{ 
					Console.WriteLine("  "+CodedData[i,0]+"  "+CodedData[i,1]+"  "+CodedData[i,2]+"  "+CodedData[i,3]);
				Console.WriteLine("\n");
			}
			Console.ReadKey(true);
			Console.Clear();
		}
	}
}
