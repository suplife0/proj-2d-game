using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private bool isArrowMode = true;
    [SerializeField] private float speed = 1.0f;

    private Vector2 moveDirection = Vector2.zero;
    
    private KeyCode up;
    private KeyCode down;
    private KeyCode right;
    private KeyCode left;

    private void InitializeMoveKey()
    {
        if (isArrowMode)
        {
            up = KeyCode.UpArrow;
            down = KeyCode.DownArrow;
            right = KeyCode.RightArrow;
            left = KeyCode.LeftArrow;
        }
        else
        {
            up = KeyCode.W;
            down = KeyCode.S;
            right = KeyCode.D;
            left = KeyCode.A;
        }
    }

    private void Awake()
    {
        InitializeMoveKey();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Move(Vector2 direction)
    {
        direction.Normalize();
        this.transform.position += (Vector3)(direction * (0.01f * speed));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(up))
        {
            moveDirection += Vector2.up;
        }
        else if (Input.GetKeyDown(down))
        {
            moveDirection += Vector2.down;
        }
        else if (Input.GetKeyDown(right))
        {
            moveDirection += Vector2.right;
        }
        else if (Input.GetKeyDown(left))
        {
            moveDirection += Vector2.left;
        }

        if (Input.GetKeyUp(up))
        {
            moveDirection -= Vector2.up;
        }
        else if (Input.GetKeyUp(down))
        {
            moveDirection -= Vector2.down;
        }
        else if (Input.GetKeyUp(right))
        {
            moveDirection -= Vector2.right;
        }
        else if (Input.GetKeyUp(left))
        {
            moveDirection -= Vector2.left;
        }
        Move(moveDirection);
    }
}
