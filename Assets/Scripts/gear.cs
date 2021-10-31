using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear : MonoBehaviour
{
    float posY;
    float posX;
    float gearScroll;

    void Start()
    {
        gearScroll = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        posY += 0.02f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
