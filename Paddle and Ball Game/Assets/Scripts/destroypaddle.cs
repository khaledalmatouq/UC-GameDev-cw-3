using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroypaddle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
