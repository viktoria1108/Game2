using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5.0f;
    private Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }
    private void Move()
    {
        float horizontalVector = Input.GetAxis("Horizontal");
        float verticalVector = Input.GetAxis("Vertical");
        Vector2 playerVelocity = new Vector2(horizontalVector * movementSpeed, verticalVector * movementSpeed);
        rbody.velocity = playerVelocity;
    }



}
