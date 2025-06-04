using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Animator anim;
    public bool is_hitTrap = false;
    public mover movement;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            is_hitTrap = true;
            anim.SetBool("hit", true);
            movement.allowMovement = false;
        }
    }
    
        


    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<mover>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
