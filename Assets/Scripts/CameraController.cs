using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
     Vector2 targetPosition;

    public event Action<Vector2> OnTargetPositionChanged;

    private void Start()
    {
        targetPosition = transform.position;
    }

    private void MoveToPosition(Vector2 newPosition)
    {
        targetPosition = newPosition;

        transform.position = new Vector2(targetPosition.x, targetPosition.y);

        OnTargetPositionChanged?.Invoke(targetPosition);
    }


    public void BackPack()
    {
        targetPosition = new Vector2(20.5f, -0.2f);
        transform.position = targetPosition;
    }

    public void Chest()
    {
        targetPosition = new Vector2(19.67f, 0.11f);
        transform.position = targetPosition;
    }

    public void Shop()
    {
        targetPosition = new Vector2(-20.01f, -0.11f);
        transform.position = targetPosition;    
    }

    public void Menu()
    {
        targetPosition = new Vector2(0, 0);
        transform.position = targetPosition;
        Debug.Log("Camera moved back");
    }

    public void secondMenu()
    {
        targetPosition = new Vector2(0, 0);
        transform.position = targetPosition;
        Debug.Log("Camera moved back");
    }

}
