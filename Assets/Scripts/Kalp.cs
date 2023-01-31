using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Kalp : MonoBehaviour
{
    public GameObject kalp1, kalp2, kalp3, yar�mKalp1, yar�mKalp2, yar�mKalp3, bosKalp1, bosKalp2, bosKalp3;
    private int can = 7;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            can--;
            if (can == 7)
            {
                kalp1.SetActive(true);
                kalp2.SetActive(true);
                kalp3.SetActive(true);
                yar�mKalp1.SetActive(false);
                yar�mKalp2.SetActive(false);
                yar�mKalp3.SetActive(false);
                bosKalp1.SetActive(false);
                bosKalp2.SetActive(false);
                bosKalp3.SetActive(false);
            }
            if (can == 6)
            {
                kalp1.SetActive(true);
                kalp2.SetActive(true);
                kalp3.SetActive(false);
                yar�mKalp1.SetActive(false);
                yar�mKalp2.SetActive(false);
                yar�mKalp3.SetActive(true);
                bosKalp1.SetActive(false);
                bosKalp2.SetActive(false);
                bosKalp3.SetActive(false);
            }
            if (can == 5)
            {
                kalp1.SetActive(true);
                kalp2.SetActive(true);
                kalp3.SetActive(false);
                yar�mKalp1.SetActive(false);
                yar�mKalp2.SetActive(false);
                yar�mKalp3.SetActive(false);
                bosKalp1.SetActive(false);
                bosKalp2.SetActive(false);
                bosKalp3.SetActive(true);
            }
            if (can == 4)
            {
                kalp1.SetActive(true);
                kalp2.SetActive(false);
                kalp3.SetActive(false);
                yar�mKalp1.SetActive(false);
                yar�mKalp2.SetActive(true);
                yar�mKalp3.SetActive(false);
                bosKalp1.SetActive(false);
                bosKalp2.SetActive(false);
                bosKalp3.SetActive(true);
            }
            if (can == 3)
            {
                kalp1.SetActive(true);
                kalp2.SetActive(false);
                kalp3.SetActive(false);
                yar�mKalp1.SetActive(false);
                yar�mKalp2.SetActive(false);
                yar�mKalp3.SetActive(false);
                bosKalp1.SetActive(false);
                bosKalp2.SetActive(true);
                bosKalp3.SetActive(true);
            }
            if (can == 2)
            {
                kalp1.SetActive(false);
                kalp2.SetActive(false);
                kalp3.SetActive(false);
                yar�mKalp1.SetActive(true);
                yar�mKalp2.SetActive(false);
                yar�mKalp3.SetActive(false);
                bosKalp1.SetActive(false);
                bosKalp2.SetActive(true);
                bosKalp3.SetActive(true);
            }
            if (can == 1)
            {
                kalp1.SetActive(false);
                kalp2.SetActive(false);
                kalp3.SetActive(false);
                yar�mKalp1.SetActive(false);
                yar�mKalp2.SetActive(false);
                yar�mKalp3.SetActive(false);
                bosKalp1.SetActive(true);
                bosKalp2.SetActive(true);
                bosKalp3.SetActive(true);
            }
        }
    }
}
