using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeTrap : MonoBehaviour
{
    public bool activetrap;
    // Start is called before the first frame update
    void Start()
    {
        activetrap = false;
    }

  
    
    public void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.CompareTag("Player"))
        {

            activetrap = true;
        }
    }


}

