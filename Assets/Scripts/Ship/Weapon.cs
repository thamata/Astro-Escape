using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject laserPrefab;

    public bool canShoot;
    public float coolDownTime = 2;
    private float nextFireTime = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (canShoot) {
            Shoot();
        }
    }
    private void Shoot() {
        canShoot = false;
        if(Time.time > nextFireTime) {
            Instantiate(laserPrefab, firepoint.position, firepoint.rotation);
            nextFireTime = Time.time + coolDownTime;
        }
        canShoot = true;
    }
}