using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject successUI;
	
	public void GetInput(string guess){
		//Debug.Log ("You entered " + guess);
		if(string.Equals(guess,"25487")){
			Debug.Log ("level completed");
			//successUI.SetActive(true);
		}
		else{
			Debug.Log ("try again");
			//guessKeyUI.SetActive(true);
		}
	}
}
