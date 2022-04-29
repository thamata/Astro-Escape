using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public float speed = 20f;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
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

}