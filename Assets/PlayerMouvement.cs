using UnityEngine;


public class PlayerMouvement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public bool isJumping;
    public bool isGrounded;

    public Transform groundCheckLeft;
    public Transform groundCheckRight;
    private Vector3 velocity = Vector3.zero; 

    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    void Update()
    {
        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight. position);

        float horizontalMouvement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
        }
        MovePlayer(horizontalMouvement);

        float characterVelocity = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("Speed", rb.velocity.x);
    }
    void MovePlayer(float _horizontalMouvement)
    {
        Vector3 tragetVelocity = new Vector2(_horizontalMouvement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, tragetVelocity, ref velocity, .05f);
    
        if(isJumping == true)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        } 
        Flip(velocity);
    }

    void Flip(Vector3 _velocity)
    {
        if (_velocity.x > 0.1f)
        {
            spriteRenderer.flipX = false;
        }else if(velocity.x < 0.1f)
        {
            spriteRenderer.flipX = true;
        }
    }

}