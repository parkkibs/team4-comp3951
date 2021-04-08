using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script for player movement.
/// @author Kibum Park
/// @version 2.0
/// </summary>
public class playermovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;


    // Update is called once per frame
    void Update()
    {
        //Method to keep track of any inputs the player makes every frame.
        ProcessInputs();
    }

    void FixedUpdate()
    {
        //Physics Calculations
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        //This method makes sure when both horizontal and vertical movement is pressed, the combined vector speed is the same
        //as if only the vertical or only the horizontal is pressed.
        moveDirection = new Vector2(moveX, moveY).normalized;

    }

    void Move()
    {
        //Sets the actual velocity of the player object after Update() and FixedUpdate().
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
