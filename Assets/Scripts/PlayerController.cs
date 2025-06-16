using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Speed Settings")]
    [SerializeField] float normalSpeed = 10f;
    [SerializeField] float boostSpeed = 20f;

    [Header("Torque Settings")]
    [SerializeField] float torque = 30f;

    Rigidbody2D rbdy;

    void Start()
    {
        rbdy = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HandleRotation();
        HandleMovement();
    }

    void HandleRotation()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rbdy.AddTorque(torque);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rbdy.AddTorque(-torque);
        }
    }

    void HandleMovement()
    {
        float speed = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)
            ? boostSpeed
            : normalSpeed;

       
        rbdy.linearVelocity = new Vector2(speed, rbdy.linearVelocity.y);
    }
}
