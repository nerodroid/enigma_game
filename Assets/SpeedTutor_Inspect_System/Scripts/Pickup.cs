using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    private  Inventory inventory;


    private void Start(){

        inventory = GameObject.FindGameObjectWithTag("Player")
        .GetComponent<Inventory>();
        

    }

    void OnTriggerEnter2D(Collider2D other){

        Debug.Log(this.gameObject.name);
        if (other.CompareTag("Player")){

            inventory.inItems.Add(this.gameObject);
            
        }

    }


}
