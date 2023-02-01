using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameoverLoad : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim.SetTrigger("load");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
