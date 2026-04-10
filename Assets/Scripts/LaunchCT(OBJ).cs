using UnityEngine;

public class LaunchCT : MonoBehaviour
{

    public float launchForce = 8f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("OBJ"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 direction = (transform.position - collision.transform.position).normalized;
            rb.AddForce(direction * launchForce, ForceMode.Impulse);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
}
