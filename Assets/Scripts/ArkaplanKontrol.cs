using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaplanKontrol : MonoBehaviour
{
    public GameObject cam;
    public float speed=1, gorselKose = 15;
    void Update()
    {
        ArkaPlanHareketi();
    }
    void ArkaPlanHareketi()//arkaplani ilerletir loopa sokar
    {
        transform.Translate(-1 * speed * Time.deltaTime, 0.0f, 0.0f);

        if (cam.transform.position.x >= transform.position.x + gorselKose)
        {
            transform.position = new Vector2(cam.transform.position.x +gorselKose, transform.position.y);
        }
    }
}
