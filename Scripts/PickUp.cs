using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject player;
    bool isActive = true;
    SpriteRenderer spriteRenderer;
    float timer = 0f;
    public string type;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (!isActive)
        {
            timer += Time.deltaTime;
            if (timer > 10)
            {
                isActive = true;
                spriteRenderer.enabled = true;
                timer = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {   
        if (col.gameObject.name == "Player" && isActive)
        {
            isActive = false;
            spriteRenderer.enabled = false;
            if (type == "Ammo")
            {
                AmmoPickUp();
            }
            else if (type == "Power")
            {
                PowerPickUp();
            }
        }
    }

    void AmmoPickUp()
    {
        Debug.Log("Total Ammo: " + Player.playerAmmo);
        Player.playerAmmo += 5;
    }

    void PowerPickUp()
    {
        int selection = Random.Range(1, 3);
        if (selection == 1)
        {
            Debug.Log("1 Damage to All Enemies");
        }
        else if (selection == 2)
        {
            Debug.Log("Bonus Points");
            Player.playerPoints += 10 * Player.multiplier;
        }
        else if (selection == 3)
        {
            Debug.Log("Third Power Up");
        }
    }
}
