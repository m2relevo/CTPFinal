﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour

{
    public int speed;

    // Use this for initialization
    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position -= new Vector3(0f, speed * Time.deltaTime, 0f);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            }
        }
    }
}
