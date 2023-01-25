using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera camera;

    private int maxZoom = 16;
    private int minZoom = 6;
    private int zoomInterval = 2;

    private void Awake()
    {
        if (camera == null)
        {
            camera = GetComponentInChildren<Camera>();
        }
    }
    public void UnzoomCamera()
    {
        if(camera.orthographicSize >= maxZoom) {
            camera.orthographicSize = minZoom;
        } else {
            camera.orthographicSize += zoomInterval;
        }
    }
    public void ZoomCamera() {
        if (camera.orthographicSize <= minZoom) {
            camera.orthographicSize = maxZoom;
        } else {
            camera.orthographicSize -= zoomInterval;
        }
    }
}
