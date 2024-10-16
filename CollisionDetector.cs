using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
  // OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider
  void OnCollisionEnter(Collision collision)
  {
    // Get the tag of the object that this cylinder collided with
    string collidedObjectTag = collision.gameObject.tag;

    // Log the name of the object that collided with this cylinder
    Debug.Log("Collision detected with: " + collidedObjectTag);
  }
}
