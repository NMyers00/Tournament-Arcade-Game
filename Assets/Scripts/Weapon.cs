using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public string fire;
    public float firerate;
    float nextFire;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(fire))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if(Time.time > nextFire)
        {
            nextFire = Time.time + firerate;
            GameObject bullet=Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.GetComponent<Bullet>().direction=transform.localScale.x;
        }
        
    }
}
