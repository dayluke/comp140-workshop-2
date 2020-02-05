using UnityEngine;

public class Test : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("collider entered");
        if (collider.tag == "Player")
        {
            Debug.Log("Player");
        }
    }
}
