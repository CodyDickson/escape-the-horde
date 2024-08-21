using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitRandomizer : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("Randomizer Activated");
            GameMain.Randomizer();
        }        
    }
}
