using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 10f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float currentSpeed = Speed;
        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            currentSpeed = Speed * 2;
            transform.position += movement * currentSpeed * Time.deltaTime;
        }
        else
        {
            transform.position += movement * currentSpeed * Time.deltaTime;
        }
    }
}
