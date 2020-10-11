using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popup : MonoBehaviour
{
    public string theCode;
    public GameObject inputField;
    public GameObject textDisplay;

    public void storeCode()
    {
        theCode = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "lll" +theCode;
    }
}
