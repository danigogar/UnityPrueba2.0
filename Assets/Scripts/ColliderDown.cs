using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDown : MonoBehaviour
{
    public Move move;

    private void OnTriggerEnter2D(Collider2D other)
    {
        move.moveDown = false;
        Debug.Log("Down Enter");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        move.moveDown = true;
        Debug.Log("Down Exit");
    }
}
