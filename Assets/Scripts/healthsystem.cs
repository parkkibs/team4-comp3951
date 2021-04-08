using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script for controlling the player's lives.
/// @author Kibum Park
/// @version 2.0
/// </summary>
public class healthsystem : MonoBehaviour
{
    /// <summary>
    /// Array that stores the lives and the images depicting the lives.
    /// </summary>
    public GameObject[] health;
    private int life;
    private bool dead;
    public Sprite deadSprite;
    SpriteRenderer sprite;

    private void Start()
    {
        life = health.Length;
        sprite = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        if(dead)
        {
            //Visual update of the player to show that they died, will consider switching to something else.
            Debug.Log("Player is Dead.");
            sprite.sprite = deadSprite;
            dead = false;
        }
    }
    //Method for registering life loss and death.
    public void takeDamage(int d)
    {
        if(life >= 1)
        {
            life -= d;
            Destroy(health[life].gameObject);
            if (life < 1)
            {
                dead = true;
                //Calls the restart method after death.
                FindObjectOfType<gamestate_manage>().endGame();
            }
        }        
    }
}
