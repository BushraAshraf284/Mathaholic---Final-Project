﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemTubehangman : MonoBehaviour
{
    public int tubeId;  // identifier number for this tube

    /*// called when something enters the tube's collider
    public void OnTriggerEnter2D (Collider2D col)
    {
        // was it the player?
        if(col.CompareTag("Chain"))
        {
            // tell the game manager that the player entered this tube
            GameManager.instance.OnPlayerEnterTube(tubeId);
        }
    }*/

    public void onClick()
    {
        GameManagerhangman.instance.OnPlayerEnterTube(tubeId);
    }
}