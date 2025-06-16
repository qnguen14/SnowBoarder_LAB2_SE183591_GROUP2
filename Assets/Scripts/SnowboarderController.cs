using UnityEngine;

public class SnowboarderController : MonoBehaviour
{
    public float moveForce = 10f;
    public float maxSpeed = 15f;
    public float airTrickRotationSpeed = 360f; 
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask whatIsGround;

    private Rigidbody2D rb;
    private bool isGrounded;
    private bool isDoingTrick;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        
        if (!isGrounded && Input.GetKey(KeyCode.Space))
        {
            isDoingTrick = true;
        }
        else
        {
            isDoingTrick = false;
        }
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (rb.linearVelocity.magnitude < maxSpeed)
        {
            rb.AddForce(new Vector2(horizontal * moveForce, 0));
        }

        if (isDoingTrick)
        {
            
            transform.Rotate(0, 0, airTrickRotationSpeed * Time.fixedDeltaTime);
        }
    }
}
