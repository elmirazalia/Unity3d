using UnityEngine;

public class CameraFirstPerson : MonoBehaviour
{
    public Transform player;

    void LateUpdate()
    {
        if (player == null) return;
        transform.position = player.position;
        transform.rotation = player.rotation;
    }
}
