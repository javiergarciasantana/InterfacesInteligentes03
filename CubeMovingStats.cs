using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovingStats : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 moveDirection = new Vector3(1, 0, 0);
    public float speed = 2f;
    
    void Start()
    {
      transform.position = new Vector3(transform.position.x, 0, transform.position.z); 
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(moveDirection.normalized * speed * Time.deltaTime); //Space.World
        
    }
}
