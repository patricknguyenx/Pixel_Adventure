using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeheadMove : MonoBehaviour
{
    public float amplitude ;   
    public float shspeed ;       
    private Vector3 startPos;
    public activeTrap activeTrap;
    public playerRespawn playerReset;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (activeTrap.activetrap == true)
        {
            float newY = startPos.y + Mathf.Sin(Time.time * shspeed) * amplitude;
            transform.position = new Vector3(startPos.x, newY, startPos.z);
        }
        if (activeTrap.activetrap == true && playerReset.dead)
        {
            float newY = startPos.y - Mathf.Sin(Time.time * shspeed) * amplitude;
            transform.position = new Vector3(startPos.x, newY, startPos.z);
        }
    }
}
