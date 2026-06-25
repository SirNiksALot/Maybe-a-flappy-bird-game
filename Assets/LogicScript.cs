using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;


    [ContextMenu("Increase Score")] // this lets this function be accessible via the unity hub UI's context menu . ( HOW does this thing work , what is this syntax even ?? ) 
    public void add_score(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
}
