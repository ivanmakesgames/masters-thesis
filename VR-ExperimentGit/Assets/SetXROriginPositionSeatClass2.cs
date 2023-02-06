using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetXROriginPositionSeatClass2 : MonoBehaviour
{
    [SerializeField] private Transform xrOriginTransform;

    private void Update()
    {
        xrOriginTransform.position = new Vector3(xrOriginTransform.position.x, -1.116f, xrOriginTransform.position.z);
    }
}
