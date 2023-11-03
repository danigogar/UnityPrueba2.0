using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderUp : MonoBehaviour
{

    public Move move;

    private void OnTriggerEnter2D(Collider2D other)
    {

        move.moveUp = false;
        Debug.Log("Up Enter");

        /*
        if (other.CompareTag("Pared"))
        {
        }
        */
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        move.moveUp = true;
        Debug.Log("Up Exit");
    }
}
