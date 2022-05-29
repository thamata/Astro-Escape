using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public float speed;

    public Rigidbody2D rb;
    public AudioSource shipDeath;

    // Start is called before the first frame update
    void Start()
    {
        speed = GameController.enemySpeed;
        float x = transform.position.x;
        if (x > 0)
        {
            rb.velocity = (-transform.up + transform.right) * speed;
        }
        else
        {
            rb.velocity = (-transform.up + -transform.right) * speed;
        }

        Destroy(gameObject, 7f);

    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Laser")) {
            shipDeath.Play();
            StartCoroutine("KillEnemy", 0.15f);
        }
    }

    IEnumerator KillEnemy(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }
}