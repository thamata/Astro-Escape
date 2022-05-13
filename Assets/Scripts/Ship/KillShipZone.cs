using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillShipZone : MonoBehaviour
{
    public GameObject ship;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Astroid")
        {
            Destroy(ship);
            Destroy(collision.gameObject);
            GameController.shipsAlive -= 1;
            
        }
    }
}
