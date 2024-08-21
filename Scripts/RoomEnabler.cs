using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEnabler : MonoBehaviour
{
    public GameObject player;
    public Transform playerSpawnLocation;

    void Start()
    {
        playerSpawnLocation = playerSpawnLocation.GetComponent<Transform>();
        player.transform.position = playerSpawnLocation.position;
        GameMain.enemyCap = 10;

        if (GameMain.enemiesActive > 0)
        {
            GameMain.destroyActiveEnemies = true;
        }

        // set current room on the player as the prefab
    }
}
