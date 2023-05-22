using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_Potion : MonoBehaviour
{
      IEnumerator PowerUp()
      {
       var strengthComponent = GetComponent<AttackArea>();

       var speedComponent = GetComponent<Player_Movement>();

       strengthComponent.damage = 20;
        speedComponent.moveSpeed = 10;

        yield return new WaitForSeconds(60);

        strengthComponent.damage = 10;
        speedComponent.moveSpeed = 8;

            Destroy(gameObject);
      }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(PowerUp());
        }
    }


}
