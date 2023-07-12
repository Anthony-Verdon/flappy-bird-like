using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -10;

    void Update()
    {
        //the variable "Time.deltaTime" is the time between this frame and the precedente one.
        //It avoid to make the pipe move faster or slower depending on the frame rate of the game (which depend of the computer)
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            //destroy the gameObject ( = delete)
            Destroy(gameObject);
        }
    }
}
