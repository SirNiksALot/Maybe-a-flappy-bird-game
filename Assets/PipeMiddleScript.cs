using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public int scoreIncrement = 1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        if (logic)
        {
            Debug.Log("LogicScript Object found !");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Debug.Log("Pipe Avoided ! Yay !");
            logic.add_score(scoreIncrement);

        }
    }
}
