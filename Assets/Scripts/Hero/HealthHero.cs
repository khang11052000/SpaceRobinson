using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHero : MonoBehaviour
{
    
    public int maxHealth = 5;
    private int _currentHealth;

    
    private void Awake()
    {
        _currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        Debug.Log($"Hero HP -{damage}");

        int newHealth = _currentHealth - damage;

        _currentHealth = newHealth;
    }
}
