using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    public float speed = 5f; 
    public float rotationSpeed = 100f; 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        
        float moveVertical = Input.GetAxis("Vertical"); 
        float moveHorizontal = Input.GetAxis("Horizontal"); 

        
        Vector3 movement = transform.forward * moveVertical * speed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);

        Quaternion rotation = Quaternion.Euler(0f, moveHorizontal * rotationSpeed * Time.deltaTime, 0f);
        rb.MoveRotation(rb.rotation * rotation);
    }
}