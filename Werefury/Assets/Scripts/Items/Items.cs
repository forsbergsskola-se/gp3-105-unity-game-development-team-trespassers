using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{

    [SerializeField] private List<GameObject> items = new List<GameObject>();

    // Add an item to the inventory
    public void AddItem(GameObject item)
    {
        items.Add(item);
    }

    // Remove an item from the inventory
    public void RemoveItem(GameObject item)
    {
        items.Remove(item);
    }

    // Check if the inventory contains a specific item
    public bool ContainsItem(GameObject item)
    {
        return items.Contains(item);
    }

    // Get the count of items in the inventory
    public int GetItemCount()
    {
        return items.Count;
    }
}

// Item class to represent items in the inventory
public class Item
{
    public string itemName;
    public int itemID;

    public Item(string name, int id)
    {
        itemName = name;
        itemID = id;
    }
}
