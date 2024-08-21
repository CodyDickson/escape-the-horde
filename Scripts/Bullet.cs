using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Enemy" && !GameMain.piercingBullets)
        {
            Destroy(this.gameObject);
        }
        else if (col.collider.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
