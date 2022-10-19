using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    /*
        !!To use this script you will need to install the Input System for Unity!!

        Including action maps for:
        - Player Movement > PlayerMovement
        - UI Interactions > UIControls
    */

    public static InputManager current;

    //a test script which will invoke all assigned events also contains functions like movementHandling for the InputSystem.
    public InputManagerTest player;

    //PlayerControls is representing the Action Input Script which was created in the Unity-Editor.
    //Either generate a script with the name "PlayerControls" or change the variable name to your generated script. 
    public PlayerControls controls;

    public PlayerControls.PlayerMovement movement;
    public PlayerControls.UIControls uiControl;

    private void Awake()
    {
        current = this;

        //assiging Controls + ActionMaps.
        controls = new PlayerControls();

        movement = controls.PlayerMovement;
        uiControl = controls.UIControls;

        //event subscriptions.
        AssignPlayerControl();
        AssignUIControl();
    }

    private void AssignPlayerControl()
    {
        movement.PlayerJump = context += InputManagerTest.PlayerJump();
    }

    private void AssignUIControl()
    {
        uiControl.PauseGame.performed = context += InputManagerTest.PauseGame();
        uiControl.ToggleInventory.performed = context += InputManagerTest.ToggleInventory();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDestroy()
    {
        controls.Disable();
    }
}