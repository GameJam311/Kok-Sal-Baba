using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
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
    public float distanceFromObject = 2f;
    int ziplamaSayac = 0;
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
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            karakterZeminde = true;
            ziplamaSayac = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            karakterZeminde = false;
        }
    }
    void AttackControl()
    {
        /***************************************************************************************\
         * Sayin hocam, olay su : Eger sag ya da sol mouse tik alirsa ilk kontrol yakin         *
         * cevrede dusman olup olmadiginaa bakmak olacak. Eger varsa dusman tipine göre zarar   *
         * verecek yoksa sadece animation oynatacak. Bu sebeple tum dusman objelerini kontrol   *
         * etmek yerine sadece karakterinn etrafýndaki objeleri kontrol ettik.                  *
        /***************************************************************************************/
        // Find all objects in the scene

        if (Input.GetMouseButtonDown(0))
        {

            aSource.PlayOneShot(knife, 1f);
            playerAnimator.SetBool("isAttacking", true);
            GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

            // Iterate through all objects
            foreach (GameObject obj in allObjects)
            {
                // Calculate the distance between the main character and the current object
                float distance = Vector2.Distance(transform.position, obj.transform.position);

                // If the distance is less than the threshold, print the object's name
                if (distance < distanceFromObject)
                {
                    switch (obj.name)
                    {
                        case "Ivy":
                            Destroy(obj);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        else
        {
            playerAnimator.SetBool("isAttacking", false);
        }
    }
}
