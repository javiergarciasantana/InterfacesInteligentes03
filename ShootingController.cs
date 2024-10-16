using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
  // Prefab for the projectile
  public GameObject projectilePrefab;

  // Shooting position and direction
  public float projectileSpeed = 10f;

  void Update()
  {
    // Check if the "Fire1" input is triggered
    if (Input.GetButtonDown("Fire1"))
    {
      Shoot();
    }
  }

  void Shoot()
  {
    // Instantiate the projectile at the shoot point's position and rotation
    GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);

    // Add velocity to the projectile
    Rigidbody rb = projectile.GetComponent<Rigidbody>();
    if (rb != null)
    {
      rb.velocity = transform.forward * projectileSpeed;
    }

    // Optionally, destroy the projectile after a certain time
    Destroy(projectile, 5f);
  }
}
