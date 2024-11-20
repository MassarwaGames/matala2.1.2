using UnityEngine;

public class DynamicCamera : MonoBehaviour
{

    Camera mainCamera;
    [SerializeField]
    [Tooltip("Base orthographic size for the camera")]
    float baseOrthographicSize = 5f;


    void Start()
    {
        // Cache the Camera component
        mainCamera = GetComponent<Camera>();
    }

    void Update()
    {
        // Adjust camera size based on aspect ratio
        float aspectRatio = (float)Screen.width / Screen.height;
        mainCamera.orthographicSize = baseOrthographicSize / aspectRatio;
    }
}
