using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SettingsManager
{
    [Header("Graphics")]
    public static string defaultResolution;
    public static float defaultFramerate = 60;
    public static float defaultRefreshrate = 60;
    public static int defaultVsync = 0;

    public static void CheckForChanges()
    {

    }

    public static void CheckGraphics()
    {

    }

    public void SetRefreshRate(float targetValue)
    {

    }

    public void ChangeVsync()
    {

    }

    public void ChangeResolution(Vector2 targetRes)
    {
        string targetRes = targetRes.x.ToString() + " x " + targetRes.y.ToString();
        Screen.SetResolution()
        PlayerPrefs.SetString("resolution", targetRes, FullScreenMode.ExclusiveFullScreen);
    }

    public void ChangeFrameRate(float targetValue)
    {
        Application.targetFrameRate = 300;
        PlayerPrefs.SetFloat("frameRate", targetvalue);
    } 
}