using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthsystem : MonoBehaviour
{
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
            Debug.Log("Player is Dead.");
            sprite.sprite = deadSprite;
            dead = false;
        }
    }

    public void takeDamage(int d)
    {
        if(life >= 1)
        {
            life -= d;
            Destroy(health[life].gameObject);
            if (life < 1)
            {
                dead = true;
                FindObjectOfType<gamestate_manage>().endGame();
            }
        }        
    }
}
