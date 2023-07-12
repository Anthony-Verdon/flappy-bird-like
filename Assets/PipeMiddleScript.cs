using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public LogicGameScene logic;


    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("AddScore").GetComponent<LogicGameScene>();       
    }

    //if we touch the collider with the checkbox "trigger" activated, it will active this function
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
    }
}
