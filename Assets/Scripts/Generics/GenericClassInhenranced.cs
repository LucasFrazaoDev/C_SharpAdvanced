using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassInhenranced : MonoBehaviour
{    

    private void Start()
    {
        // Generics test with different classes
        Item item = new Item();
        Weapon sword = new Weapon(5);
        Weapon shield = new Weapon(10);

        GenericClass<Item>.AddToList(item);
        GenericClass<Weapon>.AddToList(sword);
        GenericClass<Weapon>.AddToList(shield);

        GenericClass<Item>.GetObjectsFromList();
        GenericClass<Weapon>.GetObjectsFromList();
    }
}
