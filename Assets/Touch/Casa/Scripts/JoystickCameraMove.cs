using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickCameraMove : MonoBehaviour
{
    public JoystickMoveCharacter cameraJoystick;

    public Transform lookAt;

    private float distance = 0.1f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensivityX = 2.0f;
    private float sensivityY = 1.5f;

    private void Update()
    {
        currentX += cameraJoystick.InputDirection.x * sensivityX;
        currentY += cameraJoystick.InputDirection.z * sensivityY * -1;
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = lookAt.position + rotation * dir;
        transform.LookAt(lookAt);
    }
}
