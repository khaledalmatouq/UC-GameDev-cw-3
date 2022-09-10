using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalScript : MonoBehaviour
{

    AudioSource src;

    Rigidbody2D rb;
    public float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb;

        src = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        src.Play();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
    }

}
