using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Unity.VisualScripting.FlowStateWidget;

//class PlayerData
//{
//    public int Score;
//    public int Die;
//}
public class controllerPoint : MonoBehaviour
{
    public Text scoreText;
    public Text dieText;
    public int die;
    public int die_ = 0;
    public static int score = 0;
    private int score_ = 0;
    private const string diekey = "dieint";

    public bool dead;

    void Start()
    {
         dead = false;
        loadData();
    }


    void Update()
    {
        if (score_ != score)
        {
            scoreText.text = "<b>Apple: " + score + "</b>";
            score_ = score;

        }
        if (die_ != die)
        {
            dieText.text = "<b>Die: " + die + "</b>";
            die_ = die;
            saveData();
        }

    }
    public void saveData()
    {
        PlayerPrefs.SetInt(diekey, die);
        PlayerPrefs.Save();

    }

    public void loadData()
    {
        die = PlayerPrefs.GetInt(diekey, 0);

        //string json = PlayerPrefs.GetString("player_data");
        //var data = JsonUtility.FromJson<PlayerData>(json);

        //json = JsonUtility.ToJson(data);

    }

    public void ondie()
    {
        if (dead == false)
        {
           
            die += 1;
            dead = true;
            StartCoroutine(DelayCount());
        }

    }
    IEnumerator DelayCount()
    {
        yield return new WaitForSeconds(1f);  // Delay 1 giây m?i cho ??m ti?p
        dead = false;
    }
}