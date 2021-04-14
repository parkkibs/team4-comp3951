using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script for the asteroid spawner.
/// @author Sam Merati
/// @version 4.0
/// </summary>


public class spawnasteroid : MonoBehaviour
{
    public GameObject obstaclePrefab;
    //Variable to set the frequency of the asteroid spawning.
    public float respawnTime = 1.0f;

    /// <summary>
    /// Method that starts the whole spawning process.
    /// </summary>
    void Start()
    {
        StartCoroutine(obstacleWave());
    }

    /// <summary>
    /// Creates an asteroid at a random height bound in the screen and out of bounds to the right of the screen.
    /// </summary>
    private void spawnObstacle()
    {
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        a.transform.position = new Vector2(1950, Random.Range(0,1080));
    }
    /// <summary>
    /// Loops the spawning method to keep spawning asteroids.
    /// </summary>
    /// <returns></returns>
    IEnumerator obstacleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnObstacle();
        }

    }
}
