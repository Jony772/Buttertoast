using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standingMeleeStats : MonoBehaviour
{
    public int HP = 1;
    public GameObject meleeCop;
    public GameObject dieFX;
    private new Vector3 copTransform;
    void Start()
    {
    }

    void Update()
    {
        copTransform = meleeCop.transform.position;

        if(HP < 1)
        {
            Instantiate(dieFX, copTransform, Quaternion.identity);
            Destroy(meleeCop);
        }



    }

    public void OnParticleCollision(GameObject other)
     {
        HP = HP - 1;
     }
}
