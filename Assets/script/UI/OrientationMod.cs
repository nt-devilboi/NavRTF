using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationMod : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CanvasPortait;
    public GameObject CalvaslandScape;
    public GameObject CameraPlayer;
    public GameObject CameraRouter;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1f)
        {
            if (ManageUI.CurMod == ManageUI.Mod.Walk)
            {
                Screen.autorotateToPortrait = false;
            }
            else
            {
                Screen.autorotateToLandscapeLeft = false;
                Screen.autorotateToLandscapeRight = false;
            }
            
            return;
        }

       
        Screen.autorotateToPortrait = true;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToLandscapeRight = true;
        

        switch (Screen.orientation)
        {
            case ScreenOrientation.Portrait:
                SwitchToWalkMod(false);
                break;
            default:
                SwitchToWalkMod(true);
                break;
        }
    }

    private void SwitchToWalkMod(bool isWalk)
    {
        CameraRouter.SetActive(!isWalk);
        CanvasPortait.SetActive(!isWalk);
        CalvaslandScape.SetActive(isWalk);
        CameraPlayer.SetActive(isWalk);
    }
}