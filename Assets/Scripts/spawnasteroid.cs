using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Script to spawn Right-to-Left Asteroids


public class spawnasteroid : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float respawnTime = 1.0f;
    //private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(obstacleWave());//screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    private void spawnObstacle()
    {
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        //a.transform.position = new Vector2(screenBounds.x *-2, Random.Range(-screenBounds.y, screenBounds.y));
        a.transform.position = new Vector2(1950, Random.Range(0,1080));
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
