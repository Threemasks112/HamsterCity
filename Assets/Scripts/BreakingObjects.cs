using UnityEngine;

public class BreakingObjects : MonoBehaviour
{
   public GameObject explosionEffect;  

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OBJ")) //the object it is looking for
        {
            Explode();
        }
    }

    void Explode() //the explostion effect adder :)
    {
        // Spawn explosion effect
        Instantiate(explosionEffect, transform.position, Quaternion.identity);

        // Make the gas station disappear
        gameObject.SetActive(false);

        // Optional: destroy it after a delay
        Destroy(gameObject, 4f);
    }


}
