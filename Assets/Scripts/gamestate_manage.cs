using UnityEngine;
using UnityEngine.SceneManagement;

public class gamestate_manage : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 5f;
    // Start is called before the first frame update
    public void endGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
