using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stats", menuName = "Inventory/Player Stats")]
public class PlayerStats : ScriptableObject
{
    [SerializeField] private int goldAmount;
    [SerializeField] private float health;

    [SerializeField] private ItemObject currentItem;

    [SerializeField] private List<ItemObject> inventory = new List<ItemObject>();
}
