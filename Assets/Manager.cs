using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public GameObject  TextProDude;
    public GameObject  TextProGirl;
    public GameObject butterPassText;
    public GameObject butterPlate;
    private int passCount;

    void Start()
    {
        Invoke("ButterPassGirl", 5);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }   

    }

    public void ButterPassGirl()
    {
        TextProGirl.SetActive(true);
        butterPassText.SetActive(true);
    }

}
