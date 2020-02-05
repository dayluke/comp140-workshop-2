using UnityEngine;

abstract public class Interaction : MonoBehaviour
{
    protected void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("collider entered");
        if (collider.tag == "Player")
        {
            OnEnter();
        }
    }

    abstract protected void OnEnter();
}