using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] Transform resetTransform;
  [SerializeField] Camera playerHead;

  private void Start()
  {
      ResetPosition();
  }

  public void ResetPosition()
  {
    var rotationAngleY = playerHead.transform.rotation.eulerAngles.y - resetTransform.rotation.eulerAngles.y;

    var distanceDiff = resetTransform.position - playerHead.transform.position;

  }
}
