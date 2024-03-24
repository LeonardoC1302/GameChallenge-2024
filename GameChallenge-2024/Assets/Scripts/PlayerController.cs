using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 movement;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        movement = moveInput.normalized * speed;
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
        // print input direction
        print(movement);
    }
}
