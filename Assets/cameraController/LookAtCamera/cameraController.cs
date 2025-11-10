using UnityEngine;

public class CameraFollowLookAt : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    void LateUpdate()
    {
        if (player == null) return;
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform);
    }
}
