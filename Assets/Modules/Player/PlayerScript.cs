using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D birdRigidbody2D;
    public float jumpStringth=12;
    public bool isAlive = true; 
    private GameLogic gameLogic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag(Tags.GameLogic).GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            birdRigidbody2D.linearVelocity = Vector2.up * jumpStringth;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameLogic.showGameOver();
        isAlive = false;
    }
}
