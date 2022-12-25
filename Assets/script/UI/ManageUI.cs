using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ManageUI: MonoBehaviour
{
    public static bool GameIsPaused;

    public GameObject pauseMenuUi;
    public GameObject[] UIMods;
    public GameObject RouteModeMenu;
    public Dictionary<string,GameObject> DictMenu;
    // Update is called once per frame

    private void Start()
    {
        DictMenu = CreateDictMods();
    }

    private Dictionary<string, GameObject> CreateDictMods()
    => UIMods.ToDictionary(mode => mode.name);
    
    

    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Escape))
            return;
        
        if (GameIsPaused)
            Resume();
        else
            Pause();
    }

    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        DictMenu["GameUI"].SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("РАбоатет");
    }

    public void Pause()
    {
        pauseMenuUi.SetActive(true);
        DictMenu["GameUI"].SetActive(false);
        Time.timeScale = 0;
        GameIsPaused = true;
        Debug.Log("пауза");
    }

    public void ChangeMode()
    {
        
    }
    
}
