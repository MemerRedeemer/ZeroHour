using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gears : MonoBehaviour
{
    public GameObject gear;
    float targetTimer = 1;

    void Update()

    {
        if (targetTimer > 0)
        {
            targetTimer -= Time.deltaTime;
        }
        else
        {
            targetTimer = 1;
            Instantiate(gear, new Vector3(0, -5, 0), Quaternion.identity);
        }
    }
}
