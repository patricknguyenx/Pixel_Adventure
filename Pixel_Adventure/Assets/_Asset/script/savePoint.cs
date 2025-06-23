using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savePoint : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // G?i t?i Player ?? l?u v? trí hi?n t?i
            playerRespawn.lastCheckpointPos = transform.position;
            Debug.Log("Checkpoint saved at: " + transform.position);
        }
    }
}
