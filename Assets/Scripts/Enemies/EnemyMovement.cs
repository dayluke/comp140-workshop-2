using UnityEngine;

public class EnemyMovement : Movement
{
    public Vector3[] patrolPoints;
    private int currentPoint = 0;

    private void Start()
    {
        x = 1;
    }

    private void Update()
    {
        CheckIfReachedPoint();
        Move();
    }

    private void CheckIfReachedPoint()
    {
        if (Vector2.Distance(transform.position, patrolPoints[currentPoint]) < 0.5f)
        {
            x *= -1;
            currentPoint++;
            currentPoint %= patrolPoints.Length;
        }
    }
}
