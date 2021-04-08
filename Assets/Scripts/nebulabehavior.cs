using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script for the Nebula Wall obstacle prefab.
/// @author Xavier Nguyen
/// @version 3.0
/// </summary>
public class nebulabehavior : MonoBehaviour
{
    public float horizspeed = 400.0f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-horizspeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Method to destory the object once it goes out of screen on the left side.
        if (transform.position.x < -360)
        {
            Destroy(this.gameObject);
        }
    }
}
