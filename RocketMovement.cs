using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public Rigidbody target;
    public float speed = 1.5f;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            target.velocity = transform.up * speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(80, 0, 0) * Time.deltaTime * speed, Space.World);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(-80, 0, 0) * Time.deltaTime * speed, Space.World);
        }
    }
}
