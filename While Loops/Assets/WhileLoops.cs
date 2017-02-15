using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour {

int i = 0;
public string[] colors;
//add brackets to make something an array. in unity, it will show you the option to add elements to the array
//all containers of data in programming languages START WITH 0, NOT 1. A five item list goes 0,1,2,3,4 instead of 1,2,3,4,5

	// Use this for initialization
	void Start () {
		while (i < colors.Length)
		{
			print(colors[i]); //the program will print the number, represented by i
			i++;//after it prints i, it will add another number, and another, until it gets up to 10, which is stated above
			//it all appears at once, rather than counting and loading slowly
		}
		print ("Done");
	}
}