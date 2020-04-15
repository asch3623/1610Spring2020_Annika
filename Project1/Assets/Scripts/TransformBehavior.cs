using UnityEngine;

public class TransformBehavior
    : MonoBehaviour
{

    public string otherTagCheck;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(otherTagCheck)) return;
        {
            transform.parent = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}
