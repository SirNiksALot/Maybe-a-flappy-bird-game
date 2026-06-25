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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.add_score(scoreIncrement);
    }
}
