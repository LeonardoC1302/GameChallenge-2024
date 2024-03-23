using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDealDamage : MonoBehaviour
{
    [SerializeField] private float damage =1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Health>().takeDamage(damage);
        }
    }
 
}
