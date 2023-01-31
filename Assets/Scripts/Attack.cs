using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public ParticleSystem parcalanma;
    public Transform hedef;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && Input.GetMouseButtonDown(0))
        {
            Destroy(collision.gameObject);
            ParticleSystem go = Instantiate(parcalanma, transform.position, transform.rotation) as ParticleSystem;
            Destroy(go, 1);
        }
    }
}
