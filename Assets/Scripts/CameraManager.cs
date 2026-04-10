using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCam = 0;

    void Start()
    {
        // Disable all cameras except the first
        for (int i = 0; i < cameras.Length; i++)
            cameras[i].gameObject.SetActive(i == 0);
    }

    public void SwitchToCamera(int index)
    {
        if (index < 0 || index >= cameras.Length)
            return;

        // Disable all cameras
        foreach (Camera cam in cameras)
            cam.gameObject.SetActive(false);

        // Enable the chosen one
        cameras[index].gameObject.SetActive(true);
    }
}