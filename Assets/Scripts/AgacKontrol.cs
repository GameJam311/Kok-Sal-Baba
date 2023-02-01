using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgacKontrol : MonoBehaviour
{
    public GameObject player;
    Animator anim;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("girdi");
        if (gameObject.CompareTag("Player"))
        {
            anim.SetBool("yakalad", true);
        }
    }



}
