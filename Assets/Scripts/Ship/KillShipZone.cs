using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillShipZone : MonoBehaviour
{
    public AudioSource shipDeath;
    public GameObject ship;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Astroid")
        {
            KillShip();
            Destroy(collision.gameObject);
            
            
        }
    }

    public void KillShip()
    {
        shipDeath.Play();
        GameController.shipsAlive -= 1;
        StartCoroutine("DestroyShip", .3f);
    }

    IEnumerator DestroyShip(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(ship);
    }

}
