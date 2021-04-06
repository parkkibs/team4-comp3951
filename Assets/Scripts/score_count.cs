using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_count : MonoBehaviour
{
    public Text ScoreText;
    private float timer;
    private int score;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 2f)
        {
            score += 10;
            ScoreText.text = "Score: " + score.ToString();

            timer = 0;
        }
    }
}
