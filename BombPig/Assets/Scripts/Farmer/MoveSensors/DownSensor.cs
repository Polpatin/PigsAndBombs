using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sensors;
public class DownSensor : MonoBehaviour
{
    public static bool isDownPathEmty = true;

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
        isDownPathEmty = false;
    }
}
