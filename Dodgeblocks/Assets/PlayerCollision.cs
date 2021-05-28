using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerControls movement;
    void OnCollisionEnter2D()
    {
        Debug.Log("We've been hit!");
        movement.enabled = false;
        FindObjectOfType<GameManager>().EndGame();
    }

}
