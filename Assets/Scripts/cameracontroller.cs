using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float lookSpeed = 2f;

    float rotationX = 0f;
    float rotationY = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // --- Gerak pakai WASD ---
        float moveX = 0f;
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.W)) moveZ = 1f;
        if (Input.GetKey(KeyCode.S)) moveZ = -1f;
        if (Input.GetKey(KeyCode.A)) moveX = -1f;
        if (Input.GetKey(KeyCode.D)) moveX = 1f;

        Vector3 move = (transform.forward * moveZ + transform.right * moveX).normalized * moveSpeed * Time.deltaTime;
        transform.position += move;

        // --- Rotasi pakai mouse ---
        rotationX += Input.GetAxis("Mouse X") * lookSpeed;
        rotationY -= Input.GetAxis("Mouse Y") * lookSpeed;
        rotationY = Mathf.Clamp(rotationY, -80f, 80f);

        transform.rotation = Quaternion.Euler(rotationY, rotationX, 0);
    }
}
