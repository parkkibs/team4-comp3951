using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class difficultytextdisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textbox;
    [SerializeField] TextMeshProUGUI textbox2;
    [SerializeField] TextMeshProUGUI textbox3;
    [SerializeField] TextMeshProUGUI textbox4;

    public float playerspeed = gamestate_manage.playerspeed * 100;
    public float obstaclespeed = gamestate_manage.obstaclespeed * 100;
    public float spawnfreq = gamestate_manage.spawnfrequency * 100;
    public int lives = gamestate_manage.lives;
    // Start is called before the first frame update

    void Start()
    {
        textbox.text = "Player Speed: " + playerspeed.ToString() + "%";
        textbox2.text = "Obstacle Speed: " + obstaclespeed.ToString() + "%";
        textbox3.text = "Obstacle Spawn Frequency: " + spawnfreq.ToString() + "%";
        textbox4.text = "Lives: " + lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Player Speed: " + playerspeed.ToString() + "%";
        textbox2.text = "Obstacle Speed: " + obstaclespeed.ToString() + "%";
        textbox3.text = "Obstacle Spawn Frequency: " + spawnfreq.ToString() + "%";
        textbox4.text = "Lives: " + lives.ToString();
    }
}
