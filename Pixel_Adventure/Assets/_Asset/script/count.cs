using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class count : MonoBehaviour
{
    public controllerPoint controllerPoint;
    public Animator anim;
    private bool canCount = true;
    public void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.CompareTag("Player") && canCount)
        {
            canCount = false;
            anim.SetBool("collect", true);
            controllerPoint.score += 1;
            StartCoroutine(DelayCount());
            StartCoroutine(DestroyAfterDelay(gameObject, 0.5f));
           
        }
    }
    
    IEnumerator DelayCount()
    {
        yield return new WaitForSeconds(1f);  // Delay 1 gi�y m?i cho ??m ti?p
        canCount = true;
    }
    IEnumerator DestroyAfterDelay(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(obj);
    }
    
    
}
