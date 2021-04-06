using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addstaticobstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float respawnTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(obstacleWave());
    }
    private void spawnObstacle()
    {
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        a.transform.position = new Vector2(9, Random.Range(-5, 5));
    }
    // Update is called once per frame
    IEnumerator obstacleWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnObstacle();
        }
        
    }
}
