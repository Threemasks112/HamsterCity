using UnityEngine;

public class Camera_M_F : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = target.position + offset;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
}
