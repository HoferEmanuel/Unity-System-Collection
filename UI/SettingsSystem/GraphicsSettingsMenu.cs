using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GraphicsSettingsMenu : MonoBehaviour
{
    Resolution[] possibleResolutions;
    List<string> resList;

    private void Awake()
    {
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

    public void FirstTimeSetup()
    {
        SettingsManager.ChangeFrameRate();
    }

    public void ResetSettings()
    {

    } 

    public void SaveChanges()
    {

    }
}