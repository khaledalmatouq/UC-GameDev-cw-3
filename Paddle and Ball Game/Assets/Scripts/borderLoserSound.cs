using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borderLoserSound : MonoBehaviour
{

    AudioSource src;

    
    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        src.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }


}
