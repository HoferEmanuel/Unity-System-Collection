using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SettingsManager
{
    [Header("Components")]
    public GraphicsSettingsMenu graphics = GraphicsSettingsMenu.current;

    public static void CheckForChanges()
    {
        GraphicSettings gs = graphics.currentSettings;

        if(gs.resolution != graphics.resolutionDropdown.options[graphics.resolutionDropdown.value].text)
            ChangeResolution(graphics.resolutionDropdown.options[graphics.options[graphics.resolutionDropdown.value].text]);

        if(graphics.currentSettings.)
    }

    public static void CheckGraphics()
    {
        
    }

    public void ResetGraphicsSettings()
    {
        ChangeRefreshrate(graphics.defaultSettings.refreshRate);
        ChangeVsync(graphics.defaultSettings.vSyncCount);
        ChangeFrameRate(graphics.defaultSettings.frameRate); 
        ChangeResolution(graphics.defaultSettings.resolution);
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
        Resolution res = graphics.GetRes(targetRes);
        Screen.SetResolution(res.width, res.height, Screen.FullScreenMode);
        PlayerPrefs.SetString("resolution", targetRes, FullScreenMode.ExclusiveFullScreen);
    }

    public void ChangeFrameRate(float targetValue)
    {
        Application.targetFrameRate = 300;
        PlayerPrefs.SetFloat("frameRate", targetValue);
    } 
}