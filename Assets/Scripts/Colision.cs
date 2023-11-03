using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
  

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Trigger Enter");

        
        if (other.CompareTag("Pared")) {

            Debug.Log("Pared Enter");

        }
        
    }


    /*
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Enter");
    }
    */
}
