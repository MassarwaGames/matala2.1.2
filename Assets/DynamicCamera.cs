using UnityEngine;

public class DynamicCamera : MonoBehaviour
{
    Camera mainCamera;

    void Start()
    {
        // Cache the Camera component
        mainCamera = GetComponent<Camera>();
    }

    void Update()
    {
        // Adjust camera size based on aspect ratio
        float aspectRatio = (float)Screen.width / Screen.height;
        mainCamera.orthographicSize = 5f / aspectRatio;
    }
}
