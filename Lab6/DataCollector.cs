using System;

namespace LR6_2
{

	class DataCollector
	{
		public DataCollector(DataForCoding[] DFC,int NumberOfRecords)
		{
			for(int i=0;i<NumberOfRecords;i++)
			{
				Random R = new Random(); 
				DFC[i].B_num = R.Next(1,6);
				Console.WriteLine("Block No{0}",(DFC[i].B_num));
				DFC[i].R_num = i+1;
				Console.WriteLine("Record No{0}",(DFC[i].R_num));
				switch(R.Next(1,4))
				{
					case 1:{DFC[i].Name="Exp";break;}
					case 2:{DFC[i].Name="Opt";break;}
					case 3:{DFC[i].Name="Reg";break;}
				}
				Console.WriteLine("Name :"+DFC[i].Name);
				DFC[i].Time = (double)R.Next(0,21)+(double)R.Next(0,101)*0.01;
				Console.WriteLine("Time :"+DFC[i].Time);
				Console.ReadKey(true);
				Console.Clear();
			}
			Property1 = DFC;
		}
		public DataForCoding[] Property1
        {
            get
            {
                return this._Property1;
                
            }
            set
            {
                this._Property1 = value;
            }
        }
		DataForCoding[] _Property1;
	}
}
