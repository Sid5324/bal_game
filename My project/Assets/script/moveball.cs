using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveball : MonoBehaviour
{
    Rigidbody rb;
    float Hmove;
    float Vmove;
  public  float speed;
  public float jumpspeed;
  bool istouching = true;
     
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


  void FixedUpdate()    
    {
        Hmove = Input.GetAxis("Horizontal");
        Vmove = Input.GetAxis("Vertical");

        Vector3 ballmove = new Vector3(Hmove, 0.0f, Vmove);

        rb.AddForce(ballmove * speed);

        if ((Input.GetKey(KeyCode.Space)) && istouching == true)
        {
            Vector3 jumpball = new Vector3(0.0f, 6.0f, 0.0f);
            rb.AddForce(jumpball * jumpspeed);
        }

        istouching = false;
    }

    private void Update()
    {

    
    }











    private void OnCollisionStay()
    {
        istouching = true;
    }




}
