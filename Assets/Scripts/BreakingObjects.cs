using UnityEngine;

public class BreakingObjects : MonoBehaviour
{
   public GameObject explosionEffect;
   public ToppleingOBJ toppelingOBJ;  

   //public Rigidbody hospital;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OBJ")) //the object it is looking for
        {
            Explode();
        }
    }

    void Explode() //the explostion effect adder :)
    {
        
        Instantiate(explosionEffect, transform.position, Quaternion.identity);
        

        if(toppelingOBJ != null)
        {
            toppelingOBJ.startFalling = true;
        }

        gameObject.SetActive(false);      
        Destroy(gameObject, 4f); // dealy on destructiuon
    }


}
