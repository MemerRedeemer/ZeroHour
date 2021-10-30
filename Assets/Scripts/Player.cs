using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rbgd;
    float speed = 200;

    void Start() {
        rbgd = GetComponent<Rigidbody2D>();
    }

    void Update() {
        //Vector3 point = new Vector3(Input.mousePosition.x, Input.mousePosition.y, +10);
        float posX = Input.GetAxis("Horizontal");
        float posY = Input.GetAxis("Vertical");

        Vector2 pos = new Vector2(posX, posY) * Time.deltaTime * speed;

        Vector2 point = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        float rotationZ = Mathf.Atan2(Input.mousePosition.x, Input.mousePosition.y);

        rbgd.transform.rotation = Quaternion.Euler(0, 0, rotationZ);
        rbgd.velocity = pos;

    }
}
