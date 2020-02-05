using UnityEngine;

public class PlayerMovement : Movement
{
    public float jumpForce = 10f;
    private Collider2D coll;

    private new void Start()
    {
        base.Start();
        coll = GetComponent<Collider2D>();
    }

    private void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        if (CanJump() && y > 0)
        {
            Jump();
        }

        Move();
    }

    private void Jump()
    {
        rb.velocity += new Vector2(0, jumpForce);
    }

    private bool CanJump()
    {
        Vector3 origin = transform.position;
        origin.y -= coll.bounds.extents.y + 0.01f;
        RaycastHit2D hit = Physics2D.Raycast(origin, -transform.up, 0.01f);
        return hit.collider != null;
    }
}
