using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    PlayerControls inputActions;
    CameraController cameraController;

    private void Awake() {
        if (cameraController == null) {
            cameraController = GetComponent<CameraController>();
        }
    }

    public void OnEnable()
    {
        if (inputActions == null)
        {
            inputActions = new PlayerControls();
            inputActions.UIControl.Zoom.performed += i => cameraController.ZoomCamera();
            inputActions.UIControl.UnZoom.performed += i => cameraController.UnzoomCamera();
            inputActions.Enable();
        }
    }

    public void OnDisable() {
        if (inputActions != null) {
            inputActions.Disable();
        }
    }
}
