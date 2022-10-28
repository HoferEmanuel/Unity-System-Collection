using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManagerTest : MonoBehaviour
{
    public static InputManagerTest current;

    private void Awake()
    {
        current = this;
    }

    public void PauseMenu() => Debug.Log("pausing menu");

    public void ToggleInventory => Debug.Log("toggleInventory");

    public void PlayerJump() => Debug.Log("PlayerJump");

    private void PlayerMove()
    {
        
    }
}
