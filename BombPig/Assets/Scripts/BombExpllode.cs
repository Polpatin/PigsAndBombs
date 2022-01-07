using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExpllode : MonoBehaviour
{
    public Sprite ExplodeFire;
    CircleCollider2D ExplosionRange;
    private SpriteRenderer currentSprite;
    float explosionTime=5.5f;
    bool isBombRedy = false;
    // Start is called before the first frame update
    void Start()
    {
       
        ExplosionRange = GetComponent<CircleCollider2D>();
        ExplosionRange.enabled = false;
        InvokeRepeating("Explosion", 3f, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isBombRedy == true)
        {
            currentSprite = GetComponent<SpriteRenderer>();
            currentSprite.sprite = ExplodeFire;
            ExplosionRange.enabled = true;
            //explosionTime -= explosionTime * Time.deltaTime*1;
            explosionTime--;
            if (explosionTime <= 0.1f)
                Destroy(gameObject);
        }
    }
    void Explosion()
    {
        isBombRedy = true;
    }
}
