using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Delegate armazena um método para ser usado como variável
/// Exemplo single-cast

public class DelegateExample : MonoBehaviour
{
    // Delegates do tipo return devem armazenar funções do tipo return
    // com o mesmo tipo de retorno

    public delegate void MyDelegate();
    public static MyDelegate myDelegate;

    //private void Start()
    //{
    //    myDelegate = DebugName;
    //    myDelegate("Lucas Frazão");
    //}

    //public void DebugName(string name)
    //{
    //    Debug.Log(name);
    //}
}
