using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Same script as nebularspawn except it applies for the bottom nebula spawner.
/// @author Xavier Nguyen
/// </summary>
public class nebulaspawnbtm : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float respawnTime;

    void Start()
    {
        StartCoroutine(obstacleWave());
    }
    private void spawnObstacle()
    {
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        a.transform.position = new Vector2(2040, Random.Range(-120, 120));
    }
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
