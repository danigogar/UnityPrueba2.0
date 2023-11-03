using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderLeft : MonoBehaviour
{
    public Move move;

    private void OnTriggerEnter2D(Collider2D other)
    {
        move.moveLeft = false;
        Debug.Log("Left Enter");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        move.moveLeft = true;
        Debug.Log("Left Exit");
    }
}
