using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKillShip : MonoBehaviour
{
    public GameObject ship;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //Destroy(ship);
            Debug.Log("Hit");
        }
    }
}
