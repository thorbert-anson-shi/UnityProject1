using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 movementValue;
    public float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void Run()
    {

    }
    void OnMove(InputValue input)
    {
        movementValue = input.Get<Vector2>();
        rb.MovePosition(rb.position + movementValue * moveSpeed);
    }
}
