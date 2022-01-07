using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sensors;
using Anger;
public class FarmerMoove : MonoBehaviour
{
    float speed=2f;
    float timeOfMoving;
    string[] directionOfMove= { "up","down","left","right"};
    static public bool  isMovingStarted = false;
    public  string curentDirection;


    public Sprite goUp;
    public Sprite goDown;
    public Sprite goLeft;
    public Sprite goRight;
    private SpriteRenderer currentSprite;
    // Start is called before the first frame update
    void Start()
    {
        currentSprite = GetComponent<SpriteRenderer>();
        InvokeRepeating("ChangeTimeOfMooving", 1, 1);
        InvokeRepeating("StartMoving", 1, timeOfMoving);
    }

    // Update is called once per frame
    void Update()
    {
        FarmerMooving();
    }
    void FarmerMooving()
    {
        if (isMovingStarted == true)
        {
            
            ResetSensors();
          //  Debug.Log(curentDirection);
            if (curentDirection == "up")
            {
                currentSprite.sprite = goUp;
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }

            else if (curentDirection == "down")
            {
                currentSprite.sprite = goDown;
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            }
            else if (curentDirection == "left")
            {
                currentSprite.sprite = goLeft;
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
            else if (curentDirection == "right")
            {
                currentSprite.sprite = goRight;
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }
    }
    void ResetSensors()
    {
        UpSensor.isUpPathEmty = true;
        DownSensor.isDownPathEmty = true;
        LeftSensor.isLeftPathEmty = true;
        RightSensor.isRightPathEmty = true;
    }
    void ChangeTimeOfMooving()
    {
        timeOfMoving = Random.Range(1, 5);
        int index = Random.Range(0, 4);
        curentDirection = directionOfMove[index];

    }
    void StartMoving()
    {
        isMovingStarted = true;
       
    }
   
}
