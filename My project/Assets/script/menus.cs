using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menus : MonoBehaviour
{
  public void playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void exitgame()
    {
        Application.Quit();
    }

    public void Mainemenu()
    {
        SceneManager.LoadScene(0);
    }
}
