using UnityEngine;

public class Launchscript : MonoBehaviour
{

    public float launchForce = 8f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Hamster"))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            Vector3 direction = (transform.position - collision.transform.position).normalized;
            rb.AddForce(direction * launchForce, ForceMode.Impulse);
        }
    }
    
    void Start()
    {    
    }

    
    void Update()
    {   
    }
}
