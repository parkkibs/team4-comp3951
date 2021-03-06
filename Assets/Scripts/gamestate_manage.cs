using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Master script that controls most scene transitions and the maintenance of static data for the difficulties.
/// @author Kibum Park
/// @version 2.0
/// </summary>
public class gamestate_manage : MonoBehaviour
{   
    /// <summary>
    /// bool variable to prevent game over function from looping
    /// </summary>
    bool gameHasEnded = false;
    /// <summary>
    /// Wait time after death before game is restarted.
    /// </summary>
    public float restartDelay = 5f;
    // Start is called before the first frame update
    /// <summary>
    /// These four static variables adjust the difficulty of the game based on what was selected in the difficulties menu.
    /// </summary>
    public static float obstaclespeed = 1;
    public static int lives = 3;
    public static float spawnfrequency = 1;
    public static float playerspeed = 1;

    /// <summary>
    /// Function for ending the game after healthsystem triggers takeDamage when lives are at 1.
    /// </summary>

    public void endGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("gameOver", restartDelay);
        }
    }

    void gameOver()
    {
        SceneManager.LoadScene("gameOver_screen");
    }
}