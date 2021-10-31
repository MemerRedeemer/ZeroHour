using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greasy: MonoBehaviour {
    Rigidbody2D rgbdGear;
    float gearScroll = 3;

    void Start() {
        rgbdGear = GetComponent<Rigidbody2D>();
    }

   
    void Update() {
        rgbdGear.velocity = new Vector2(0, gearScroll);

        if (rgbdGear.position.y > 12)
        {
            Destroy(gameObject);
        }
    }
}
