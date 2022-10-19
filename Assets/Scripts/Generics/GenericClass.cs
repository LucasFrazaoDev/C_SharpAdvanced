using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GenericClass<T> where T : MonoBehaviour
{
    private static List<T> myList = new List<T>();

    public static void AddToList(T obj)
    {
        myList.Add(obj);
    }

    public static void GetObjectsFromList()
    {
        if(myList.Count > 0)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                GameObject newObject = new GameObject();
                myList[i] = newObject.AddComponent<T>();
                myList[i].name = typeof(T).ToString();
            }
        }
    }
}
