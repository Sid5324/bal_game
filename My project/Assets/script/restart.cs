using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    private Scene scene;    
    void OnTriggerEnter()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   
    }
}
