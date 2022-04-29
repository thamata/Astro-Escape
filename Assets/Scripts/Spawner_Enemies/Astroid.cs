using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{
    [SerializeField] public float speed = 20f;

    public Rigidbody2D rb;
    public GameObject gb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = -transform.up * speed;
        gb.transform.Rotate(0, 0, 53f);
        Destroy(gameObject, 7f);

    }

    // Update is called once per frame
    void Update()
    {

    }
}