using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(GameControl.instance.scrollSpeed, 0);
    }

    void Update()
    {
        if(GameControl.instance.gameOver == true)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
