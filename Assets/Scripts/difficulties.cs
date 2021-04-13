using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
/// <summary>
/// Script for the difficulties settings menu
/// @author Kibum Park
/// @version 1.0
/// </summary>
public class difficulties : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textbox;
    [SerializeField] TextMeshProUGUI textbox2;
    [SerializeField] TextMeshProUGUI textbox3;
    [SerializeField] TextMeshProUGUI textbox4;

    public float playerspeed = gamestate_manage.playerspeed * 100;
    public float obstaclespeed = gamestate_manage.obstaclespeed * 100;
    public int spawnfreq = (int) (1 / gamestate_manage.spawnfrequency) * 100;
    public int lives = gamestate_manage.lives;

    public void go_back() //Currently bugged, does not appear on the menu inspector
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    /// <summary>
    /// Sets the speed of the obstacles by changing the static variable in gamestate_manage
    /// </summary>
    /// <param name="setting">Selected via pressing one of the buttons</param>
    public void setPlayerSpeed(float setting)
    {
        gamestate_manage.playerspeed = setting;
        playerspeed = gamestate_manage.playerspeed * 100;
        updateText();
        Debug.Log(gamestate_manage.playerspeed);
    }
    /// <summary>
    /// Sets the speed of the obstacles by changing the static variable in gamestate_manage
    /// </summary>
    /// <param name="setting">Selected via pressing one of the buttons</param>
    public void setObstacleSpeed(float setting)
    {
        gamestate_manage.obstaclespeed = setting;
        obstaclespeed = gamestate_manage.obstaclespeed * 100;
        updateText();
    }
    /// <summary>
    /// Sets the speed of the obstacles by changing the static variable in gamestate_manage
    /// </summary>
    /// <param name="setting">Selected via pressing one of the buttons</param>
    public void setObstacleSpawn(float setting)
    {
        gamestate_manage.spawnfrequency = setting;
        spawnfreq = (int) (100 / gamestate_manage.spawnfrequency);
        updateText();
    }
    /// <summary>
    /// Sets the speed of the obstacles by changing the static variable in gamestate_manage
    /// </summary>
    /// <param name="setting">Selected via pressing one of the buttons</param>
    public void setLives(int setting)
    {
        gamestate_manage.lives = setting;
        lives = gamestate_manage.lives;
        updateText();
    }

    public void updateText()
    {
        textbox.text = "Player Speed: " + playerspeed.ToString() + "%";
        textbox2.text = "Obstacle Speed: " + obstaclespeed.ToString() + "%";
        textbox3.text = "Obstacle Spawn Frequency: " + spawnfreq.ToString() + "%";
        textbox4.text = "Lives: " + lives.ToString();
    }
}
