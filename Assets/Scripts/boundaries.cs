using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script for setting player boundaries to prevent the player object from disappearing off the screen
/// @author Sam Merati
/// @version 3.0
/// </summary>
public class boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    // Start is called before the first frame update
    void Start()
    {
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, objectWidth, 1920 - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, objectHeight, 1080 - objectHeight);
        transform.position = viewPos;
    }
}
