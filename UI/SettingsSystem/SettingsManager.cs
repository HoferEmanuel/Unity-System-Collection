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

    [Header("Components")]
    public GraphicsSettingsMenu menu = GraphicsSettingsMenu.current;

    public static void CheckForChanges()
    {
        CheckGraphics();
    }

    public static void CheckGraphics()
    {
        
    }

    public void ResetGraphicsSettings()
    {
        ChangeRefreshrate(defaultRefreshrate);
        ChangeVsync(defaultVsync);
        ChangeFrameRate(defaultRefreshrate); 
    }

    public void ChangeRefreshrate(float targetValue)
    {
        Resolution.refreshRate = targetValue;
        PlayerPrefs.SetFloat("refreshRate", targetValue);
    }

    public void ChangeVsync(int targetAmount)
    {
        QualitySettings.vsynchCount = targetAmount;
        PlayerPrefs.SetInt("vsynch", targetAmount);
    }

    public void ChangeResolution(string targetRes)
    {
        Screen.SetResolution();
        PlayerPrefs.SetString("resolution", targetRes, FullScreenMode.ExclusiveFullScreen);
    }

    public void ChangeFrameRate(float targetValue)
    {
        Application.targetFrameRate = 300;
        PlayerPrefs.SetFloat("frameRate", targetValue);
    } 
}