using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class outbound : MonoBehaviour
{
    private void OnTriggerExit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
