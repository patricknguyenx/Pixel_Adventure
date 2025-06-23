using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerRespawn : MonoBehaviour
{
    public static Vector3 lastCheckpointPos;
    private Vector3 startPos;
    public Animator anim;
    public mover movement;
    public bool dead;
    void Start()
    {
        // N?u ch?a có checkpoint, dùng v? trí g?c ban ??u
        startPos = transform.position;
        if (lastCheckpointPos == Vector3.zero)
        {
            lastCheckpointPos = startPos;
        }
        dead = false;
    }
    
    public void Respawn()
    {
        // D?ch chuy?n player v? checkpoint ?ã l?u
        transform.position = lastCheckpointPos;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R) && !movement.allowMovement)
        {
            Respawn();
            movement.allowMovement = true;
            anim.SetBool("hit", false);
            dead = true;
        }
    }
}
