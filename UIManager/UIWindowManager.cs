using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindowManager : MonoBehaviour
{
    public static UIWindowManager current;
    public List<UIWindow> uiWindows;

    public event Action<int> OnOpenWindow;
    public event Aciton<int> OnCloseWindow;
    public event Action<int> OnOpenSingleWindow;

    public event Action OnCloseAllWindows;

    private void Awake()
    {
        current = this;
    }

    public void OpenWindow(int targetID) => OnOpenWindow?.Invoke(targetID);

    public void CloseWindow(int targetID) => OnCloseWindow?.Invoke(targetID);

    public void OpenSingleWindow(int targetID) => OnOpenSingleWindow?.Invoke(targetID);

    public void AssignUIWindow(UIWindow targetWindow)
    {
        uiWindows.Add(targetWindow);
        targetWindow.id = uiWindows.Count - 1;
    }

    public void RemoveUIWindow(uiWindows targetWindow) => uiWindows.Remove(targetWindow);
}