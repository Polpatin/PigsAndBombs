﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sensors;
public class LeftSensor : MonoBehaviour
{
    public static bool isLeftPathEmty = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        isLeftPathEmty = false;
    }
}
