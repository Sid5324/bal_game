using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class moveball : MonoBehaviour
{
    Rigidbody rb;
    float Hmove;
    float Vmove;
  public  float speed;
  public float jumpspeed;
  bool istouching = true;
    int count = 0;
    [SerializeField] TextMeshProUGUI scoretext;
    // public Text scoretext;
    public AudioSource addsource;
    public AudioClip MYaudioClip;
     
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        scoreText();
    }


  void FixedUpdate()    
    {
        Hmove = Input.GetAxis("Horizontal");
        Vmove = Input.GetAxis("Vertical");

        Vector3 ballmove = new Vector3(Hmove , 0.0f, Vmove ) ;

        rb.AddForce(ballmove * speed );

        if ((Input.GetKey(KeyCode.Space)) && istouching == true)
        {
            Vector3 jumpball = new Vector3(0.0f, 6.0f , 0.0f);
            rb.AddForce(jumpball * jumpspeed );
        }

        istouching = false;


    }

    private void OnCollisionStay()
    {
        istouching = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coins"))
        {
            other.gameObject.SetActive(false);
            count++;
            scoreText();
            addsource.PlayOneShot(MYaudioClip);
        }
    }

    void scoreText()
    {
        scoretext.text = "Score:" + count.ToString();
    }


}
