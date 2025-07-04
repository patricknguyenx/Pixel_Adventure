using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class win : MonoBehaviour
{
    public UnityEvent eventwin;

    public void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.CompareTag("End"))
        {
            eventwin.Invoke();
        }
    }
}
