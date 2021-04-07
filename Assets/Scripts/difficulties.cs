using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class difficulties : MonoBehaviour
{
    public void go_back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void setPlayerSpeed(int setting)
    {
        
    }

    public void setObstacleSpeed()
    {
        Application.Quit();
    }

    public void setObstacleSpawn()
    {

    }

    public void setLives()
    {

    }

}
