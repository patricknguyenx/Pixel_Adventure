using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controllerScene : MonoBehaviour
{
    public GameObject ui_level;

  
       
    void Start()
    {
        ui_level.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public void next_scene(string name)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(name);
        
    }
  
    public void OnClickUiLevel()
    {
        Time.timeScale = 1f;
        ui_level.SetActive(true);
    }
}
