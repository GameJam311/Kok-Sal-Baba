using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kalp : MonoBehaviour
{
    public GameObject kalp1, kalp2, kalp3, yarimKalp1, yarimKalp2, yarmKalp3, bosKalp1, bosKalp2, bosKalp3;
    private int can = 7;
    public Animator anim;

    public void start()
    {
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (can == 1)
        {
            kalp1.SetActive(false);
            kalp2.SetActive(false);
            kalp3.SetActive(false);
            yarimKalp1.SetActive(false);
            yarimKalp2.SetActive(false);
            yarmKalp3.SetActive(false);
            bosKalp1.SetActive(true);
            bosKalp2.SetActive(true);
            bosKalp3.SetActive(true);
            SceneManager.LoadScene("GameOver");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && !collision.gameObject.GetComponent<Animator>().GetBool("isDead"))
        {
           
            can--;
            if (can == 7)
            {
                kalp1.SetActive(true);
                kalp2.SetActive(true);
                kalp3.SetActive(true);
                yarimKalp1.SetActive(false);
                yarimKalp2.SetActive(false);
                yarmKalp3.SetActive(false);
                bosKalp1.SetActive(false);
                bosKalp2.SetActive(false);
                bosKalp3.SetActive(false);
            }
            if (can == 6)
            {
                kalp1.SetActive(true);
                kalp2.SetActive(true);
                kalp3.SetActive(false);
                yarimKalp1.SetActive(false);
                yarimKalp2.SetActive(false);
                yarmKalp3.SetActive(true);
                bosKalp1.SetActive(false);
                bosKalp2.SetActive(false);
                bosKalp3.SetActive(false);
            }
            if (can == 5)
            {
                kalp1.SetActive(true);
                kalp2.SetActive(true);
                kalp3.SetActive(false);
                yarimKalp1.SetActive(false);
                yarimKalp2.SetActive(false);
                yarmKalp3.SetActive(false);
                bosKalp1.SetActive(false);
                bosKalp2.SetActive(false);
                bosKalp3.SetActive(true);
            }
            if (can == 4)
            {
                kalp1.SetActive(true);
                kalp2.SetActive(false);
                kalp3.SetActive(false);
                yarimKalp1.SetActive(false);
                yarimKalp2.SetActive(true);
                yarmKalp3.SetActive(false);
                bosKalp1.SetActive(false);
                bosKalp2.SetActive(false);
                bosKalp3.SetActive(true);
            }
            if (can == 3)
            {
                kalp1.SetActive(true);
                kalp2.SetActive(false);
                kalp3.SetActive(false);
                yarimKalp1.SetActive(false);
                yarimKalp2.SetActive(false);
                yarmKalp3.SetActive(false);
                bosKalp1.SetActive(false);
                bosKalp2.SetActive(true);
                bosKalp3.SetActive(true);
            }
            if (can == 2)
            {
                kalp1.SetActive(false);
                kalp2.SetActive(false);
                kalp3.SetActive(false);
                yarimKalp1.SetActive(true);
                yarimKalp2.SetActive(false);
                yarmKalp3.SetActive(false);
                bosKalp1.SetActive(false);
                bosKalp2.SetActive(true);
                bosKalp3.SetActive(true);
            }
        }
    }
}
