using UnityEngine;

public class DealetingObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("OBJ"))
        {
            Destroy(gameObject);
        }
    }
}
