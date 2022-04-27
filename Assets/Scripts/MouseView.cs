using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseView : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float x_Rotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        x_Rotation -= mouseY;
        x_Rotation = Mathf.Clamp(x_Rotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(x_Rotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
        
    }
}
