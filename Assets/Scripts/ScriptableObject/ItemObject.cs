using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]
public class ItemObject : ScriptableObject
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private string _itemName = "New Item";
    [SerializeField] private int _price = 45;
    [SerializeField] private Sprite _icon = null;

    public string ItemName { get => _itemName; set => _itemName = value; }
    public int Price { get => _price; set => _price = value; }
    public Sprite Icon { get => _icon; set => _icon = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
