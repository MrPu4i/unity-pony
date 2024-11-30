using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public Rigidbody2D rb;
    [SerializeField] public Vector2 vec2;
    [SerializeField] public float speed = 1f;
    private bool directionLeft;
    void Start()
    {
    }

    void Update()
    {
        if (vec2.x < 0 && directionLeft)
        {
            Flip();
        }
        if (vec2.x > 0 && !directionLeft)
        {
            Flip();
        }
        Walk();
    }

    void Walk()
    {
        vec2.x = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(vec2.x * speed, vec2.y);
        //direction = -Mathf.Abs(transform.localScale.x) * Mathf.Sign(vec2.x);
        //transform.localScale = new Vector3(direction, transform.localScale.y, transform.localScale.z);
    }
    void Flip()
    {
        directionLeft = !directionLeft;

        Vector2 theScale= transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
