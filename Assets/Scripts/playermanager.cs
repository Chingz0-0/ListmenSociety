using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermanager : MonoBehaviour
{
    public int Currenthealth;
    public int MaxHealth;
    Player_Movement Movement;

    public int coinCount;

    void Start()
    {
        Movement = GetComponent<Player_Movement>();
    }

    void Update()
    {
        if (Currenthealth <= 0)

        {
            PauseGame();
        }
    }


    // Update is called once per frame
    public bool PickupItem(GameObject obj)
    {
        switch (obj.tag)
        {
            case "currency":
                coinCount++;
                return true;
            case "Speed+":
               
                return true;
            default:
                Debug.Log("no tag or reference is not set for this game object");
                return false;
        }
    }
    public void TakeDamage()
    {
        Currenthealth -= 1;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

}