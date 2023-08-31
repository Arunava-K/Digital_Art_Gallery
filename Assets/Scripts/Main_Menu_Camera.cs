using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu_Camera : MonoBehaviour
{
    public float rotationSpeed = 30f; // Adjust this value to control the rotation speed

    private float currentRotation = 0f;
    private bool isRotatingForward = true;

    void Update()
    {
        RotateObject();
    }

    private void RotateObject()
    {
        // Calculate the new rotation based on the current rotation speed and the frame time
        float rotationDelta = rotationSpeed * Time.deltaTime;

        // Update the rotation based on the current direction
        currentRotation += isRotatingForward ? rotationDelta : -rotationDelta;

        // Apply the new rotation to the object
        transform.rotation = Quaternion.Euler(0f, currentRotation, 0f);

        // Check if the rotation has reached 360 or 0 to reverse the direction
        if (currentRotation >= 360f || currentRotation <= 0f)
        {
            isRotatingForward = !isRotatingForward;
        }
    }
}