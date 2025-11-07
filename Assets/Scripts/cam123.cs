using UnityEngine;

public class cam123 : MonoBehaviour
{
    public Camera mainCamera;
    public Camera cam1;
    public Camera cam2;

    void Start()
    {
        // Pastikan hanya main camera yang aktif di awal
        mainCamera.enabled = true;
        cam1.enabled = false;
        cam2.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Main Camera aktif");
            mainCamera.enabled = true;
            cam1.enabled = false;
            cam2.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Cam 1 aktif");
            mainCamera.enabled = false;
            cam1.enabled = true;
            cam2.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("Cam 2 aktif");
            mainCamera.enabled = false;
            cam1.enabled = false;
            cam2.enabled = true;
        }
    }
}
