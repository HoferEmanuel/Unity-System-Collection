using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindow : MonoBehaviour
{
    public int id;
    public GameObject menuWindow;

    public void Awake()
    {
        UIWindowManager.current.AssignUIWindow(this);

        UIWindowManager.current.OnOpenWindow += OpenWindow;
        UIWindowManager.current.OnCloseWindow += CloseWindow;
        UIWindowManager.current.OnOpenSingleWindow += OpenSingleWindow;
        UIWindowManager.current.OnCloseAllWindows += CloseWindow;
    }

    public void OpenWindow(int targetID)
    {
        if (id == targetID)
            OpenWindow();
    }

    public void OpenWindow() => menuWindow.SetActive(true);

    public void CloseWindow(int targetID)
    {
        if (id == targetID)
            CloseWindow();
    }

    public void CloseWindow() => menuWindow.SetActive(false);

    public void OpenSingleWindow(int targetID)
    {
        if (id == targetID)
            OpenWindow();
        else
            CloseWindow();
    }
    
    private void OnDestroy()
    {
        
        UIWindowManager.current.OnOpenWindow -= OpenWindow;
        UIWindowManager.current.OnCloseWindow -= CloseWindow;
        UIWindowManager.current.OnOpenSingleWindow -= OpenSingleWindow;
        UIWindowManager.current.OnCloseAllWindows -= CloseAllWindows;  

        UIWindowManager.current.RemoveUIWindow(); 
    }
}