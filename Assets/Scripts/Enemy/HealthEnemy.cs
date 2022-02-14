using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthEnemy : BaseComponent, IDamageable  
{
    public int maxHealth = 100;
    private int _currentHealth;
    
    private void Awake()
    {
        _currentHealth = maxHealth;
    }
    
    public virtual void TakeDamage(int damage)
    {
        int newHealth = _currentHealth - damage;
        if (newHealth <= 0)
        {
            entity.OnDeath?.Invoke();
            _currentHealth = 0;
            gameObject.SetActive(false);
            return;
        }

        if (newHealth > maxHealth)
        {
            _currentHealth = maxHealth;
            return;
        }

        _currentHealth = newHealth;
    }

    private void Update()
    {
        //Debug.Log(_currentHealth);
    }
}
