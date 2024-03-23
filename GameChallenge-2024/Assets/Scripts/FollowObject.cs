using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform target; // Reference to the object the camera will follow
    public Vector3 offset = new Vector3(0f, 3f, -10f);
    void Start()
    {

    }

     void Update()
    {
        if (target != null)
        {
            // Update the position of the camera to match the position of the target plus the offset
            transform.position = target.position + offset;
        }
    }
}
