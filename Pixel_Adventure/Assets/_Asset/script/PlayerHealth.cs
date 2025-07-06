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

    IEnumerator DelayCount()
    {
        yield return new WaitForSeconds(1f);  // Delay 1 giây m?i cho ??m ti?p
        eventdie.Invoke();
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
