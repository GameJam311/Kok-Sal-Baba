using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextlvl : MonoBehaviour
{
    public void Start()
    {
        scene();
    }
    public void scene()
    {
        StartCoroutine(waiter());
        SceneManager.LoadScene(1);
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(8.60f);

    }
}
