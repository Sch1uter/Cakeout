using UnityEngine;

public class BallMovement3D : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    private bool isLaunched = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; 
    }

    void Update()
    {
        if (!isLaunched && Input.GetKeyDown(KeyCode.Space))
        {
            LaunchBall();
        }
    }

    void LaunchBall()
    {
      
        Vector3 initialDirection = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
        rb.velocity = initialDirection * speed;
        isLaunched = true;
    }

    void FixedUpdate()
    {
        Vector3 velocity = rb.velocity;
        velocity.y = 0f;
        rb.velocity = velocity;
    }
}