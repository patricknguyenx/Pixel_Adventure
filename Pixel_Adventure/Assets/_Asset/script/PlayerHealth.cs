using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public Animator anim;
    public bool is_hitTrap = false;
    public mover movement;
    public UnityEvent eventdie;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            is_hitTrap = true;
            anim.SetBool("hit", true);
            movement.allowMovement = false;
            eventdie.Invoke();
          
        }
    }


    void Start()
    {
        movement = GetComponent<mover>();
    }

}
