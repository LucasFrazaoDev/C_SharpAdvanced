using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Actions : MonoBehaviour
{
    // Para usar Action precisa importar a biblioteca System
    // Métodos usado no Action PRECISAM ser do tipo void
    // Actions podem ser Events também, ser acessado apenas da sua classe
    public static Action OnGameOver;

    private float health = -5f;

    public void Damage(float dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            OnGameOver?.Invoke();
        }
    }
}
