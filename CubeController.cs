using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
  // Public field for speed, visible in the Inspector
  public float speed = 5;
  private KeyCode keyCode;

  void Update()
  {
    // Simple forward movement of the cube
    transform.Translate(Vector3.forward * speed * Time.deltaTime);

    // Check if any key is pressed
    if (Input.anyKeyDown)
    {
      // Iterate over all possible keys to find which one was pressed
      foreach (KeyCode key in System.Enum.GetValues(typeof(KeyCode)))
      {
        if (Input.GetKeyDown(key))
        {
          // Assign the pressed key to the keyCode variable
          keyCode = key;

          // Check if the pressed key is "UpArrow" or "DownArrow"
          if (keyCode == KeyCode.UpArrow || keyCode == KeyCode.DownArrow)
          {
            // Log the key name and speed modified by the vertical axis input
            Debug.Log(keyCode.ToString() + ": " + speed * Input.GetAxis("Vertical"));
          }
          // Check if the pressed key is "LeftArrow" or "RightArrow"
          else if (keyCode == KeyCode.LeftArrow || keyCode == KeyCode.RightArrow)
          {
            // Log the key name and speed modified by the horizontal axis input
            Debug.Log(keyCode.ToString() + ": " + speed * Input.GetAxis("Horizontal"));
          }
          break; // Exit the loop once a key is detected
        }
      }
    }
  }
}
