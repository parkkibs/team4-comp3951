using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script that allows background images to scroll infinitely, allowing for the illusion of movement
/// @author Kibum Park
/// @version 1.0
/// </summary>
public class backgroundscroll : MonoBehaviour
{

    public float speed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
