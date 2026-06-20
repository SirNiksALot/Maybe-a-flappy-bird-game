using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate  = 2; // seconds between spawns 
    private float timer = 0; // to maintain an internal clock to help with spawning
    public float heightOffset = 10;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer +  Time.deltaTime; // increment clock
        }
        else
        {
            spawnPipe();
            timer = 0; //reset clock
        }

        
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Vector3 newRandomSpawnPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0 );

        Instantiate(pipe, newRandomSpawnPosition , transform.rotation);
    }
}
