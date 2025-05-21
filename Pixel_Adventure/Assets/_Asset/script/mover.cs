using System.Collections;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using Unity.Mathematics;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public Animator anim;
    public Rigidbody2D rb;
    public int jump = 0;

    public hitGround hitGround;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        float Horizontal = Input.GetAxisRaw("Horizontal");

        // Debug.Log($"{Horizontal}");
        rb.velocity = new Vector2(speed * Horizontal, rb.velocity.y);
        anim.SetFloat("mover", Mathf.Abs(Horizontal));
        if (Horizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Horizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180f, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            jump = 1;
            if (Input.GetKey(KeyCode.Space))
            {
                jump = 2;
                if (hitGround.is_hitGround==true)
                {
                    jump = 0;
                }
            }
            else if (hitGround.is_hitGround==true)
            {
                jump = 0;
            }

        }


    }
}
