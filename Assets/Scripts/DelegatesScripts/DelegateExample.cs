using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Delegate armazena um m�todo para ser usado como vari�vel
/// Exemplo single-cast

public class DelegateExample : MonoBehaviour
{
    // Delegates do tipo return devem armazenar fun��es do tipo return
    // com o mesmo tipo de retorno

    public delegate void MyDelegate();
    public static MyDelegate myDelegate;

    //private void Start()
    //{
    //    myDelegate = DebugName;
    //    myDelegate("Lucas Fraz�o");
    //}

    //public void DebugName(string name)
    //{
    //    Debug.Log(name);
    //}
}
