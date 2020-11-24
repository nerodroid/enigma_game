using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public void GetInput(string guess){
		//Debug.Log ("You entered " + guess);
		if(string.Equals(guess,"123")){
			Debug.Log ("level completed");
		}
		else{
			Debug.Log ("try again");
		}
	}
}
