using UnityEngine;

public class Movement : MonoBehaviour
{
    protected float x = 0f;
    protected float y = 0f;
    public float speed = 1f;

    protected void Move()
    {
        transform.Translate(x * speed * Time.deltaTime, y * speed * Time.deltaTime, 0);
    }
}
