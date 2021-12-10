using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    public float speed, sprintSpeed, jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        bool sprint = Input.GetKey(KeyCode.LeftShift);

        float translation = Input.GetAxis("Vertical") * (sprint ? sprintSpeed : speed) * Time.deltaTime;
        float straffe = Input.GetAxis("Horizontal") * (sprint ? sprintSpeed : speed) * Time.deltaTime;
        transform.Translate(straffe, 0, translation);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
