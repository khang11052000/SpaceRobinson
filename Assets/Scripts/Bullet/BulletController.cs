using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // [HideInInspector]
    // public Rigidbody2D rb2d;
    
    public int damage = 5;
    
    public LayerMask layerTakeDamage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check layer in layer take damage
        if (layerTakeDamage == (layerTakeDamage | (1 << collision.gameObject.layer)))
        {
            BaseEntity enemyEntity = collision.gameObject.GetComponent<BaseEntity>();
            enemyEntity.OnTakeDamage?.Invoke(damage);
            Debug.Log(collision.gameObject.layer);
        }
        
        Destroy(gameObject);
    }
}

