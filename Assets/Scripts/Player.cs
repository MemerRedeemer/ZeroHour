using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    Rigidbody2D rbgd;
    SpriteRenderer sprite;
    public GameObject uiManager;
    score ui;
    AudioSource audioSource;
    public AudioClip fall;
    public AudioClip land;
    public AudioClip oiledgear;
    float speed = 6;
    float posY;

    void Start() {
        rbgd = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        ui = uiManager.GetComponent<score>();
        audioSource = GetComponent<AudioSource>();
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
            if (!audioSource.isPlaying)
            {
                audioSource.PlayOneShot(oiledgear);
            }
          }
        
           
        
        
            
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(land);
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        audioSource.pitch = Random.Range(0.9f, 1.1f);
        audioSource.PlayOneShot(fall);
    }
}
