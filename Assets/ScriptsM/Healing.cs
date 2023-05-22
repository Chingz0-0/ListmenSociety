using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    Health health;
    void Start()
    {
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            var healthComponent = collision.GetComponent<Health>();

            healthComponent.Heal();

            Destroy(gameObject);
        }
    }
}
