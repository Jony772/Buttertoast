using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;
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

    public GameObject sparksfx;
    public GameObject bubblesfx;
    public GameObject firefx;
    public GameObject nukefx; 

    public CinemachineVirtualCamera vcam1;
    public CinemachineVirtualCamera vcam2;






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
  
        if(passCount > 10 && isRaged == false)
        {
            butterPassText.SetActive(false);
            rageText.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && passCount > 10)
        {
            calmButter.SetActive(false);
            ragedButter.SetActive(true);
            rageText.SetActive(false);
            Invoke("sparksFX", 0);
            Invoke("bubblesFX", 3.0f);
            Invoke("fireFX", 10.0f);
            Invoke("nukeStart", 15.0f);


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

    public void sparksFX()
    {
        sparksfx.SetActive(true);
    }

    public void bubblesFX()
    {
        bubblesfx.SetActive(true);
    }

    public void fireFX()
    {
        firefx.SetActive(true);
    }

    public void nukeStart()
    {
        Instantiate(nukefx, new Vector3(186.6f, 93.6f, -64.29f), Quaternion.identity);
        Instantiate(nukefx, new Vector3(186.6f, 93.6f, -64.29f), Quaternion.identity);
        //Instantiate(nukefx, new Vector3(186.6f, 93.6f, -64.29f), Quaternion.identity);
        vcam1.Priority = 1;
    }



}
