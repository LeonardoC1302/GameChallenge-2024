using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f; // Speed of the character

    private new Rigidbody2D rigidbody2D; // Reference to the Rigidbody2D component

    public LayerMask solidObjectLayerMask; // Layer mask to filter solid object collisions

    private Vector2 input; // Input vector

    private bool IsMoving; // Flag to check if the player is moving

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsMoving) // Check if the player is not already moving
        {
            input.x = Input.GetAxis("Horizontal");
            input.y = Input.GetAxis("Vertical");

            Debug.Log("this is input.x " + input.x);
            Debug.Log("this is input.y " + input.y);

            if (input.x != 0)
                input.y = 0;

            if (input != Vector2.zero)
            {
                var targetPos = transform.position;
                targetPos.x += input.x;
                targetPos.y += input.y;

                if (isWalkable(targetPos))
                    StartCoroutine(Move(targetPos));
                else
                    IsMoving = false; // Stop moving if a collision occurs
            }
        }
    }

    IEnumerator Move(Vector3 targetPos)
    {
        IsMoving = true;
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            yield return null;
        }
        transform.position = targetPos;
        IsMoving = false;
    }

    private bool isWalkable(Vector3 targetPos)
    {
        if (Physics2D.OverlapCircle(targetPos, 0.2f, solidObjectLayerMask) != null)
        {
            return false;
        }
        return true;
    }
}
