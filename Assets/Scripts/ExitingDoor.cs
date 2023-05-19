using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitingDoor : MonoBehaviour


{
    private GameObject Teleporter;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Teleporter != null)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                transform.position = Teleporter.GetComponent<Door>().GetDestination().position;
            }
        }

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ExDoor"))
        {
            Teleporter = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ExDoor"))
        {
            if (collision.gameObject == Teleporter)
            {
                Teleporter = null;
            }
        }
    }
}
