using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicGameScene logic;
    public bool birdIsAlive = true;

    void Start()
    {
        //to get another GameObject from the scene depending on the tag we give it,
        //and get one component from it
        logic = GameObject.FindGameObjectWithTag("AddScore").GetComponent<LogicGameScene>();
    }

    void Update()
    {
    	if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        	myRigidbody.velocity = Vector2.up * flapStrength;
    }


    //if we touch another collider, this function will be used
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive)
        {
            logic.gameOver();
            birdIsAlive = false;
            //Sprite.sprite = "cloud";
        }
    }
}
