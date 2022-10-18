using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassInhenranced : MonoBehaviour
{    

    private void Start()
    {
        Weapon sword = new Weapon(5);
        Weapon shield = new Weapon(10);

        GenericClass<Weapon>.AddToList(sword);
        GenericClass<Weapon>.AddToList(shield);

        GenericClass<Weapon>.GetObjectsFromList();
    }
}
