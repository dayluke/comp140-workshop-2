using UnityEngine;

public class EnemyMovement : Movement
{
    public Transform[] patrolPoints;
    private int currentPoint = 0;

    private new void Start()
    {
        base.Start();
        x = 1;
    }

    private void Update()
    {
        CheckIfReachedPoint();
        Move();
    }

    private void CheckIfReachedPoint()
    {
        if (Vector2.Distance(transform.position, patrolPoints[currentPoint].position) < 1f)
        {
            x *= -1;
            currentPoint++;
            currentPoint %= patrolPoints.Length;
        }
    }
}
