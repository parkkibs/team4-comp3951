using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script for the Nebula Wall obstacle spawner on the top of the screen.
/// @author Xavier Nguyen
/// @version 3.0
/// </summary>
public class nebularspawn : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float respawnTime; //Variable can be changed according to difficulty.


    // Start method calls the whole chain of methods.
    void Start()
    {
        StartCoroutine(obstacleWave());
    }
    //Instantiates the nebula obstacle.
    private void spawnObstacle()
    {
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
  
        a.transform.position = new Vector2(2040, Random.Range(960, 1200));
    }
    //Loops the spawning of the nebula wall.
    IEnumerator obstacleWave()
    {
        while (true)
        {
            respawnTime = Random.Range(8 / gamestate_manage.spawnfrequency, 15 / gamestate_manage.spawnfrequency);
            yield return new WaitForSeconds(respawnTime);
            spawnObstacle();
        }

    }
}
