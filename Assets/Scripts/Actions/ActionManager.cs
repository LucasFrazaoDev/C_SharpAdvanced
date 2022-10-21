using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    private void OnEnable()
    {
        Actions.OnGameOver += ShowGameOver;
        Actions.OnGameOver += ShowRestartGame;
    }

    private void OnDisable()
    {
        Actions.OnGameOver -= ShowGameOver;
        Actions.OnGameOver += ShowRestartGame;
    }

    private void Start()
    {
        Actions.OnGameOver();
    }

    private void ShowGameOver()
    {
        Debug.Log("Game over do Action");
    }

    private void ShowRestartGame()
    {
        Debug.Log("Restart Game!");
    }
}
