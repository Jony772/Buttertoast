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
    public GameObject rageText;
    public static int passCount = 0;

    public GameObject calmButter;
    public GameObject ragedButter;
    public bool isRaged = false;


    void Start()
    {
        InvokeRepeating("ButterPassGirl", 5, 4);
        InvokeRepeating("ButterPassDude", 8, 6);

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
  
        if(passCount > 10)
        {
            butterPassText.SetActive(false);
            rageText.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && passCount > 10)
        {
            calmButter.SetActive(false);
            ragedButter.SetActive(true);
            isRaged = true;
        }

    }

    public void ButterPassGirl()
    {
        TextProGirl.SetActive(true);
        //butterPassText.SetActive(true);

    }

    public void ButterPassDude()
    {
        TextProDude.SetActive(true);
    }

}
