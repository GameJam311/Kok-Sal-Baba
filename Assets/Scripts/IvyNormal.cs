using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IvyNormal : MonoBehaviour
{
    public float growthSpeed;
    public GameObject Ivy;
    public float timer;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Ivy.SetActive(true);       
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Ivy.transform.localScale += new Vector3(0, growthSpeed * Time.deltaTime, 0);
        timer += Time.deltaTime;
        if(timer >= 3f)
        {
            growthSpeed = 0f;
            timer = 0;
        }
    }
}
