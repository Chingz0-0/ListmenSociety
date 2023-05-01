using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projstart : MonoBehaviour
{
    public EnemyProj proj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        GameObject go = Instantiate(proj.gameObject, transform.position, Quaternion.identity);
    }
}
