using UnityEngine;

public class MiniMapFollow : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The player object the mini-map should follow")]
    Transform player;

    void LateUpdate()
    {
        if (player == null) return;

        // Follow the player's position
        Vector3 newPosition = player.position;
        newPosition.z = transform.position.z; // Keep the MiniMapCamera's height fixed
        transform.position = newPosition;
    }
}
