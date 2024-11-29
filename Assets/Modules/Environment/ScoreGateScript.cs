using System;
using UnityEngine;

public class ScoreGateScript : MonoBehaviour
{

    public GameLogic gameLogic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag(Tags.GameLogic).GetComponent<GameLogic>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == Tags.Player)
        {
        
            gameLogic.addScore(1);
        }
    }
}
