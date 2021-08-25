using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterPass : MonoBehaviour
{
    public Transform girlTarget;
    public Transform dudeTarget;

    public float plateSpeed = 0.3f;
    public static bool girl = false;
    public static bool dude = false;
    void Start()
    {
        
    }

    void Update()
    {
        if(girl == true)
        {
            transform.position = Vector3.Lerp(transform.position, girlTarget.position, plateSpeed * Time.deltaTime);
            //girl = false;
            /*if(Input.GetKeyDown(KeyCode.Space))
            {
                //girlCounter();
            }*/
        }

        if(girl == false)
        {
         transform.position = Vector3.Lerp(transform.position, dudeTarget.position, plateSpeed * Time.deltaTime);
        }



       /* if(dude == true)
        {
            transform.position = Vector3.Lerp(transform.position, dudeTarget.position, plateSpeed * Time.deltaTime);
            //dude = false;
        }*/
    }

        private void girlCounter()
        {
            girl = false;
        }
}
