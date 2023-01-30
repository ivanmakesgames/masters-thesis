using UnityEngine;

public class SetXROriginPosition : MonoBehaviour
{
    [SerializeField] private Transform xrOriginTransform;

    private void Update()
    {
        xrOriginTransform.position = new Vector3(xrOriginTransform.position.x, -0.62f, xrOriginTransform.position.z);
    }
}