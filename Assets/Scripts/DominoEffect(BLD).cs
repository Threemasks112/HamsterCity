using UnityEngine;

public class DominoEffect : MonoBehaviour
{
    public Rigidbody rb;
    public float pushForce = 500f; 
    public Vector3 pushDirection = Vector3.right; // adjust direction

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BLD"))
        {
            rb.isKinematic = false;

            // Apply a push so it actually topples
            rb.AddForce(pushDirection * pushForce);
            
            

        }
    }

    
}