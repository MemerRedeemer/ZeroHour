using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    Rigidbody2D rbgd;
    SpriteRenderer sprite;
    [SerializeField] GameObject uiManager;
    score ui;
    AudioSource audioSource;
    [SerializeField] AudioClip fall;
    [SerializeField] AudioClip land;
    [SerializeField] AudioClip oiledgear;
    [SerializeField] Animator anim;
    float speed = 6;
    float posY;
    float targetTimer = 0.05f;

    void Start() {
        rbgd = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        ui = uiManager.GetComponent<score>();
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
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

        if (collision.gameObject.tag == "death") {
            ui.Death(true);
        }
        if(collision.gameObject.tag == "gear") {
            ui.AddScore();
        }
        if(collision.gameObject.tag == "greased") {
            if(!audioSource.isPlaying) {
                audioSource.PlayOneShot(oiledgear);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        audioSource.PlayOneShot(land);
        anim.Play("land");
        anim.Play("idle");
    }

    private void OnCollisionExit2D(Collision2D collision) {
        audioSource.pitch = Random.Range(0.9f, 1.1f);
        audioSource.PlayOneShot(fall);
    }
}
