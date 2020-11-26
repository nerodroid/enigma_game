using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guessAnswer : MonoBehaviour
{
    //public static bool GameIsPaused = false;
    public GameObject guessKeyUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            guessKeyUI.SetActive(true);
			//Time.timeScale = 1f;		
        }
		if(Input.GetKeyDown(KeyCode.E))
        {
            guessKeyUI.SetActive(false);
			//Time.timeScale = 1f;		
        }
    }
}
