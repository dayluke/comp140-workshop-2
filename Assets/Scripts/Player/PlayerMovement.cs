using UnityEngine;

public class PlayerMovement : Movement
{
    private void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        Move();
    }
}
