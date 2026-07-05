using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength = 20;
    public LogicScript logic;
    bool birdIsAlive = true;
    public GameObject bird;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        if (logic)
        {
            Debug.Log("LogicScript Object found by BirdScript!");

        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength; // shorthand for Vector (0,1) 
        }
      
        if(myRigidbody.position.y < -20)
        {
            Debug.Log("Bird Deleted");
            Destroy(bird); // deadzone for bird when falling down after game over
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected !");
        logic.gameOver();
        birdIsAlive = false;
        //logic.restartGame();
    }
}
