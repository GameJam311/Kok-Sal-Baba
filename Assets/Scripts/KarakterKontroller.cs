using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class KarakterKontroller : MonoBehaviour
{
    Rigidbody2D rb;
    AudioSource aSource;
    public Animator playerAnimator;
    public AudioClip knife;
    public float hiz;
    public float ziplama;
    public bool karakterZeminde;
    public float distanceFromObject = 100f;
    int ziplamaSayac = 0;
    float saldiriSayaci = 0;
    public float timer = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        aSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        AttackControl();
        float yatay = Input.GetAxis("Horizontal");
        Vector2 hareket = new Vector3(yatay * hiz * 50 * Time.deltaTime, 0);
        rb.AddForce(hareket);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ziplamaSayac < 2)
            {
                rb.velocity = Vector2.up * ziplama;
                ziplamaSayac++;
            }
        }
        SetTransformY(-4.5f);
    }
    void AttackControl()
    {
        if(Input.GetMouseButtonDown(0))
        {
            playerAnimator.SetTrigger("isAttack");
            aSource.PlayOneShot(knife, 1f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            karakterZeminde = true;
            ziplamaSayac = 0;
            playerAnimator.SetBool("jump", false);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            karakterZeminde = false;
            playerAnimator.SetBool("jump",true);
        }
    }
    
    void SetTransformY(float x)//sadece y eksenini kontrol eder
    {
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
        //degistirmek istemediginiz degerlere "transform.position" ifadesi girin
    }
}
