using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlCollid : MonoBehaviour
{
    public GameObject  TextProDude;
    public GameObject  TextProGirl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collid girl");
        TextProGirl.SetActive(false);
    }
}
