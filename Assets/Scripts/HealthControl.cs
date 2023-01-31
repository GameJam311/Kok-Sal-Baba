using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthControl : MonoBehaviour
{
    public GameObject kalp1, kalp2, kalp3,yarýmKalp1,yarýmKalp2,yarýmKalp3,bosKalp1,bosKalp2,bosKalp3,pausePanel;
    public AudioSource ses;
    private int can = 8;
    public float distanceFromObject = 2f;
    bool paused = false;
    private void Start()
    {
        ses = GetComponent<AudioSource>(); 
        Time.timeScale = 1;
    }
    void Update()
    {
        KalpKontrol();
        Pause();
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
    void KalpKontrol()
    {
        if (can == 8)
        {
            kalp1.SetActive(true);
            kalp2.SetActive(true);
            kalp3.SetActive(true);
            yarýmKalp1.SetActive(false);
            yarýmKalp2.SetActive(false);
            yarýmKalp3.SetActive(false);
            bosKalp1.SetActive(false);
            bosKalp2.SetActive(false);
            bosKalp3.SetActive(false);
        }
        if (can == 7) 
        {
            kalp1.SetActive(true);
            kalp2.SetActive(true);
            kalp3.SetActive(true);
            yarýmKalp1.SetActive(false);
            yarýmKalp2.SetActive(false);
            yarýmKalp3.SetActive(false);
            bosKalp1.SetActive(false);
            bosKalp2.SetActive(false);
            bosKalp3.SetActive(false);
        }
        if (can == 6)
        {
            kalp1.SetActive(true);
            kalp2.SetActive(true);
            kalp3.SetActive(false);
            yarýmKalp1.SetActive(false);
            yarýmKalp2.SetActive(false);
            yarýmKalp3.SetActive(true);
            bosKalp1.SetActive(false);
            bosKalp2.SetActive(false);
            bosKalp3.SetActive(false);
        }
        if (can == 5)
        {
            kalp1.SetActive(true);
            kalp2.SetActive(true);
            kalp3.SetActive(false);
            yarýmKalp1.SetActive(false);
            yarýmKalp2.SetActive(false);
            yarýmKalp3.SetActive(false);
            bosKalp1.SetActive(false);
            bosKalp2.SetActive(false);
            bosKalp3.SetActive(true);
        }
        if (can == 4)
        {
            kalp1.SetActive(true);
            kalp2.SetActive(false);
            kalp3.SetActive(false);
            yarýmKalp1.SetActive(false);
            yarýmKalp2.SetActive(true);
            yarýmKalp3.SetActive(false);
            bosKalp1.SetActive(false);
            bosKalp2.SetActive(false);
            bosKalp3.SetActive(true);
        }
        if (can == 3)
        {
            kalp1.SetActive(true);
            kalp2.SetActive(false);
            kalp3.SetActive(false);
            yarýmKalp1.SetActive(false);
            yarýmKalp2.SetActive(false);
            yarýmKalp3.SetActive(false);
            bosKalp1.SetActive(false);
            bosKalp2.SetActive(true);
            bosKalp3.SetActive(true);
        }
        if (can == 2)
        {
            kalp1.SetActive(false);
            kalp2.SetActive(false);
            kalp3.SetActive(false);
            yarýmKalp1.SetActive(true);
            yarýmKalp2.SetActive(false);
            yarýmKalp3.SetActive(false);
            bosKalp1.SetActive(false);
            bosKalp2.SetActive(true);
            bosKalp3.SetActive(true);
        }
        if (can == 1)
        {
            kalp1.SetActive(false);
            kalp2.SetActive(false);
            kalp3.SetActive(false);
            yarýmKalp1.SetActive(false);
            yarýmKalp2.SetActive(false);
            yarýmKalp3.SetActive(false);
            bosKalp1.SetActive(true);
            bosKalp2.SetActive(true);
            bosKalp3.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        // Iterate through all objects
        foreach (GameObject obj in allObjects)
        {
            // Calculate the distance between the main character and the current object
            float distance = Vector2.Distance(transform.position, obj.transform.position);

            // If the distance is less than the threshold, print the object's name
            if (distance < distanceFromObject)
            {
                switch (obj.name)
                {
                    case "Ivy":
                        can = can - 2;
                        break;
                    case "Akrep":
                        can--;
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
