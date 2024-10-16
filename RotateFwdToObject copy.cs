using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateFwdToObject : MonoBehaviour {

  // Public field to set the target object in the Inspector
  public Transform targetObject;

  // Public field for speed, visible in the Inspector
  public float speed = 5f;

  public float rayLength = 5f; // Longitud del rayo
  public Color rayColor = Color.red; // Color del rayo

  void Update()
  {
    // Check if the target object is assigned
    if (targetObject != null)
    {
      
      transform.LookAt(targetObject);

      // Move the cube forward in its local forward direction
      transform.position += transform.forward * speed * Time.deltaTime;

      Debug.DrawRay(transform.position, transform.forward * rayLength, rayColor);

      
    }
    else
    {
      Debug.LogWarning("Target object is not assigned!", this);
    }
  }
}