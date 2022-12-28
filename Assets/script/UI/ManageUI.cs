using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ManageUI: MonoBehaviour
{
    public enum Mod
    {
        Walk,
        LockWalk
    }
    
    public static bool GameIsPaused;
    public GameObject pauseMenuUi;
    public GameObject[] UIMods;
    public Dictionary<string,GameObject> DictMenu;
    public static Mod CurMod;
    
    private int indexMod;
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
        
        CheckMode();
        if (GameIsPaused)
            Resume();
        else
            Pause();
    }

    public void Resume()
    {
        CheckMode();
        pauseMenuUi.SetActive(false);
        DictMenu[UIMods[indexMod].name].SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Debug.Log("РАбоатет");
    }

    public void Pause()
    {
        CheckMode();
        pauseMenuUi.SetActive(true);
        DictMenu[UIMods[indexMod].name].SetActive(false);
        Time.timeScale = 0;
        GameIsPaused = true;
        Debug.Log("пауза");
    }

    private void CheckMode()
    {
        CurMod = Screen.orientation == ScreenOrientation.Portrait ? Mod.LockWalk : Mod.Walk;
        indexMod = Screen.orientation == ScreenOrientation.Portrait ? 1 : 0;
    }
    
}
