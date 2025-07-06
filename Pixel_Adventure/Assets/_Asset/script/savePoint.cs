using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savePoint : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerRespawn.lastCheckpointPos = transform.position;
            Debug.Log("Checkpoint saved at: " + transform.position);
        }
    }
}
