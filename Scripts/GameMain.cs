using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMain : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] public static int playerHealth = 5;
    [SerializeField] public static int playerAmmo = 10;
    public GameObject devRoom;
    public GameObject player;
    public static bool destroyActiveEnemies = false;
    public static bool pulseActive = false;
    public static bool dashActive = false;
    public static int criticalShot = 0;
    public static int enemiesActive = 0;
    public static int enemyCap;
    public static int playerPoints = 0;
    public static int multiplier = 1;
    public static int playerKillStreak = 0;
    public static int playerLives = 1;
    public static int playerAmmoCapacity = 25;
    public static int playerPulseCapacity = 1;
    public static int bulletCount = 1;
    public static bool piercingBullets;

    void Start()
    {
        devRoom.SetActive(true);
        player.SetActive(true);
    }

    void Update()
    {

    }

    public static void Randomizer()
    {
        int random = Random.Range(1,5);
        if (random == 1 && !piercingBullets)
        {
            Debug.Log("Piercing Shot");
            piercingBullets = true;
        }
        else if (random == 2 && bulletCount > 5)
        {
            Debug.Log("Multi Shot");
            bulletCount += 1;
        }
        else if (random == 3 && !pulseActive)
        {
            Debug.Log("Pulse");
            pulseActive = true;
        }
        else if (random == 4 && criticalShot < 75)
        {
            Debug.Log("Critical Shot");
            criticalShot += 25;
        }
        else if (random == 5 && !dashActive)
        {
            Debug.Log("Dash");
            dashActive = true;
        }
        else
        {
            Debug.Log("Randomizer Failed");
        }
    }

    public static void Booster()
    {
        int random = Random.Range(1,5);
        // Increase health
        // Increase movement speed
        // Increase weapon damage
        // extra life
    }

    public static void SpawnPhaser()
    {
        // 75% size
        // 50% opaque
        // slow moving
    }

    public static void SpawnVessel()
    {
        // 150% size
        // slow moving
        // occasionally spawns imps
    }

    public static void SpawnImp()
    {
        // 100% size
        // fast moving
        // low health
    }

    public static void MultiplierIncrease()
    {
        multiplier += 1;
        Debug.Log("Multiplier has increased to " + multiplier + "!");
        // increase background activity
    }

    public static void MultiplierReset()
    {
        multiplier = 1;
        Debug.Log("Multiplier has been reset!");
    }
}