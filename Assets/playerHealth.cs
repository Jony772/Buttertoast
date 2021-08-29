using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public static int playerHP = 20;
    public GameObject butterToast;
    public Collider collid;
    public Slider slider;
    public GameObject menuDie;

    void Start()
    {
        collid = butterToast.GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        if(playerHP < 1)
        {
            Destroy(butterToast);
            menuDie.SetActive(true);
            playerHP = 20;
        }
        slider.value = playerHP;
        if(playerHP > 20)
            playerHP = 20;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "stick")
        {
            playerHP = playerHP - 2;
        }
    }

    public void OnParticleCollision(GameObject other)
     {
        Debug.Log("bullet hit");
        if(other.tag == "bullet")
        {
        Debug.Log("bullet hit");
        playerHP = playerHP - 1;
        }
     }

}
