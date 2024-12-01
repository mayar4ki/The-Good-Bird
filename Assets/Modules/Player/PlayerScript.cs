using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D birdRigidbody2D;
    public float jumpStringth=12;
    public bool isAlive = true; 

    private GameLogic gameLogic;
    private readonly Dictionary<string, int> yLifeZone = new Dictionary<string, int>
    {
     { "lowerBound", -19 },
     { "upperBound", 12 }
    };




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag(Tags.GameLogic).GetComponent<GameLogic>();
    }


    private void killObject()
    {
        if (!isAlive) return;

        gameLogic.showGameOver();
        isAlive = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            birdRigidbody2D.linearVelocity = Vector2.up * jumpStringth;
        }

        float y = transform.position.y;

        if (y <= yLifeZone["lowerBound"] || y >= yLifeZone["upperBound"])
        {
            killObject();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       killObject();
    }


}
