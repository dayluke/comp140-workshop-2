using UnityEngine;

public class Movement : MonoBehaviour
{
    protected float x = 0f;
    protected float y = 0f;
    public float speed = 1f;
    protected Rigidbody2D rb;

    protected void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    protected void Move()
    {
        rb.velocity = new Vector2 (x * speed * Time.deltaTime, rb.velocity.y);
    }
}
