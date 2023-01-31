using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthControl : MonoBehaviour
{
    public GameObject pausePanel;
    public AudioSource ses;
    public float distanceFromObject = 2f;
    bool paused = false;
    private void Start()
    {
        ses = GetComponent<AudioSource>();
        Time.timeScale = 1;
    }
    void Update()
    {
        Pause();
    }
    public void DevamEt()
    {
        paused = false;
    }
    public void Duraklat()
    {
        paused = true;
    }
    public void AnaMenu()
    {
        SceneManager.LoadScene("anamenu");
    }
    void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                paused = false;
            }
            else
            {
                paused = true;
            }
        }
        if (paused)
        {
            ses.Pause();
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
        if (!paused)
        {
            ses.Play();
            Time.timeScale = 1;
            pausePanel.SetActive(false);
        }
    } 
}

