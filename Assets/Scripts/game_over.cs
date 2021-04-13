using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Script for the main menu
/// @author Sam Merati
/// @version 2.0
/// </summary>
public class game_over : MonoBehaviour
{
    /// <summary>
    /// Method for the New Game Button, redirects to the first level scene.
    /// </summary>
    public void restart_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    /// <summary>
    /// Method for the Quit Game Button, closes the application.
    /// </summary>
    public void quit_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}