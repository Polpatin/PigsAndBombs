using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Anger
{
    public class FarmerAnger : MonoBehaviour
    {
        public Sprite runUp;
        public Sprite runDown;
        public Sprite runLeft;
        public Sprite runRight;
        private SpriteRenderer currentRuningSprite;
        public FarmerMoove moveScript;

       public  string pigStaticLocation;
        float speed=5f;
        int runTime = 15;
        // Start is called before the first frame update
        void Start()
        {
            currentRuningSprite = GetComponent<SpriteRenderer>();

        }

        // Update is called once per frame
        void Update()
        {
            FarmerSawThePig();

            if(runTime<=0)
            {
                
                 pigStaticLocation = "emty";
                runTime = 4;
                moveScript.enabled = true;
            }
        }
        void FarmerSawThePig()
        {
            if (pigStaticLocation == "top")
            {
                currentRuningSprite.sprite = runUp;

                Debug.Log("I see the pig " + pigStaticLocation);
                moveScript.enabled = false;
                RunUpAfterThePig();
            }
            else if (pigStaticLocation == "down")
            {
                currentRuningSprite.sprite = runDown;

                Debug.Log("I see the pig " + pigStaticLocation);
                moveScript.enabled = false;

                RunDownAfterThePig();
            }
            else if (pigStaticLocation == "left")
            {
                currentRuningSprite.sprite = runLeft;

                Debug.Log("I see the pig " + pigStaticLocation);
                moveScript.enabled = false;

                RunLeftAfterThePig();
            }
            else if (pigStaticLocation == "right")
            {
                currentRuningSprite.sprite = runRight;

                Debug.Log("I see the pig " + pigStaticLocation);
                moveScript.enabled = false;

                RunRightAfterThePig();
            }
            

        }
        void RunUpAfterThePig()
        {
           
            if(runTime >= 0)
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
                runTime--;
            }
        }
        void RunDownAfterThePig()
        {

            if (runTime >= 0)
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
                runTime--;
            }
        }
        void RunLeftAfterThePig()
        {

            if (runTime >= 0)
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                runTime--;
            }
        }
        void RunRightAfterThePig()
        {

            if (runTime >= 0)
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                runTime--;
            }
        }
        

    }
}