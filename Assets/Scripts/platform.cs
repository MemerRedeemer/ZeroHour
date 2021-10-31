using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour {
    Rigidbody2D rgbdPlatform;
    float platformScroll = 3;

    void Start() {
        rgbdPlatform = GetComponent<Rigidbody2D>();
    }

    void Update() {

        rgbdPlatform.velocity = new Vector2(0, platformScroll);

        if (rgbdPlatform.position.y > 12) {
            Destroy(gameObject);
        }
    }



}
