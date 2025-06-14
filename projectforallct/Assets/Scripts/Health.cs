using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health;
    
    public void GetDamage(int value)
    {
        if (health - value <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            health -= value;
        }
    }
}
