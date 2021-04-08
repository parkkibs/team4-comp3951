using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script for the asteroid obstacle prefab.
/// @author Sam Merati
/// @version 4.0
/// </summary>
public class obstaclebehavior : MonoBehaviour
{
    public float vertspeed;
    public float horizspeed;
    public Rigidbody2D rb;
    
    //Contains random sprites of asteroids to vary obstacle size and appearance.
    [SerializeField] public Sprite[] spriteArray;

    // Attaches RigidBody to the Asteroid, providing collision.
    // Set the boundaries for the obstacle in relation to the camera, setting up spawning and despawning behavior.
    void Start()
    {
        int randint = Random.Range(0, 5);
        this.GetComponent<SpriteRenderer>().sprite = spriteArray[randint];
        vertspeed = Random.Range(0, 250);
        horizspeed = Random.Range(200, 400);
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-horizspeed, vertspeed);
       
    }

    // Checks if it's out of bounds to the left of the camera and despawns when it reaches the end.
    void Update()
    {
        if(transform.position.x < -360)
        {
            Destroy(this.gameObject);
        }
    }

}
