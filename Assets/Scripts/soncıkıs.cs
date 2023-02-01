using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class soncıkıs : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(WaitAndExecute(30.0f));
    }

    IEnumerator WaitAndExecute(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        // Code to execute after waiting for 5 seconds
        SceneManager.LoadScene(0);
    }
}
