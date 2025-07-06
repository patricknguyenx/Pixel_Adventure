using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class playerRespawn : MonoBehaviour
{
    public static Vector3 lastCheckpointPos;
    private Vector3 startPos;
    public Animator anim;
    public mover movement;


    void Start()
    {
        startPos = transform.position;
        if (lastCheckpointPos == Vector3.zero)
        {
            lastCheckpointPos = startPos;
            
        }

    }

    public void Respawn()
    {
        transform.position = lastCheckpointPos;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R) )
        {
            reset();
        }
    }
    public void reset()
    {
        Respawn();
        movement.allowMovement = true;
        anim.SetBool("hit", false);
    }
}
