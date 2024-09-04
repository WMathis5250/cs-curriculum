using UnityEngine;
public class PlayerController : MonoBehaviour
{
    // Movement variables
    public float xSpeed = 5f;
    private float xVector = 0f;
    private Rigidbody2D rb;
    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // Handle input
        // Your code here: Detect input for left and right movement
        // Hint: Use Input.GetAxis("Horizontal") to get smooth input
        // Calculate xVector based on input
        // Your code here: Set xVector based on the input
    }
    void FixedUpdate()
    {
        // Apply movement
        // Your code here: Use rb.velocity to move the player
        // Hint: Create a new Vector2 using xVector for the x component
    }
}
// Handle input
float horizontalInput = Input.GetAxis("Horizontal");