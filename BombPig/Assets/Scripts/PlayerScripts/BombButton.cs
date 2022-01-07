using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombButton : MonoBehaviour
{
    public GameObject Player;
    public GameObject BpmbPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InstallBomb()
    {
        Instantiate(BpmbPrefab, Player.transform.position, BpmbPrefab.transform.rotation);
    }
}
