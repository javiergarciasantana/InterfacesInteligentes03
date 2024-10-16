using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeKeyControl : MonoBehaviour
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
        case bool _ when Input.GetKey(KeyCode.UpArrow):
          moveDirection += Vector3.up; // Move Up
          break;

        case bool _ when Input.GetKey(KeyCode.DownArrow):
          moveDirection += Vector3.down; // Move Down
          break;

        case bool _ when Input.GetKey(KeyCode.LeftArrow):
          moveDirection += Vector3.left; // Move left
          break;

        case bool _ when Input.GetKey(KeyCode.RightArrow):
          moveDirection += Vector3.right; // Move right
          break;
      }
      transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
    }
  }
}
