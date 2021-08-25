using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dudeCollid : MonoBehaviour
{
    public GameObject  TextProDude;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        TextProDude.SetActive(false);
        Manager.passCount = Manager.passCount + 1;
    }
}
