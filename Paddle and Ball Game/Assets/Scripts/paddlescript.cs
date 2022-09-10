using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlescript : MonoBehaviour
{
    public int speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
    }

    void move() => rb.velocity = new Vector2(Input.GetAxis("Horizontal")*speed,0f);
}
