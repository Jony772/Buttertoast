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
        InvokeRepeating("ButterPassGirl", 5, 4);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && ButterPass.girl == false)
        {
            ButterPass.girl = true;
 
        }

           if (Input.GetKeyDown(KeyCode.X))
             {
                    ButterPass.girl = false;
            }


        /*if (Input.GetKeyDown(KeyCode.Space) && ButterPass.girl == true) 
        {
            ButterPass.girl = false;
        } */
  


    }

    public void ButterPassGirl()
    {
        TextProGirl.SetActive(true);
        butterPassText.SetActive(true);

    }

    public void ButterPassDude()
    {

    }

}
