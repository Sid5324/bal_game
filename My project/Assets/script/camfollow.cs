using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{
  public GameObject  ball;
  private  Vector3  distance;
    [SerializeField]
    public float speed_H = 2.0f;
    public float speed_V = 2.0f;

    private float y=0.0f;
    private float P=0.0f;
    void Start()
    {
        distance = transform.position - ball.transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        y += speed_H * Input.GetAxis("Mouse X");
        P -= speed_V * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(P, y, 0.0f);

       transform.position = distance + ball.transform.position;
    }
}
