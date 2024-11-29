using UnityEngine;

public class PipeGeneratorScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject pipe;
    public float gengrateRate = 3;
    private float timer = 0;
    private float hightOffset = 5;

    void Start()
    {
        GeneratePipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < gengrateRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            GeneratePipe();
            timer = 0;
        }
    }

    private void GeneratePipe() {

        float lowestPoint = transform.position.y - hightOffset;
        float highestPoint = transform.position.y + hightOffset;

        Instantiate(
            pipe,
            new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),transform.position.z),
            transform.rotation
            );
    }
}
