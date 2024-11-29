using UnityEngine;

public class PipeScipt : MonoBehaviour
{

    public float moveSpeed = 8;
    public float deleteAtX = -45;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if(transform.position.x < deleteAtX)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
