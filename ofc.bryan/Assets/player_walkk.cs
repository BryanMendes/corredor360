﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_walkk : MonoBehaviour
{
    public int playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * Time.deltaTime * playerSpeed;
        }
    }
}
