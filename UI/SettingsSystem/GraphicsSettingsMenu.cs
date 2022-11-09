using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GraphicsSettingsMenu : MonoBehaviour
{
    public static GraphicsSettingsMenu current; 

    public GraphicSettings defaultSettings, currentSettings;

    Resolution[] possibleResolutions;
    List<string> resList;

    [Header("Graphics")]
    public TMP_Dropdown resolutionDropdown, screenModeDropdown;
    public TMP_Dropdown frameRateInput, vSyncInput;
    public TMP_InputField frameRateInput;

    [Header("Controls")]
    public Slider mouseSensX, mouseSensY;
    public Toggle holdToAim, holdToCrouch,


    private void Awake()
    {
        current = this;

        GetAllResolutions();
    }  


    void GetAllResolutions()
    {
        possibleResolutions = Screen.resolutions;

        for (int i = 0; i < possibleResolutions.Length; i++)
        {
            string targetRes = possibleResolutions[i].width.ToString() + " x " + possibleResolutions[i].height.ToString();

            if (!resList.Contains(targetRes))
                resList.Add(targetRes);
        }
    }

    public Resolution GetRes(string targetRes)
    {
        foreach(var res in resList)
        {
            if (targetRes == res.width.ToString() + " x " + res.height.ToString())
                return res;
        }

        return null;
    }

    public int GetDropdownOptionByName(TMP_Dropdown targetSlider, string targetText)
    {
        for(int i = 0; i < targetSlider.options.Length; i++)
        {
            if(targetSlider.options[targetSlider.value].text == targetText)
                return i;
        }

        return 0;
    }

    public void ResetSettings() => SettingsManager.ResetGraphicsSettings();

    public void SaveChanges()
    {

    }
}

[System.Serializable]
public class GraphicSettings
{
    public string resolution;
    public string screenMode;
    public int framerate;
    public int refreshRate;
    public int vSyncCount;
    public int monitorIndex;
}