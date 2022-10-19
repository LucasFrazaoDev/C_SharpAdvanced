using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Singleton is a design pattern used when we need to call methods and variables of a class without needing a reference.
public class SimpleSingleton : MonoBehaviour
{
    public float speed;

    public static SimpleSingleton instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    public void GetSpeed()
    {

    }
}
