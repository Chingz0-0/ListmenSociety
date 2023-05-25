using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public Animator chestAnimator;
    public Item itemToGive;

    private bool isOpen = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isOpen)
        {
            OpenChest();
        }
    }

    private void OpenChest()
    {
        isOpen = true;
        chestAnimator.SetBool("IsOpen", true);

        // Add the item to the player's inventory
        Inventory playerInventory = FindObjectOfType<Inventory>();
        if (playerInventory != null)
        {
            bool success = playerInventory.AddItem(itemToGive);
            if (success)
            {
                // Do something when the item is successfully added to the inventory
                Debug.Log("Item added to inventory!");
            }
        }
    }
}