using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardKontroll : MonoBehaviour
{
    private float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float directionX = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * directionX * Time.deltaTime * speed);
        float directionY = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * directionY * Time.deltaTime * speed);


    }
}
