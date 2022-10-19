using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameController.Instance.GetSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
