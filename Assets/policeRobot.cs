using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policeRobot : MonoBehaviour
{
    public int HP = 5;
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
            meleeCop.SetActive(false);
            HP = 300;
        }



    }

    public void OnParticleCollision(GameObject other)
     {
        if(other.tag != "bullet")
        HP = HP - 1;
     }
}
