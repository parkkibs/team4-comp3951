using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Script for a very basic scoring system based on time passed.
/// @author Kibum Park
/// @version 1.0
/// </summary>
public class score_count : MonoBehaviour
{
    //Text that holds the score counter.
    public Text ScoreText;
    private float timer;
    private int score;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //Every 2 seconds, the score goes up by 10.
        if(timer > 2f)
        {
            score += 10;
            //Update the score counter's text.
            ScoreText.text = "Score: " + score.ToString();

            timer = 0;
        }
    }
}
