using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LR3
{
	class Program
	{
	    public static void Main(string[] args)
	    {	    	
	        string P =" ";
	        int Mo = 0;
	        int[] FixedModes =new int[10];
	        NumItem NItem = new NumItem();
	        Word[] W = new Word[10];
	        Code[] C = new Code[10];
	        Mixed[] M = new Mixed[10];
	        Number[] N = new Number[10];
	        SetWordCodeMixed SWCMc = new SetWordCodeMixed();
	        List<NumItem> ItemList = new List<NumItem>();
	        
	        
	        for (int i=0; i< 4; i++)
	        {
	        	Mo = SWCMc.TypeChoser(Mo);
	        	P=SWCMc.SWCM(Mo,P);
	        	switch(Mo)
	        	{
	        			case 1: {W[i] = new Word(i+1,P);ItemList.Add(W[i]); break;};
	        			case 2: {C[i] = new Code(i+1,P);ItemList.Add(C[i]); break;};
	        			case 3: {M[i] = new Mixed(i+1,P);ItemList.Add(M[i]); break;};
	        			case 4: {N[i] = new Number(i+1);ItemList.Add(N[i]); break;};
	           	}
	        	FixedModes[i]=Mo;
	        }
	        Console.WriteLine("\n\nНажмите любую кнопку для продолжения.");
	        Console.ReadKey(true);
	        Console.Clear();
	        NongenericList NL = new NongenericList(ItemList);
	        SimpleStack ST = new SimpleStack(ItemList);
	        Dictionary Dt = new Dictionary(ItemList);
	        SparseMatrixFiller SMF = new SparseMatrixFiller(ItemList,FixedModes);
	        SortByLength SBL = new SortByLength(ItemList);
	        
	        Console.ReadKey(true);
	    }
	}
}


