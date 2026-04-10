using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras;

    public void SwitchToCamera(int index)
    {
        for (int i = 0; i < cameras.Length; i++)
            cameras[i].gameObject.SetActive(i == index);
    }
}