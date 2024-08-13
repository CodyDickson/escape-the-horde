using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] public static int playerHealth = 5;
    [SerializeField] public static int playerAmmo = 10; 
    public static int playerPoints = 0;
    public static int multiplier = 1;
    public static int playerKillStreak;
    public static int playerLives = 1;
    public float bulletVelocity = 5f;
    public GameObject bullet;
    public GameObject bullet1;
    public GameObject currentRoom;
    public GameObject devRoom;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;
        }

        if (Input.GetButtonDown("Fire1") && playerAmmo > 0)
        {
            Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (Vector2)((worldMousePos - transform.position));
            direction.Normalize();
            GameObject bullet = (GameObject)Instantiate(bullet1, transform.position + (Vector3)(direction * 0.5f), Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;
            bullet.name = "Bullet";
            playerAmmo -= 1;
        }

        if (playerHealth < 1 && playerLives == 0)
        {
            PlayerDeath();
        }
        else if (playerHealth < 1 && playerLives > 0)
        {
            playerLives -= 1;
            Debug.Log("Lives Remaining: " + playerLives);            
        }
    }

    public void PlayerDeath()
    {
        Debug.Log("Player has died.");

        // currentRoom.SetActive(false);
        // devRoom.SetActive(true);
        // playerHealth = 5;
        // playerAmmo = 10;

        // screen goes black
        // display message
    }
}
