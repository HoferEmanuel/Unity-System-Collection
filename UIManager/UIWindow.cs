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
        UIWindowManager.current.OnCloseAllWindows += CloseAllWindows;
    }

    public void OpenWindow(int targetID)
    {

    }

    public void CloseWindow(int targetID)
    {

    }

    public void OpenSingleWindow(int targetID)
    {

    }
    
    public void CloseAllWindows()
    {

    }

    private void OnDestroy()
    {
        
        UIWindowManager.current.OnOpenWindow -= OpenWindow;
        UIWindowManager.current.OnCloseWindow -= CloseWindow;
        UIWindowManager.current.OnOpenSingleWindow -= OpenSingleWindow;
        UIWindowManager.current.OnCloseAllWindows -= CloseAllWindows;   
    }
}