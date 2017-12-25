using System;

namespace LR6
{
	class Program
	{
		struct UncodedData
		{
			public int BlockNumber;
			public int Number;
			public string Type;
			public double Time;
		}
		delegate UncodedData DataUncoder(int Num,double[,] UncodingData);
		delegate string DataReturner(UncodedData RecDat);
		delegate double BlockResult(int BlockNum,double[,] UncodingData);
		delegate void BlockResultReturner(int BlockNum,double[,] UncodingData,BlockResult BR1,BlockResult BR2);
	    static void Main(string[] args)
	    {
	    	double[,] Data ={{ 1, 1, 1, 5.765 },{ 1, 2, 2, 4.144 }, { 2, 1, 3, 3.325 }, { 2, 1, 4, 12.315 }};	//Матрица зашифрованных данных
	    	DataUncoder Unc = new DataUncoder(Uncoder);
	    	UncodedData UncDat1= Unc.Invoke(0,Data);
	    	UncodedData UncDat2= Unc.Invoke(1,Data);
			UncodedData UncDat3= Unc.Invoke(2,Data);
			UncodedData UncDat4= Unc.Invoke(3,Data);
			Console.WriteLine("Data return, first standart:");
			DataReturner DR = new DataReturner(FirstStandart);
			Console.WriteLine(DR.Invoke(UncDat1));
			Console.WriteLine(DR.Invoke(Unc.Invoke(1,Data)));
			Console.WriteLine("Data return, second standart:");
			DR = SecondStandart;
			Console.WriteLine(DR.Invoke(UncDat3));
			Console.WriteLine(DR.Invoke(Unc.Invoke(3,Data)));
	        Console.ReadKey(true);
	        Console.Clear();
	         BlockResult BRRec = (int BlockNum,double[,] UncodingData)=>
	        {
	        	double SRecords=0;
	        	for(int i=0;i<4;i++)
	        		if((int)UncodingData[i,0]==BlockNum)  SRecords= SRecords+1;
	        	return  SRecords;
	        };
	        BlockResult BRTime = (int BlockNum,double[,] UncodingData)=>
	        {
	        	double STime=0;
	        	for(int i=0;i<4;i++)
	        		if((int)UncodingData[i,0]==BlockNum) STime=STime+UncodingData[i,3];
	        	return STime;
	        };
	        BlockResultReturner BRR = new BlockResultReturner(BRR1);
	        Console.WriteLine("Blocks Results:");
	        BRR.Invoke(1,Data,BRRec,(int BlockNum,double[,] UncodingData)=>
	        {
	        	double STime=0;
	        	for(int i=0;i<4;i++)
	        		if((int)UncodingData[i,0]==BlockNum) STime=STime+UncodingData[i,3];
	        	return STime;
	        });
	        BRR2(2,Data,(int BlockNum,double[,] UncodingData)=>
	        {
	        	double STime=0;
	        	for(int i=0;i<4;i++)
	        		if((int)UncodingData[i,0]==BlockNum) STime=STime+UncodingData[i,3];
	        	return STime;
	        },BRTime);

	        Console.ReadKey(true);
	    }
	    private static string FirstStandart(UncodedData RecDat)
	    {
	    	string Out="Block No "+RecDat.BlockNumber+", Record No "+RecDat.Number+":\n   Name: "+RecDat.Type+"\n   Time: "+RecDat.Time+" ms\n\n";
	        return Out;
	    }
	    private static string SecondStandart(UncodedData RecDat)
	    {
	        string Out="No"+RecDat.BlockNumber+"."+RecDat.Number+"/"+RecDat.Type+"/"+RecDat.Time+" ms\n\n";
	        return Out;
	    }
	    private static UncodedData Uncoder(int Num,double[,] UncodingData)
	    {
	    	UncodedData UD = new UncodedData();
	    	UD.BlockNumber=(int)UncodingData[Num,0];
	    	UD.Number=(int)UncodingData[Num,1];
			if((int)UncodingData[Num,2]==1)UD.Type="Opt";
	    	else
				if((int)UncodingData[Num,2]==2)UD.Type="Det";
	    		else
					if((int)UncodingData[Num,2]==3)UD.Type="Exp";
	    			else
	    				UD.Type="..Uncodable..";
	    	UD.Time=UncodingData[Num,3];
	    	return UD;
	    }
	    static void BRR1(int BlockNum,double[,] UncodingData,BlockResult BR1,BlockResult BR2)
	    {
	    	int SumRec = (int)BR1(BlockNum,UncodingData);
	    	double SumTime = BR2(BlockNum,UncodingData);
	    	string S="Block No: "+BlockNum+"\n   Total records: "+SumRec+"\n   Total time: "+SumTime+"ms\n\n";
	    	Console.WriteLine(S);	    		
	    }
	     static void BRR2(int BlockNum,double[,] UncodingData,Func<int,double[,],double> BR1,BlockResult BR2)
	    {
	    	int SumRec = (int)BR1(BlockNum,UncodingData);
	    	double SumTime = BR2(BlockNum,UncodingData);
	    	string S="Block No: "+BlockNum+"\n   Total records: "+SumRec+"\n   Total time: "+SumTime+"ms\n\n";
	    	Console.WriteLine(S);	    		
	    }
	}
}