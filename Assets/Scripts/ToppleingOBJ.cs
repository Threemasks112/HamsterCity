using UnityEngine;

public class ToppleingOBJ : MonoBehaviour
{
    public Rigidbody rb;
    public bool startFalling = false;
    public float pushForce = 700f; // adjust as needed
    public Vector3 pushDirection = Vector3.back; // direction to fall

    void Start()
    {
        rb.isKinematic = true; // stays still until triggered
    }

    void Update()
    {
        if (startFalling)
        {
            rb.isKinematic = false; // enable physics
            rb.AddForce(pushDirection * pushForce);
            startFalling = false; // only trigger once
        }
    }
}