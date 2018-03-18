using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

	int min;
	int max;
	int guess;
			
	// Use this for initialization
	//only happens once
	void Start () {

		StartGame();

		//fyi, ctrl-apostrophe will take you info for Unity commands
		//it often has useful examples of code to get you started

	}

	//your first function in Unity!
	//in earlier lessons, you wrote a bunch of it in Start()
	//then moved it here.

	void StartGame ()
	{
		min = 1;
		max = 1000;
		guess = 500;

		//we did that to avoid the problem of hitting 999 but never hitting 1000

		print("==========================================");
		print ("Welcome to Number Wizard!");
		print ("This is my first mini-challenge. I'm printing a line all by myself.");
		print ("Now pick a number but don't tell me.");

				//print ($"Actually, make it between {min} and {max}.");
		//fyi, MonoDevelop supposedly supports .net 4.5 and c# 6.0 (which allow interpolation)
		//but Unity apparently doesn't. ??? it says it stops at c# 4.0. ???
		//it's possible I didn't update MonoDevelop properly, but people on the web are complaining about this.
		print("Make it between " + min + " and " + max);

		max = max+1;

		print("Is the number higher or lower than " + guess + " ?");
		print("Hit up arrow for higher, down arrow for lower, return for equal");

	}

	//your second function
	//was previously in Update()

	void NextGuess ()
	{
		guess = (min + max)/2;
		print ("Is your number higher, lower or equal to " + guess + " ?");
	}
		
	// Update is called once per frame
	//this is the part of the program that looks for stuff while it's running
	//it seems like some sort of loop... it just keeps checking to see if something happened
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up arrow was pressed");
			min = guess;
			//guess = (min + max)/2;
			//print ("Is your number higher, lower or equal to " + guess + " ?");
			NextGuess();
		}
		//tip: Unity documentation on the web has info about key presses and their associated words

		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down arrow was pressed");
			max = guess;
			//guess = (min + max)/2;
			//print ("Is your number higher, lower or equal to " + guess + " ?");
			NextGuess();
		}
		//don't get confused about the key's ACTION (pressed vs released, aka down vs up)
		//and what key is being pressed (down arrow vs up arrow)

		else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Return key was pressed.");
			print ("Your number is " + guess + " ! Fun game.");
			//and to play it again:
			StartGame();

		} 

		//experimenting with code:

		else if (Input.GetKeyDown ("a")) {
			print ("You pressed a!");
		} 
		else if (Input.GetKeyDown (KeyCode.S)) {
			print ("You pressed s!");	
		} 

		//	else {
		//		print ("wut");
		//	}

		//you commented that out because it was an infinite loop
		//remember, Update keeps checking, so when nothing keeps happening... lol
	}
}