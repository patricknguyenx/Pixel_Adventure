using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class movingGroundX : MonoBehaviour
{
    public float amplitude;
    public float groundSpeed;
    private Vector3 startPos;

    public UnityEvent mover_groud;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        mover_groud.Invoke();
    }

    public void mover_up_down()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * groundSpeed) * amplitude;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
    public void mover_left_right()
    {
        float newX = startPos.x - Mathf.Sin(Time.time * groundSpeed) * amplitude;
        transform.position = new Vector3(newX, startPos.y, startPos.z);
    }

}
