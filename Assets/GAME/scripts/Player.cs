using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 0.1f;
    [SerializeField] Rigidbody rb;
    void Update()
    {
        Moving();
    }
    void Moving()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = -Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = Vector3.forward * speed;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = Vector3.back * speed;
        }
    }
}