using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("test");

            playermanager manager = collision.GetComponent<playermanager>();

            if (manager)
            {
                bool PickedUp = manager.PickupItem(gameObject);
                if (PickedUp)
                {


                }
            }
            Destroy(gameObject);
        }
    }
}
