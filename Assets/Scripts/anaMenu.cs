using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anaMenu : MonoBehaviour
{
    public Animator animator;
    public GameObject panel;
    float sayac = 0;
    bool start=false;
    private void Update()
    {
        Sayac();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Enter", true);
            start= true;
        }       
    }
    void Sayac()
    {
        if (start)
        {
            sayac += Time.deltaTime;
        }
        if (sayac > 2.5)
        {
            panel.SetActive(false);
        }
    }
}
