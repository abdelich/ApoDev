using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 6.0f;

    private Vector3 moveDirection;


    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float deltaZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        moveDirection = new Vector3(deltaX, 0, deltaZ);

        moveDirection = Vector3.ClampMagnitude(moveDirection, speed);
        transform.Translate(moveDirection);
    }
}
