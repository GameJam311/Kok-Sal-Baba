using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DüşmanLoop : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(-1 * speed * Time.deltaTime, 0.0f, 0.0f);
    }
}
