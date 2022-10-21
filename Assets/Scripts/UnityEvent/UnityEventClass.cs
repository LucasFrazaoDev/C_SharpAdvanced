using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventClass : MonoBehaviour
{
    public UnityEvent onPlayerDeath;

    private float health;

    private void Start()
    {
        TakeDamage(10f);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            onPlayerDeath?.Invoke();
        }
    }
}
