using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Script for the difficulties settings menu
/// @author Kibum Park
/// @version 1.0
/// </summary>
public class difficulties : MonoBehaviour
{
    public void go_back() //Currently bugged, does not appear on the menu inspector
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    /// <summary>
    /// Sets the speed of the obstacles by changing the static variable in gamestate_manage
    /// </summary>
    /// <param name="setting">Selected via pressing one of the buttons</param>
    public void setPlayerSpeed(int setting)
    {
        
    }
    /// <summary>
    /// Sets the speed of the obstacles by changing the static variable in gamestate_manage
    /// </summary>
    /// <param name="setting">Selected via pressing one of the buttons</param>
    public void setObstacleSpeed(int setting)
    {
        
    }
    /// <summary>
    /// Sets the speed of the obstacles by changing the static variable in gamestate_manage
    /// </summary>
    /// <param name="setting">Selected via pressing one of the buttons</param>
    public void setObstacleSpawn()
    {

    }
    /// <summary>
    /// Sets the speed of the obstacles by changing the static variable in gamestate_manage
    /// </summary>
    /// <param name="setting">Selected via pressing one of the buttons</param>
    public void setLives()
    {

    }

}
