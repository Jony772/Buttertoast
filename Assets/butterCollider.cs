using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnParticleCollision(GameObject other)
     {
        Debug.Log("bullet hit");
     }
}
