﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovepScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Holizontal")*Time.deltaTime, 0f, 0f);
        Debug.Log(transform.position.x);
    }
}
