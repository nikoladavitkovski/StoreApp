using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

public class ArrayStrings
{
	public ArrayStrings(string[] array,string[] array1)
	{
		this.array = array;
		this.array1 = array1;
		if(array1 in array){
			Console.WriteLine(array1[0]);
		}
	}
	string[] array = [];
	
	string[] array1 = [];
}
