using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform firePos;
    [SerializeField] int fireRate;
    [SerializeField] float force;
    bool canShoot = true;
    void Start()
    {
        if (fireRate < 1) fireRate = 1;
        StartCoroutine(Reload());
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (canShoot)
            {
                Shoot();
                canShoot = false;
                StartCoroutine (Reload());
            }
        }
    }
    void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, firePos.position, firePos.transform.rotation);
        Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePos.up * force, ForceMode2D.Impulse);
    }
    IEnumerator Reload()
    {
            yield return new WaitForSeconds(fireRate);
            canShoot = true;
    }
    
}
