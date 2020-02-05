using UnityEngine;

public class BoxInteraction : Interaction
{
    protected override void OnEnter()
    {
        Debug.Log("Box hit");
    }
}
