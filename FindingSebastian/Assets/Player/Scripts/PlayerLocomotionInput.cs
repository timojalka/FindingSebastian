using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLocomotionInput : MonoBehaviour, PlayerControls.IGameplayActions
{
    public PlayerControls PlayerControls { get; private set; }
    public Vector2 MovementInput {  get; private set; }

    private void OnEnable()
    {
        PlayerControls = new PlayerControls();
        PlayerControls.Enable();

        PlayerControls.Gameplay.Enable();
        PlayerControls.Gameplay.SetCallbacks(this);
    }

    private void OnDisable()
    {
        PlayerControls.Gameplay.Disable();
        PlayerControls.Gameplay.RemoveCallbacks(this);
    }

    public void OnMove(InputAction.CallbackContext context)
    { 
        MovementInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
