﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public static int camerazero = 1;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
      
        if (camerazero == 0)
       {
          speed = 0f;
            camerazero = 1;
        }

    }

}
