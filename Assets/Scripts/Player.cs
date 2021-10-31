using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rbgd;
    SpriteRenderer sprite;
    float speed = 800;
    float posY, gravity;
    bool death;

    void Start() {
        rbgd = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update() {
        float posX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        if(Input.GetKey(KeyCode.A)) {
            sprite.flipX = true;
        }
        if(Input.GetKey(KeyCode.D)) {
            sprite.flipX = false;
        }



        posY = rbgd.velocity.y;
        rbgd.velocity = new Vector2(posX, posY);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "death") {
            death = true;
        }
    }
}
