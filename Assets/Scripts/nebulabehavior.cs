using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (transform.position.x < -360)
        {
            Destroy(this.gameObject);
        }
    }
}
