using UnityEngine;

public class SceneReset : MonoBehaviour
{
    public Transform initialPosition; // Set this to the initial position of the player

    void ResetPlayerPosition()
    {
        // Reset player position to initialPosition
        transform.position = initialPosition.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Player has completed the scene, reset its position
            ResetPlayerPosition();
        }
    }
}
