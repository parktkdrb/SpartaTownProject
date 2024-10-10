using System;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour 
{
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 _direction)
    {
        RotateArm(_direction);
    }

    private void RotateArm(Vector2 _direction)
    {
        float rot2 = Mathf.Atan2(_direction.y, _direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rot2) > 90f;

        armPivot.rotation = Quaternion.Euler(0, 0, rot2);
    }
}
