using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int enemyHealth = 3;
    bool isAlive = true;
    public GameObject player;
    public Transform target;
    [SerializeField] public float speed = 1f;
    public GameObject bullet;
    SpriteRenderer spriteRenderer;
    [SerializeField] Color32 threeHealth = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 twoHealth = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 oneHealth = new Color32 (1, 1, 1, 1);

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = threeHealth;
        player = GameObject.FindWithTag("Player");
        target = player.GetComponent<Transform>();
    }

    void Update()
    {
        if (isAlive)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        if (GameMain.enemiesActive > 0 && GameMain.destroyActiveEnemies)
        {
            GameMain.enemiesActive -= 1;
            if (GameMain.enemiesActive == 0)
            {
                GameMain.destroyActiveEnemies = false;
            }
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Hit by " + col.gameObject.name);
        if (col.gameObject.name == "Bullet")
        {
            enemyHealth -= 1;
            Player.playerKillStreak += 1;

            if (enemyHealth == 2)
            {
                spriteRenderer.color = twoHealth;
            }
            else if (enemyHealth == 1)
            {
                spriteRenderer.color = oneHealth;
            }
            else if (enemyHealth < 1)
            {
                Destroy(this.gameObject);
                Player.playerPoints += (10 * Player.multiplier);
                Debug.Log("Player Points: " + Player.playerPoints);
                GameMain.enemiesActive -= 1;
            }

            if (Player.playerKillStreak == 10)
            {
                Player.playerKillStreak = 0;
                Player.multiplier += 1;
                Debug.Log("Multiplier: " + Player.multiplier + "x");
            }
        }
        else if (col.gameObject.name == "Player")
        {
            Player.playerHealth -= 1;
            Player.multiplier = 1;

            // Add small kickback to enemy
        }
        else if (col.gameObject.name == "Wall")
        {
            // Add a small kickback from the wall
        }
    }
}
