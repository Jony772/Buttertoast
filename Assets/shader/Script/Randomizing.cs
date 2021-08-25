using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizing : MonoBehaviour

{
    public MeshRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        rend.material.SetFloat("Vector1_randomizer", Random.Range(0f, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
