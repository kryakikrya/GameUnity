using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] int timer;
    [SerializeField] float force;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyShooting enemy = collision.GetComponent<EnemyShooting>();
        if (enemy != null)
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
    
    IEnumerator AutoDesroy()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
