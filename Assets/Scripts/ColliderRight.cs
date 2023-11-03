using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderRight : MonoBehaviour
{
    public Move move;

    private void OnTriggerEnter2D(Collider2D other)
    {
        move.moveRight = false;
        Debug.Log("Right Enter");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        move.moveRight = true;
        Debug.Log("Right Exit");
    }
}
