using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EventManager : MonoBehaviour
{
    private void OnEnable()
    {
        Enemy.onEnemyDie += ShowGameOver;
    }

    private void Start()
    {
        Debug.Log("Reiniciar!");
    }

    private void OnDisable()
    {
        Enemy.onEnemyDie -= ShowGameOver;
    }

    private void ShowGameOver()
    {
        Debug.Log("Perdeu playboy!");
    }
}
