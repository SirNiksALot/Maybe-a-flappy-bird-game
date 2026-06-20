using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 5;
    public float deadZone = -45; // we set this zone as we wish 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x  < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject); // destroy the game object if this pipe game object has moved off screen 
        }
        transform.position = transform.position + ( Vector3.left * moveSpeed ) * Time.deltaTime; // to keep the position change independant of frame rate 
        
    }
}
