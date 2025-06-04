using System.Collections;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float speed;
    public Animator anim;
    public Rigidbody2D rb;
    public int jump;
    public float jumpForce1 = 5f;
    public float jumpForce2 = 7f;
    public hitGround hitGround;
    public bool allowMovement = true;
    
    private bool isCoroutineRunning = false;  // để tránh gọi Coroutine liên tục

    void Start()
    {
        jump = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (allowMovement)
        {

            float Horizontal = Input.GetAxisRaw("Horizontal");

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

            if (Input.GetKeyDown(KeyCode.Space))
            {
                jump++;
                hitGround.is_hitGround = false;
                if (jump == 1)
                {
                    anim.SetInteger("jump", 1);
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce1);
                    Debug.Log($"0{jump}");
                }
                else if (jump == 2)
                {
                    anim.SetInteger("jump", 2);
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce2);
                    Debug.Log($"1{jump}");
                }
            }

            if (hitGround.is_hitGround == true && jump != 0)
            {
                if (!isCoroutineRunning)
                {
                    StartCoroutine(ResetJumpAfterDelay());
                }
            }
        

        IEnumerator ResetJumpAfterDelay()
        {
            isCoroutineRunning = true;
            yield return new WaitForSeconds(0.2f);

            anim.SetInteger("jump", 0);
            jump = 0;
            Debug.Log($"2{jump}");

            isCoroutineRunning = false;
        }
    }

    else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
