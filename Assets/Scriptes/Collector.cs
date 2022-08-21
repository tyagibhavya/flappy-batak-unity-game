using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void Start()
    {
        transform.position.Set(-6, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)  
    {
        if(collision.gameObject.CompareTag("Obstracle"))
        {
            Destroy(collision.gameObject);
        }
    }
}
