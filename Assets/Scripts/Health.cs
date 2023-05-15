using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHearts;
    public Sprite emptyHearts;
   [SerializeField] private float IFramesDuration;
    [SerializeField] private int numberOfFlashes;
    private SpriteRenderer spriteRend;

    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        numOfHearts = 5;
        spriteRend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        { if (i < health)
            {
                hearts[i].sprite = fullHearts;
            }
            else
            { 
                hearts[i].sprite = emptyHearts;
            }
            if(i <numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else {
                hearts[i].enabled = false;
            }

            
        }
    
    
    }
   public void TakeDamage(int amount)
    {
        health -= amount;
        StartCoroutine(Invunerability());
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

   // public void Heal(int amount)
    //{
       // if (amount < 0)
        //{
            //throw new System.ArgumentOutOfRangeException("Cannot have a negative Healthing");
       // }

        //bool wouldbeOverMaxHealth = health + amount > MAX_HEALTH

       // if (wouldbeOverMaxHealth)
       // {
            //this.health = MAX_HEALTH;
        //}
       // else
        //{
           // this.health += amount;
       // }

    //}
    private IEnumerator Invunerability()
    {
        Physics2D.IgnoreLayerCollision(1, 2, true);
        for(int v = 0; v < numberOfFlashes; v++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(1);
            spriteRend.color = Color.white;
        }
        Physics2D.IgnoreLayerCollision(1, 2, false);
    }
}
