using UnityEngine;

public class SetXROriginPositionWhileSeat : MonoBehaviour
{
    [SerializeField] private Transform xrOriginTransform;

    private void Update()
    {
        xrOriginTransform.position = new Vector3(xrOriginTransform.position.x, -1.002f, xrOriginTransform.position.z);
    }
}