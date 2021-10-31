using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    Rigidbody2D rbgd;
    SpriteRenderer sprite;
    public GameObject uiManager;
    score ui;
    float speed = 6;
    float posY;

    void Start() {
        rbgd = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        ui = uiManager.GetComponent<score>();
    }

    void Update() {
        float posX = Input.GetAxis("Horizontal") * speed;

        if(Input.GetKey(KeyCode.A)) {
            sprite.flipX = true;
        }
        if(Input.GetKey(KeyCode.D)) {
            sprite.flipX = false;
        }
        if(Input.GetKey(KeyCode.R)) {
            Time.timeScale = 1;
            SceneManager.LoadScene("Game");
        }

        posY = rbgd.velocity.y;
        rbgd.velocity = new Vector2(posX, posY);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "death") {
            ui.Death(true);
        }
        if(collision.gameObject.tag == "gear") {
            ui.AddScore();
        }
    }
}
