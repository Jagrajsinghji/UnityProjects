﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour
{
    Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = new Vector3(150,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(movement*Time.deltaTime);
    }
}
