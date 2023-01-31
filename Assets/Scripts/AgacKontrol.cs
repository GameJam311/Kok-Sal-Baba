using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgacKontrol : MonoBehaviour
{
    
    public float hiz;
    
    private void Update()
    {
        transform.position += Vector3.left * hiz * Time.deltaTime;
            
    }
}
