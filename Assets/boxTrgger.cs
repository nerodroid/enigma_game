using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxTrgger : MonoBehaviour
{

    public GameObject passMenuUI;
     void OnTriggerEnter()
    {
       //Destroy(gameObject);
        Debug.Log("entered");

        passMenuUI.SetActive(true);
        //Time.timeScale=0;
        //Cursor.lockState = CursorLockMode.None;
        //isPaused= true;
    }







}
