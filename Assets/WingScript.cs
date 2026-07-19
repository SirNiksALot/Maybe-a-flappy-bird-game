using UnityEditor.Search;
using UnityEngine;

public class WingScript : MonoBehaviour
{
    public GameObject bird;
    public Rigidbody2D rb;
    public Sprite wingUp;
    public Sprite wingDown;
    public GameObject Wing;
    public SpriteRenderer sr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = bird.GetComponent<Rigidbody2D>();
        if (rb)
        {
            Debug.Log("Found Bird Body's rigid body !");
        }

        sr = Wing.GetComponent<SpriteRenderer>();
        if (!sr)
        {
            Debug.Log("Did not find sprite renderer");
        }
        else
        {
            Debug.Log("Found sprite renderer!");
        }

    }

    // Update is called once per frame
    void Update()
    {

        
        if (rb.linearVelocity.y < 0)
        {

            //Debug.Log("rb.linearVelocity.y < 0 ");
            sr.sprite = wingUp; //Show wing up
        }
        else
        {
            //Debug.Log("rb.linearVelocity.y >= 0 ");
            sr.sprite = wingDown; //Show wing down
        }

    }
}
