using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public static int HP = 10;
    public GameObject butterToast;

    void Start()
    {
        
    }

    void Update()
    {
        if(HP < 1)
        {
            Destroy(butterToast);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "stick")
        {
            HP = HP - 2;
        }
    }

    public void OnParticleCollision(GameObject other)
     {
        HP = HP - 1;
     }

}
