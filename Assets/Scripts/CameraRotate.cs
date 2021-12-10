using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float RotX, RotY, Sensitivity;
    [SerializeField] private Rigidbody rb;

    void Update()
    {
        if(!PauseMenu.Active)
        {
            RotX += Input.GetAxisRaw("Mouse X") * Sensitivity;
            RotY += Input.GetAxisRaw("Mouse Y") * Sensitivity;
        }

        RotY = Mathf.Clamp(RotY, -90, 90);

        transform.rotation = Quaternion.Euler(-RotY, RotX, 0f);
        rb.MoveRotation(Quaternion.Euler(0f, RotX, 0f));
    }
}
