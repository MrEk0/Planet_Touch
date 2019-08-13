using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour, IClickable
{
    Rigidbody2D rd2;
    TextUI text;
    Vector3 clickPosition;
    bool isClicked = false;

    float speed = 2f;

    private void Awake()
    {
        rd2 = GetComponent<Rigidbody2D>();
        text = FindObjectOfType<TextUI>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Click();
        }
        if(isClicked)
        transform.position = Vector2.MoveTowards(transform.position, clickPosition, speed * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Platform"))
        {
            text.ChangeScore();
        }
    }

    public void Click()
    {
        clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        clickPosition.z = transform.position.z;
        isClicked = true;
    }
}
