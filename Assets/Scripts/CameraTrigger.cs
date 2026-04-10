using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public int cameraIndex = 0;

    [System.Obsolete]
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hamster")) 
        {
            
            FindObjectOfType<CameraSwitcher>().SwitchToCamera(cameraIndex);
        }
    }
}