using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitGround : MonoBehaviour
{
    public bool is_hitGround;
    void Start()
    {
        is_hitGround = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.CompareTag("ground"))
        {
            is_hitGround = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)

    {
        if (collision.gameObject.CompareTag("ground"))
        {
            is_hitGround = false;
        }
    }

}
