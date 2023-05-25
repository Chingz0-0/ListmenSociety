using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int capacity = 10; // Maximum number of items the inventory can hold

    private List<Item> items; // List to store the items

    private void Start()
    {
        items = new List<Item>();
    }

    // Add an item to the inventory
    public bool AddItem(Item item)
    {
        if (items.Count < capacity)
        {
            items.Add(item);
            Debug.Log("Added item: " + item.name);
            return true;
        }
        else
        {
            Debug.Log("Inventory is full!");
            return false;
        }
    }

    // Remove an item from the inventory
    public bool RemoveItem(Item item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log("Removed item: " + item.name);
            return true;
        }
        else
        {
            Debug.Log("Item not found in inventory!");
            return false;
        }
    }
}
