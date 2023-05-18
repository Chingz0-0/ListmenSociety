using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Boss_Health : MonoBehaviour
{
    public int health = 150;
    public GameObject deatheffect;
    public bool isInvulnerable = false;

    public void TakeDamge(int damage)
    {
        if (isInvulnerable)
            return;
        health -= damage;

        if(health <= 100)
        {
            GetComponent<Animator>().SetBool("Attack2", true);
        }

        if(health <= 50)
        {
            GetComponent<Animator>().SetBool("Attack3", true);
        }

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deatheffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
