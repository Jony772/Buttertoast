using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer : MonoBehaviour
{
    public GameObject lazer1;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            lazer1.SetActive(true);
        }
        else
        {
            lazer1.SetActive(false);
        }
    }
}
