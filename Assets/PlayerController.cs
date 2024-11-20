using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Movement speed of the player")]
    float speed = 5f;
    [SerializeField]
    [Tooltip("Fixed Z position for player movement in a 2D environment")]
    float fixedZPosition = 0f;

    Transform objectTransform;

    void Start()
    {
        // Cache the Transform component
        objectTransform = GetComponent<Transform>();
    }

    void Update()
    {
        // Get input from arrow keys
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Apply movement
        objectTransform.position += new Vector3(moveX, moveY, fixedZPosition) * speed * Time.deltaTime;
    }
}

