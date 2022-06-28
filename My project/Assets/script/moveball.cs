using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveball : MonoBehaviour
{
    Rigidbody rb;
    float Hmove;
    float Vmove;
  public  float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Movement();
    }
    // move input
    void Movement()
    {
        Hmove = Input.GetAxis("Horizontal");
        Vmove = Input.GetAxis("Vertical");

        //rb.velocity = new Vector3(Hmove, rb.velocity.y, Vmove) * speed

       Vector3 ballmove = new Vector3(Hmove, 0.0f, Vmove);

        rb.AddForce(ballmove * speed);

    }
    
   



}
