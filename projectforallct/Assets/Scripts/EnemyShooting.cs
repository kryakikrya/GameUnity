using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class EnemyShooting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject bullet;
    [SerializeField] Transform firePos;
    [SerializeField] int fireRate;
    [SerializeField] Transform playertransform;
    void Start()
    {
        if (fireRate < 1) fireRate = 1;
        StartCoroutine(Reload());
    }
    private void FixedUpdate()
    {
        Vector3 direction = playertransform.transform.position - transform.position;
        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);
    }
    void Shoot()
    {
        Instantiate(bullet, firePos.position, firePos.transform.rotation);
    }
    IEnumerator Reload()
    {
        while (true)
        {
            yield return new WaitForSeconds(fireRate);
            Shoot();
        }
    }
}
