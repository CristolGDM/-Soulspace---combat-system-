using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    PlayerControls inputActions;
    CameraController cameraController;
    SpriteController spriteController;

    private void Awake() {
        if (cameraController == null) {
            cameraController = GetComponent<CameraController>();
        }
        if (spriteController == null) {
            spriteController = GetComponent<SpriteController>();
        }
    }

    public void OnEnable()
    {
        if (inputActions == null)
        {
            inputActions = new PlayerControls();

            inputActions.UIControl.Zoom.performed += i => cameraController.ZoomCamera();
            inputActions.UIControl.UnZoom.performed += i => cameraController.UnzoomCamera();

            inputActions.UIControl.PrevCharacter.performed += i => spriteController.PreviousCharacter();
            inputActions.UIControl.NextCharacter.performed += i => spriteController.NextCharacter();

            inputActions.MovementControl.GoRight.performed += i => spriteController.SetDirectionRight();
            inputActions.MovementControl.GoDown.performed += i => spriteController.SetDirectionDown();
            inputActions.MovementControl.GoLeft.performed += i => spriteController.SetDirectionLeft();
            inputActions.MovementControl.GoUp.performed += i => spriteController.SetDirectionUp();

            inputActions.Enable();
        }
    }

    public void OnDisable() {
        if (inputActions != null) {
            inputActions.Disable();
        }
    }
}
