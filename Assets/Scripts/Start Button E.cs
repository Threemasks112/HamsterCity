using UnityEngine;

public class StartButtonE : MonoBehaviour
{   

    public AudioSource music;
    public float rollforce = 10f;

    private Rigidbody rb;
    private bool started = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(!started && Input.GetKeyDown(KeyCode.E))
        {
            started = true;

            rb.isKinematic = false;
            music.Play();

            rb.AddForce(transform.forward * rollforce, ForceMode.Impulse);
        }
    }
}
