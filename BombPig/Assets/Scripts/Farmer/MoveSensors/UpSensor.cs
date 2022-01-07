using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Sensors
{
    public class UpSensor : MonoBehaviour
    {
        public static bool isUpPathEmty = true;
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
            isUpPathEmty = false;
            Debug.Log("No path");
        }

    }
}