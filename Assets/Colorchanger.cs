﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchanger : MonoBehaviour
{

    public SpriteRenderer rend;
    public Color color;

    // Use this for initialization
    void Start()
    {
        rend.color = color;
        //transform.position = new Vector3(-5f, transform.position.y);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(7.5f * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, 0, 180f * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(-5f * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, 0, -180f * Time.deltaTime);
    }
}
