using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lazer : MonoBehaviour
{
    public GameObject lazer1;
    public float energy = 100.0f;
    public Slider slider;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            energy = energy - 0.12f;
            if(energy > 0f)
            {
                lazer1.SetActive(true);

            }
            else
            {
                lazer1.SetActive(false);
            }
        }
        else
        {
            lazer1.SetActive(false);
            energy = energy + 0.2f;
        }

        slider.value = energy;

    }
}
