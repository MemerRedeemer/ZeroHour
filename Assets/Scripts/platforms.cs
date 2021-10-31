using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platforms : MonoBehaviour {
    public GameObject platform;
    public GameObject gear;
    float targetTimer;

    void Start() {
        float randomX = Random.Range(0, 14) - 7;
        Instantiate(platform, new Vector3(randomX, -5, 0), Quaternion.identity);
        Instantiate(gear, new Vector3(randomX, -5, 0), Quaternion.identity);
    }

    void Update() {
        if(targetTimer > 0) {
            targetTimer -= Time.deltaTime;
        } else {
            float randomX = Random.Range(0, 14) - 7;
            targetTimer = 2;
            Instantiate(platform, new Vector3(randomX, -10, 0), Quaternion.identity);
            float randomSpawn = Random.Range(0, 100);
            if(randomSpawn < 50) {
                Instantiate(gear, new Vector3(randomX, -10, 0), Quaternion.identity);
            }
        }
    }
}
