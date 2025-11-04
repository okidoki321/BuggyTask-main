using UnityEngine;

public class BuggyPlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;

    private Rigidbody2D rb;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        anim.SetBool("isMoving", moveInput != 0);
    }
}