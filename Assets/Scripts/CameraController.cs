using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera myCamera;

    private readonly int maxZoom = 16;
    private readonly int minZoom = 6;
    private readonly int zoomInterval = 2;

    static int currentZoom = 8;

    private void Awake()
    {
        if (myCamera == null)
        {
            myCamera = GetComponentInChildren<Camera>();
            SetZoom();
        }
    }
    public void UnzoomCamera()
    {
        if(myCamera.orthographicSize >= maxZoom) {
            currentZoom = minZoom;
        } else {
            currentZoom += zoomInterval;
        }
        SetZoom();
    }
    public void ZoomCamera() {
        if (myCamera.orthographicSize <= minZoom) {
            currentZoom = maxZoom;
        } else {
            currentZoom -= zoomInterval;
        }
        SetZoom();
    }

    private void SetZoom() {
        if (myCamera != null) {
            myCamera.orthographicSize = currentZoom;
        }
    }
}
