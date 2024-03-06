// add score manager
using UnityEngine;
using UnityEngine.UI;

// access the Text Mesh Pro namespace
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public int maxScore = 5;

    public TMP_Text message;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    //we will call this method from our target script
    // whenever the player collides or shoots a target a point will be added
    public void AddPoint()
    {
        score++;

        if (score > maxScore - 1)
            scoreText.text = "Hurray! You have collected enough parts to build a PC!";
        else
            scoreText.text = "Score: " + score;
    }
    public void DecementPoint()
    {
        if (score > 0)
            score--;
            scoreText.text = "Score: " + score;
    }

    public void AddMessage(string str)
    {
        message.text = "+ "+ str ;
    }
}