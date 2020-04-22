using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    
    public float gravity = 20f;
    public float jumpSpeed = 8.0F;
    private Vector3 moveDirection = Vector3.zero;

    private Rigidbody selfRigidbody;
    private CharacterController character;

    void Start()
    {
        selfRigidbody = GetComponent<Rigidbody>();
        character = GetComponent<CharacterController>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            UpJump();
    }

    void UpJump()
    {
        if (ICanJump())
        {
            // Jump on ridigbody
            GetComponent<Rigidbody>().AddForce(jumpSpeed * transform.up, ForceMode.Impulse);
        }
    }

    bool ICanJump()
    {
        // Create Ray
        Ray ray = new Ray(transform.position, transform.up * -1);

        // Create Hit Info
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, transform.localScale.y + 0.2f))
        {
            return true;
        }

        // Nothing so return false
        return false;
    }

}
