using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericTest : MonoBehaviour
{
    [SerializeField] private List<Item> items = new List<Item>();

    // This numeric list was to remember how to declare a list and assign values immediately
    //[SerializeField] private List<int> numbers = new List<int> { 1, 5 };

    private void Start()
    {
        items.Add(new Item());
        items.Add(new Item());
        items.Add(new Item());

        items.Add(new Weapon(5));
        items.Add(new Weapon(26));

        // GetItemsByType<Item>();

        foreach (var item in GetItemsByType<Item>())
        {
            Debug.Log(item);
        }
    }

    private List<Item> GetItemsByType<T>() where T : Item
    {
        List<Item> itemsReturn = new List<Item>();

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] is T)
                itemsReturn.Add(items[i]);
            Debug.Log("Item " + i);
        }

        return itemsReturn;
    }
}
