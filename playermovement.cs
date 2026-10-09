using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    private float moveSpeed = 100;
    private float jumpingPower = 350;
    public const string RIGHT = "right";
    public const string LEFT = "left";
    public projectilescript projectilePrefab;
    public Transform launchOffset;
    string sprint = "false";
    string pressed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        player = GetComponent<Rigidbody2D>();
    }

    void Update() { // Collects player input
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            pressed = RIGHT;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
            pressed = LEFT;
        }        
        else {
            pressed = null;
        }
        
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space)) && IsGrounded()) {
            player.linearVelocity = new Vector2(player.linearVelocity.x, jumpingPower);
        }
        
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
            sprint = "true";
        }
        else {
            sprint = "false";
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            Instantiate(projectilePrefab, launchOffset.position, transform.rotation);
        }
        
    }

    private void FixedUpdate () { // Moves the player based on input
    if (pressed == "right") 
    {
        player.linearVelocity = new Vector2(
            sprint == "true" ? moveSpeed * 2 : moveSpeed,
            player.linearVelocity.y
        );
    }
    else if (pressed == "left") 
    {
        player.linearVelocity = new Vector2(
            sprint == "true" ? -moveSpeed * 2 : -moveSpeed,
            player.linearVelocity.y
        );
        }
    else 
    {
        player.linearVelocity = new Vector2(0, player.linearVelocity.y);
    }
}

    private bool IsGrounded() { // Checks if the player is on the ground
        return Physics2D.OverlapCircle(groundCheck.position, 1f, groundLayer);
    }
}
