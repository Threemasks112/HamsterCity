using UnityEngine;

public class ExplostionEffect : MonoBehaviour
{
    
   public GameObject explosionEffect;
   public GameObject burnigEffect;
   public GameObject eletricEffect;
   
   
   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OBJ")) 
        {
            Explode();
        }
    }

    void Explode() //the explostion effect adder :)
    {
        
        Instantiate(explosionEffect, transform.position, Quaternion.identity);
        Instantiate(burnigEffect, transform.position, Quaternion.identity);
        Instantiate(eletricEffect, transform.position, Quaternion.identity);
    


        gameObject.SetActive(false);      
        Destroy(gameObject, 4f); 
    }
}
