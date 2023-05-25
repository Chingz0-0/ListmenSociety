using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneEntrance : MonoBehaviour
{
    public string LastExitName;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("LastExitName")== LastExitName)
        {
            PlayerScript.instance.transform.position = transform.position;
            PlayerScript.instance.transform.eulerAngles= transform.eulerAngles;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
