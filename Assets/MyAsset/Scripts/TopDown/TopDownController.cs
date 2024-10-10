using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 _direction)
    {
        OnMoveEvent?.Invoke(_direction);
    }
    public void CallLookEvent(Vector2 _direction) 
    {
        OnLookEvent?.Invoke(_direction); 
    }


}
