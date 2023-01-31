using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgacKontrol : MonoBehaviour
{
    public GameObject player;
    public float hiz;    
    private void Update()
    {
        transform.position += Vector3.left * hiz * Time.deltaTime;           
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Player"))
        {

        }
    }

}
