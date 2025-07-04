using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class count : MonoBehaviour
{
    public controllerPoint controllerPoint;
    // public static int score = 0;
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
           // Debug.Log("?i?m hi?n t?i: " + score);
          //  UpdateScoreUI();
        }
    }
    //void UpdateScoreUI()
    //{
    //    if (scoreText != null)
    //    {
    //        scoreText.text = "<b>Apple: " + score + "</b>";
    //    }
    //}
    IEnumerator DelayCount()
    {
        yield return new WaitForSeconds(1f);  // Delay 1 giây m?i cho ??m ti?p
        canCount = true;
    }
    IEnumerator DestroyAfterDelay(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(obj);
    }
    // Start is called before the first frame update
    //void Start()
    //{
    //    UpdateScoreUI();
    //    scoreText.color = Color.red;
    //}

    // Update is called once per frame
    //void Update()
    //{
        
    //}
    
}
