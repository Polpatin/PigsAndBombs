using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstalBomb : MonoBehaviour
{
    public GameObject BombPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
                Instantiate(BombPrefab, transform.position, BombPrefab.transform.rotation);
                
            
        }
    }
}
