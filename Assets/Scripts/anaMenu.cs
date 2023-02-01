using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anaMenu : MonoBehaviour
{
    public Animator animator;
    public GameObject panel, text;
    float sayac = 0;
    bool start = false;
    private void Start()
    {
        Time.timeScale = 1;
    }
    private void Update()
    {
        Sayac();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            text.SetActive(false);
            animator.SetBool("Enter", true);
            start = true;
        }
    }
    void Sayac()
    {
        if (start)
        {
            sayac += Time.deltaTime;
        }
        if (sayac > 2.5)
        {
            panel.SetActive(false);
        }
    }
    public void Cikis()
    {
        Application.Quit();
    }
    public void Basla()
    {
        SceneManager.LoadScene(1);
    }
}
