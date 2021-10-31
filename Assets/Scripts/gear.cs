using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear : MonoBehaviour
{
    float posY;
    Rigidbody2D rgbdGear;
    float platformScroll;

    void Start()
    {
        rgbdGear = GetComponent<Rigidbody2D>();
        posY = -4;
        platformScroll = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        posY += platformScroll;

        rgbdGear.transform.position = new Vector2(0, posY);

        if (rgbdGear.position.y > 12)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
