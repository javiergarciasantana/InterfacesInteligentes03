using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereKeyControl : MonoBehaviour
{
  // Public field for speed, visible in the Inspector
  public float speed = 5;
  private KeyCode keyCode;

  void Update()
  {
    Vector3 moveDirection = Vector3.zero;
    if(Input.anyKey) 
    {
      switch (true) // Use 'true' for switching based on conditions
      {
        case bool _ when Input.GetKey(KeyCode.W):
          moveDirection += Vector3.up; // Move Up
          break;

        case bool _ when Input.GetKey(KeyCode.S):
          moveDirection += Vector3.down; // Move Down
          break;

        case bool _ when Input.GetKey(KeyCode.A):
          moveDirection += Vector3.left; // Move left
          break;

        case bool _ when Input.GetKey(KeyCode.D):
          moveDirection += Vector3.right; // Move right
          break;
      }
      transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
    }
  }
}
