using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] public int teleporterCost;
    public GameObject player;
    public GameObject currentRoom;
    public GameObject nextRoom;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("Teleporter Cost: " + teleporterCost);

            if (Player.playerPoints >= teleporterCost)
            {
                Player.playerPoints = Player.playerPoints - teleporterCost;
                currentRoom.SetActive(false);
                nextRoom.SetActive(true);  
            }
            else if (Player.playerPoints < teleporterCost)
            {
                Debug.Log("Not Enough Points");
                // small player pushback
            }
        }
    }
}
