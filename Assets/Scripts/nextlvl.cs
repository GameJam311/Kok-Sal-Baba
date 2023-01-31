using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextlvl : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(WaitAndExecute(7.0f));
    }

    IEnumerator WaitAndExecute(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        // Code to execute after waiting for 5 seconds
        SceneManager.LoadScene(1);
    }
}
