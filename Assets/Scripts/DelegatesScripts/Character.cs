using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Exemplo multi-cast

public class Character : MonoBehaviour
{
    // Método OnEnable é chamado após o Awake
    private void OnEnable()
    {
        //assina-la com os 2 metodos 
        DelegateExample.myDelegate += DebugName;
        DelegateExample.myDelegate += DestroyMyObj;
    }

    private void Start()
    {
        //chama o delegate
        // A interrogação verifica se o delegate é nulo
        DelegateExample.myDelegate?.Invoke();
    }

    public void DebugName()
    {
        Debug.Log("Lucas");
    }

    public void DestroyMyObj()
    {
        Destroy(gameObject);
    }

    // Método OnDisable é chamado antes do Destroy
    private void OnDisable()
    {
        // Verifica se o Delegate possui assinatura
        if (DelegateExample.myDelegate == null)
            return;

        //retira assinatura dos metodos
        DelegateExample.myDelegate -= DebugName;
        DelegateExample.myDelegate -= DestroyMyObj;
    }
}
