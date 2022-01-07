using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class UpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Sprite runUp;


    public GameObject PlayerPig;
    private bool isButtonPressed = false;
    private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        if (isButtonPressed == true)
        {
            PlayerPig.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isButtonPressed == true)
        {
            PlayerPig.GetComponent<SpriteRenderer>().sprite = runUp;

            PlayerPig.transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isButtonPressed = true;

    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isButtonPressed = false;

    }
}
