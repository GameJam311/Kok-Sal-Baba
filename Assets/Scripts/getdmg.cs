using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getdmg : MonoBehaviour
{
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            player.GetComponent<Animator>().SetBool("ishurt", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            player.GetComponent<Animator>().SetBool("ishurt", false);
        }
    }
}
