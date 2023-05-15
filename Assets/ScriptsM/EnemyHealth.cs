using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int health = 30;
    private int MAX_HEALTH = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have a negative Damage");
        }
        this.health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    

    private void Die()
    {
        Debug.Log("I am Dead!!");
        Destroy(gameObject);
    }
}
