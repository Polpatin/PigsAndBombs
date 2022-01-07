using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Anger;
public class RightPigDetector : MonoBehaviour
{
    public FarmerAnger angerScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pig")
        {
            angerScript.pigStaticLocation = "right";
        }
    }
}
