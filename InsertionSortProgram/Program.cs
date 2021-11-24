using System;
using System.Collections;
using System.Collections.Generic;

class GFG
{
	public static void Main()
	{

		ArrayList myList = new ArrayList();

		myList.Add("My");
		myList.Add("name");
		myList.Add("Ibrahim");

		Console.WriteLine("The initial ArrayList is : ");
		foreach (string str in myList)
		{
			Console.WriteLine(str);
		}

		myList.Insert(2, "is");
		myList.Insert(4, "and");
		myList.Insert(5, "I like");
		myList.Insert(6, "C#");

		Console.WriteLine("The ArrayList after Inserting elements is : ");

		foreach (string str in myList)
		{
			Console.WriteLine(str);
		}
	}
}