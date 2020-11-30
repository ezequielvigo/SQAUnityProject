using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour
{

    public float mouseSens = 100f;
    public Transform playerBody;

    float xRotation = 0f;
    
    //Called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    //Updates once per frame
    void Update()
    {
        //Gets the curser input from the mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        //pivots the camera on the y axis from mouse input
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

    }

}