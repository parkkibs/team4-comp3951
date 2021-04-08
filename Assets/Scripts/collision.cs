using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script for the collision mechanics between player and obstacles
/// @author Xavier Nguyen
/// @version 1.0
/// </summary>
public class collision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit Detected");
        this.GetComponent<healthsystem>().takeDamage(1); //Refers to takeDamage() function in healthsystem script
    }
}
