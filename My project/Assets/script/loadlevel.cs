using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadlevel : MonoBehaviour
{
    public int Clevel;
    public int Nlevel;
    public bool usignID=false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            levelchange();
        }
    }

    void levelchange()
    {
        if (usignID)
        {
            SceneManager.LoadScene(Nlevel);
        }
        else
        {
            SceneManager.LoadScene(Clevel+1);
        }
    }



}
