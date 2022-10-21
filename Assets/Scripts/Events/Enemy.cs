using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// Events são um tipo especial de Delegates multi-cast. Ambos funcionam da mesma maneira
/// Diferentemente de Delegates, Events só podem ser acionados ou modificados dentro de sua própria classe
/// Adiciona uma camada a mais de proteção
public class Enemy : MonoBehaviour
{
    public delegate void OnEnemyDie();
    public static event OnEnemyDie onEnemyDie;

    private void Start()
    {
        onEnemyDie?.Invoke();

        // Verificador e tratamento
        //if (onEnemyDie != null)
        //{
        //    onEnemyDie();
        //}
        //else
        //{
        //    Debug.Log("Evento não existe");
        //}
    }
}
