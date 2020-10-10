using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDetection : MonoBehaviour
{

    public bool showGui;
    // Start is called before the first frame update
    
    private Inventory inventory;
    


   
    void OnTriggerEnter(Collider col)
     {
        if(col.gameObject.tag == "Item")showGui = true;
        




     }
     
     void OnTriggerExit(Collider col)
     {
        if(col.gameObject.tag == "Item")showGui = false;
     }
     
     void OnGUI()
     {
        if(showGui)GUI.Box(new Rect(0,0,100,100),"Press E to Oick up " );
     }
     void Update()
     {
        if(showGui && Input.GetKeyDown(KeyCode.E))
        {
            //Do some stuffs like health
            Destroy(gameObject); //Remove the item
        }
     }






}
