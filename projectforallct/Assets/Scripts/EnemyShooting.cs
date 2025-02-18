using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public Transform firePos;

    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 2)
        {
            timer = 0;
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(bullet, firePos.position, Quaternion.identity);
    }
}
