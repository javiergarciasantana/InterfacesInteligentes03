using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateToObject : MonoBehaviour {

  // Public field to set the target object in the Inspector
  public Transform targetObject;

  // Public field for speed, visible in the Inspector
  public float speed = 5f;

  void Update()
  {
    // Check if the target object is assigned
    if (targetObject != null)
    {
      // Calculate the direction to the target object
    //   Vector3 direction = (targetObject.position - transform.position).normalized;

    //   // Calculate the target rotation
    //   Quaternion targetRotation = Quaternion.LookRotation(direction);

    //   // Rotate the object towards the target rotation at the specified speed
    //   transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, speed * Time.deltaTime);
    transform.LookAt(targetObject);
    }
    else
    {
      Debug.LogWarning("Target object is not assigned!", this);
    }
  }
}