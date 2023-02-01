
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextlevel2 : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(WaitAndExecute(33.0f));
    }

    IEnumerator WaitAndExecute(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        // Code to execute after waiting for 5 seconds
        SceneManager.LoadScene(3);
    }
}
