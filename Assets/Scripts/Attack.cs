using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy") && Input.GetMouseButtonDown(0))
        {
            collision.gameObject.GetComponent<Animator>().SetBool("isDead", true);
            Destroy(collision.gameObject);
        }
    }
}
