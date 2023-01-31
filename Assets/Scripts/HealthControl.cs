using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthControl : MonoBehaviour
{
    public GameObject kalp1, kalp2, kalp3,yarýmKalp1,yarýmKalp2,yarýmKalp3,bosKalp1,bosKalp2,bosKalp3;
    private int can = 8;   
    void Update()
    {
        KalpKontrol();
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
        can --;
    }
}
