using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class birdSip : MonoBehaviour
{

    public GameObject target;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            timer += Time.deltaTime;
            transform.RotateAround(target.transform.position, Vector3.right, 0.5f * (float) Math.Cos(timer * 20 / Mathf.PI));
        }
    }
}
