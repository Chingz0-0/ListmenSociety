using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    private int potionCount = 0; // The current count of potions in the inventory

    public void AddPotions(int quantity)
    {
        potionCount += quantity;
        Debug.Log(quantity + " potions added to inventory. Total potions: " + potionCount);
    }
}

