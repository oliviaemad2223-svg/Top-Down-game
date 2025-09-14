using UnityEngine;

public class playermovement : MonoBehaviour
{
    
    public float speed = 5f;
    public Rigidbody2D rb;
    public int facingDirection = -1;
    public Animator anim;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        anim.SetFloat("horizontal", Mathf.Abs(horizontal));
        anim.SetFloat("vertical", Mathf.Abs(vertical));

        if(horizontal > 0 && transform.localScale.x > 0 ||
        horizontal < 0 && transform.localScale.x < 0 )
        {
            Flip();
        }

        rb.linearVelocity = new Vector2(horizontal, vertical) * speed;
    }

    void Flip()
    {
        facingDirection += -1;
        transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
