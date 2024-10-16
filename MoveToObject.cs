using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveToObject : MonoBehaviour {

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
      Vector3 direction = (targetObject.position - transform.position).normalized;

      // Move the object towards the target
      transform.position += direction * speed * Time.deltaTime;
    }
    else
    {
      Debug.LogWarning("Target object is not assigned!", this);
    }
  }
}