﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector2 startPos;
    private float repeathWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeathWidth = 95.27f;
    }

    // Update is called once per frame
    void Update()
    {
       if (transform.position.x < - repeathWidth)
        {
            transform.position = startPos;
        }
    }
}
