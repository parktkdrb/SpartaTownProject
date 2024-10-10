using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController controller;
    private Rigidbody2D movementRigidbody;
    private Vector2 movementDirection;

    private void Awake()
    {
        //TopDownMovement와 TopDownController가 같은 곳에 존재해야한다.
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }


    private void Move(Vector2 _direction)
    {
        movementDirection = _direction;
    }
    private void ApplyMovement(Vector2 _direction)
    {
        _direction = _direction * 5;
        movementRigidbody.velocity = _direction;
    }
}