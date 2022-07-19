using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pendulm : MonoBehaviour
{

    Quaternion _start, _end;

    [SerializeField, Range(0.0f, 360f)]
    public float angle = 90f;

    [SerializeField, Range(0.0f, 5.0f)]
    public float speed = 2.0f;

    [SerializeField, Range(0.0f,10.0f)]
    public float startime = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        _start=pendulumrotation(angle);
        _end = pendulumrotation(-angle);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        startime+=Time.deltaTime;
        transform.rotation=Quaternion.Lerp(_start,_end,(Mathf.Sin(startime+speed+Mathf.PI/2)+1.0f)/2.0f);



    }

   void  Resettime()
    {
        startime = 0.0f;                    
    }

    Quaternion pendulumrotation(float angle)
    {
        var pendulumrotation = transform.rotation;
        var angleZ= pendulumrotation.eulerAngles.z+angle;

        if (angleZ > 180)
            angleZ -= 360;
        if (angleZ < -180)
            angleZ += 360;
        pendulumrotation.eulerAngles = new Vector3(pendulumrotation.eulerAngles.x, pendulumrotation.eulerAngles.y,angleZ);

        return pendulumrotation;




    }
}
