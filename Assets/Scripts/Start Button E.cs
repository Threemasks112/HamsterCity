using UnityEngine;

public class StartButtonE : MonoBehaviour
{   

    public AudioSource music;
    public float rollforce = 10f;

    public Transform[] waypoints;
    public float moveSpeed = 20f;
    public float reachDistance = 1f;
    public float ballSpinner = 5f;


    public Transform roundaboutCenter;
    public float orbitForce = 10f;
    public float orbitRadius = 5f;
    public bool orbitMode = false;
    
    
    private Rigidbody rb;
    private bool started = false;
    private int hitCounter = 0;
    private bool followPath = false;
    private int currentWaypoint = 0;



    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if(!started && Input.GetKeyDown(KeyCode.E))
        {
            started = true;

            rb.isKinematic = false;
            music.Play();

            rb.AddForce(transform.forward * rollforce, ForceMode.Impulse);
        }
         if (followPath)
        {
            FollowWaypoints();
            RollBall();
        }

    }

    [System.Obsolete]
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("OBJ"))
        {
            hitCounter++;

           if (hitCounter == 1)
            {
                // First hit → normal bounce
                Vector3 direction = (transform.position - collision.transform.position).normalized;
                rb.AddForce(direction * rollforce, ForceMode.Impulse);
            }
            else if (hitCounter == 3)
            {
               followPath = true;
                rb.velocity = Vector3.zero; 
                rb.isKinematic = true;              

            }
            
        }
    }

    void FollowWaypoints()
    {
        if (currentWaypoint >= waypoints.Length)
            return;

        Transform target = waypoints[currentWaypoint];

        // Move toward waypoint
        transform.position = Vector3.MoveTowards(transform.position,target.position,moveSpeed * Time.deltaTime);

        // Check if reached
        if (Vector3.Distance(transform.position, target.position) < reachDistance)
        {
            currentWaypoint++;
        }
    }

    [System.Obsolete]
    void RollBall()
    {
        if (rb.velocity.magnitude > 0.1f)
        {
            float rotationSpeed = rb.velocity.magnitude * ballSpinner;
            transform.Rotate(rb.velocity.z * rotationSpeed, 0, -rb.velocity.x * rotationSpeed);
        }
    }

  
    
}
