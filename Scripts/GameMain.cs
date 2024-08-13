using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour
{
    public GameObject devRoom;
    public GameObject player;
    public static bool destroyActiveEnemies = false;
    public static int enemiesActive = 0;
    public static int enemyCap;

    void Start()
    {
        devRoom.SetActive(true);
        player.SetActive(true);
    }

    void Update()
    {
    }
}
