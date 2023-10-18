using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    GameObject Player;

    Rigidbody rb;

    float movementSpeed = 5000f;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(-horizontal * movementSpeed * Time.deltaTime, 0f, -vertical * movementSpeed * Time.deltaTime);

    }
}
