using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Anger;
public class FarmerInDirt : MonoBehaviour
{
    public Sprite standUp;
    public Sprite standDown;
    public Sprite standLeft;
    public Sprite standRight;
    private SpriteRenderer dirtySprite;
    public FarmerMoove moveScript;
    public FarmerAnger angerScript;

    

    string standDirection;

   public bool isDirtOnBody = false;
    float timeInDirt = 6;
    // Start is called before the first frame update
    void Start()
    {
        dirtySprite = GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        standDirection = moveScript.curentDirection;
        StandOnDirt();
        Debug.Log("DirtData " +"Anger: "+ angerScript.pigStaticLocation +" Move: "+ moveScript.curentDirection + " Is Dirty: " + isDirtOnBody+" StandDirection:  "+standDirection);
       if (timeInDirt<=1)
        {
            
            isDirtOnBody = false;
            moveScript.enabled = true;
            angerScript.enabled = true;
            timeInDirt = 6;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb")
        {
            isDirtOnBody = true;
            timeInDirt = 6;
       
        }
    }
    void StandOnDirt()
    {
        if (isDirtOnBody == true)
        {
           
            ChangeOnDirtySprite();
            timeInDirt -= timeInDirt*Time.deltaTime;
            moveScript.enabled = false;
            angerScript.enabled = false;

        }
    }
    void ChangeOnDirtySprite()
    {
        if (angerScript.pigStaticLocation !=null)
        {
            if (angerScript.pigStaticLocation != "emty")
            {
                switch (angerScript.pigStaticLocation)
                {
                    case "runUp":
                        dirtySprite.sprite = standUp;
                        break;
                    case "runDown":
                        dirtySprite.sprite = standDown;
                        break;
                    case "runLeft":
                        dirtySprite.sprite = standLeft;
                        break;
                    case "runRight":
                        dirtySprite.sprite = standRight;
                        break;
                }

            }
        }
        if (standDirection != null)
        {
            if (standDirection != null)
            {
                if (standDirection == "up")
                {
                    dirtySprite.sprite = standUp;

                }
                else if (standDirection == "down")
                {
                    dirtySprite.sprite = standDown;

                }
                else if (standDirection == "right")
                {
                    dirtySprite.sprite = standRight;

                }
                else if (standDirection == "left")
                {
                    dirtySprite.sprite = standLeft;

                }
            }
        }
    }
    
}