using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumppad : MonoBehaviour
{
    [SerializeField] float bouncevol = 10f;


    private void Start()
    {
      
    }




    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ball"))
            {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

            rb.velocity = new Vector3(0.0f, bouncevol, 0.0f);
        }
    }

}
