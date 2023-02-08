using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetXROriginPositionClass2 : MonoBehaviour
{
    [SerializeField] private Transform xrOriginTransform;

    private void Update()
    {
        xrOriginTransform.position = new Vector3(xrOriginTransform.position.x, -0.622f, xrOriginTransform.position.z);
    }
}