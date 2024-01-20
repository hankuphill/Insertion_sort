using System;
using System.Linq;
using System.Collections.Generic;
using CSharpShellCore;



namespace SelectionSort;



public static class Program
{
	public static void Main()
	{
		Console.WriteLine("Sort test\n");

		Random rnd = new Random();
		int[] arr = new int[10];
		int n = 0;

		Console.WriteLine("random generated array: ");

		for (int ind = 0; ind < arr.Length; ++ind)
		{
			n = rnd.Next(0, 10);
			arr[ind] = n;

			Console.Write(arr[ind]);
		}
		Console.WriteLine();
		
		void MySwap(ref int first, ref int second)
		{
		    int temp = 0;
			
			temp = first;
			first = second;
			second = temp;
			
		}

		bool not_sorted = true;
		while(not_sorted)
		{	
		    not_sorted=false;
			
			for (int i=0;i<arr.Length;++i)
			{
			    if (i+1!=arr.Length)
				{
				    if ( arr[i]>arr[i+1])
					{
				    MySwap(ref arr[i], ref arr[i+1] );
					
					not_sorted=true;
					}
				}
				
			
			}
		}
		//result
				Console.WriteLine();
		foreach (int v in arr)
		{
			Console.Write(v);
		}
	}

}

