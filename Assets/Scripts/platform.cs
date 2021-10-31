using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    float posY;
    Rigidbody2D rgbd;

    void Start() {
        rgbd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        posY -= 1;

        rgbd.transform.position = new Vector2(0, posY);
    }
}
