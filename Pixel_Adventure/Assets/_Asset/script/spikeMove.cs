using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeMove : MonoBehaviour
{

    public Vector2 direction = Vector2.up;
    public float distance = 1f;
    public float speed = 1f;

    private Vector2 startPos;
    private float moved = 0f;
    public activeTrap activeTrap;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (activeTrap.activetrap == true)
        {
            if (moved < distance)
            {
                float step = speed * Time.deltaTime;
                transform.Translate(direction.normalized * step);
                moved += step;
            }
        }
        
    }
}
