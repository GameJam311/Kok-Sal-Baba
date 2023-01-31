using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    void Start()
    {
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            enemy.SetActive(false);
        }
        if (collision.CompareTag("Enemy1"))
        {
            enemy.SetActive(false);
        }
        if (collision.CompareTag("Enemy2"))
        {
            enemy.SetActive(false);
        }
        if (collision.CompareTag("Enemy3"))
        {
            enemy.SetActive(false);
        }
    }
}
