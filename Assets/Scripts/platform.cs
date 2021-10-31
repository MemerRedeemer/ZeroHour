using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    float posY;
    Rigidbody2D rgbdPlatform;
    public GameObject gear;
    float platformScroll;

    void Start() 
    {
        rgbdPlatform = GetComponent<Rigidbody2D>();
        posY = -5;
        platformScroll = 0.02f;
        Instantiate(gear, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        posY += platformScroll;

        rgbdPlatform.transform.position = new Vector2(0, posY);

        if (rgbdPlatform.position.y > 12)
        {
            Destroy(gameObject);
        }
    }



}
