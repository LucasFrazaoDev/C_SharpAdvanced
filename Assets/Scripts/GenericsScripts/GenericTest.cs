using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericTest : MonoBehaviour
{
    [SerializeField] private List<Item> items = new List<Item>();

    private void Start()
    {
        items.Add(new Item());
        items.Add(new Item());
        items.Add(new Item());

        //GetItemsByType<Item>();

        foreach (var item in GetItemsByType<Item>())
        {
            Debug.Log(item);
        }
    }

    List<Item> GetItemsByType<T>() where T : Item
    {
        List<Item> itemsReturn = new List<Item>();

        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] is T)
                itemsReturn.Add(items[i]);
        }

        return itemsReturn;
    }
}
