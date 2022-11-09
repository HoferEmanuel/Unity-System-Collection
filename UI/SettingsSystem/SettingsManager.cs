using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SettingsManager
{
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
        ChangeRefreshrate(GraphicsSettingsMenu.current.defaultSettings.);
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
        PlayerPrefs.SetInt("vSynch", targetAmount);
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