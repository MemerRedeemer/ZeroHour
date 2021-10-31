using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rbgd;
    float speed = 800;
    float posY, gravity;
    bool groundDetect = true;

    void Start() {
        rbgd = GetComponent<Rigidbody2D>();
    }

    void Update() {
        float posX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;


        rbgd.velocity = new Vector2(posX, posY);
    }
}
