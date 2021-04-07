using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nebularspawn : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float respawnTime;

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
        a.transform.position = new Vector2(2040, Random.Range(-120, 120));
    }
    // Update is called once per frame
    IEnumerator obstacleWave()
    {
        while (true)
        {
            respawnTime = Random.Range(8, 15);
            yield return new WaitForSeconds(respawnTime);
            spawnObstacle();
        }

    }
}
