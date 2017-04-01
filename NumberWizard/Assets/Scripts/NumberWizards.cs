using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour 
{
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () 
	{
		StartGame();
	}

	void StartGame()
	{
		max = 1000;
		min = 1;
		guess = 500;

		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a Number in Your Head, but Don't Tell Me!");
		
		print ("The Highest Number You Can Pick is " + max);
		print ("The Lowest Number You Can Pick is " + min);

		max = max + 1;
		
		print ("Is the Number Higher or Lower Than " + guess + "?");
		print ("Up Arrow for Higher, Down Arrow for Lower, Return for Equal");
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			//print ("Up Arrow Pressed");
			min = guess;
			NextGuess();
		} 
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			//print ("Down Arrow Pressed");
			max = guess;
			NextGuess();
		} 
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			print ("I won!");
			StartGame();
		}
	}

	void NextGuess()
	{
		guess = (max+min) / 2;
		print ("Is the Number Higher or Lower Than " + guess + "?");
		print ("Up Arrow for Higher, Down Arrow for Lower, Return for Equal");
	}

}
