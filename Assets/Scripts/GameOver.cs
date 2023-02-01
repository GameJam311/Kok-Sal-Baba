using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void cýkýs()
    {
        Application.Quit();
    }

    public void anamenu()
    {
        SceneManager.LoadScene("acilis");
    }
    public void hazýrlayanlar()
    {

    }
}
