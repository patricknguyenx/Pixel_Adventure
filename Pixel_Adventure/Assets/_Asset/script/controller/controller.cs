using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public GameObject ui_gameover;
    public GameObject ui_setting;
    public GameObject ui_win;

    public playerRespawn playerRespawn;
    void Start()
    {
        ui_gameover.SetActive(false);
        ui_setting.SetActive(false);
        ui_win.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickUigameover()
    {
        
        ui_gameover.SetActive(true);
    }
    public void OnClickUisetting()
    {
        Time.timeScale = 0;
        ui_setting.SetActive(true);
    }
    public void OnClickUiwin()
    {
        Time.timeScale = 0;
        ui_win.SetActive(true);
    }


    public void Resetgame()
    {

        Time.timeScale = 1f;
        ui_gameover.SetActive(false);
        ui_setting.SetActive(false);
        ui_win.SetActive(false);
        playerRespawn.reset();
    }
    public void continueGame()
    {
        Time.timeScale = 1f;
        ui_gameover.SetActive(false);
        ui_setting.SetActive(false);
        ui_win.SetActive(false);
    }



}
