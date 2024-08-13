using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Power Up");

        // Randomly select a power up

        // Start the timer until the next power up spawns
    }

    void ExtraLife()
    {
    }

    void OneDamage()
    {
        // one damage to all enemies
    }

    void Invulnerable()
    {
        //
    }

    void BonusPoints()
    {
        //
    }

    void DoubleSpeed()
    {

    }

}
