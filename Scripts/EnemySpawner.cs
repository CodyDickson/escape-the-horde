using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    bool isAlive = true;
    public GameObject enemy;
    public Transform spawnLocation;
    float timer = 0f;

    void Start()
    {
        spawnLocation = spawnLocation.GetComponent<Transform>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (isAlive && timer > 2f && (GameMain.enemiesActive < GameMain.enemyCap))
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemy, spawnLocation.position, Quaternion.identity);
        GameMain.enemiesActive += 1;
    }
}
