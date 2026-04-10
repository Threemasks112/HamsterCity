using UnityEngine;

public class FinalTrigger : MonoBehaviour
{
    public Rigidbody objectToLaunch;   // the object that will fly up
    public float launchForce = 500f;   // adjust as needed
    public GameObject boom;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hamster"))
        {
            objectToLaunch.AddForce(Vector3.up * launchForce, ForceMode.Impulse);
            Explode();
        }
    }

    private void Explode()
    {
        Instantiate(boom, transform.position, Quaternion.identity);
    }
}   