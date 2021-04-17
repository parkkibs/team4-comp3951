using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script for the Enemy ship.
/// @author Xavier Nguyen   
/// @version 3.0
/// </summary>
/// 
public class enemyship : MonoBehaviour
{
    /// <summary>
    /// speed is how fast the ship is moving.
    /// stoppingDistance is the distance between the player and ship that triggers retreating and approaching. 
    /// retreatDistance is the maximum distance the ship retreats from the player.
    /// </summary>
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    private Transform player;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject bullet;

    // Start is called before the first frame update
    /// <summary>
    /// When the ship is spawned, it searches for a player object and sets that as the anchoring point.
    /// </summary>
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    /// <summary>
    /// The ship checks the distance between it and the player and whether it is ready to shoot.
    /// </summary>
    void Update()
    {
        //Approaches the player if the distance between the ship and player is too big.
        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        //Maintains the distance between the player and the ship.
        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance
          && Vector2.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        //If the player gets too close to the ship, move away from the player.
        else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
        //Triggers the bullet firing if the timer expires, and resets the timer.
        if (timeBtwShots <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        //Ticks down the timer between shots.
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
